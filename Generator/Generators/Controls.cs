using Generator.ApiJsonModels;
using Generator.Extensions;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Generator.Generators;

public class Controls
{
    public static void GenerateParamDictionaryCode(StringBuilder sb, List<string> ps, int indent = 3)
    {
        sb.AppendLineWithIndent("var param = new Dictionary<string, object?>", indent);
        sb.AppendLineWithIndent("{", indent);
        ps.ForEach(key => sb.AppendLineWithIndent($"{{ \"{key}\", {key} }},", indent + 1)); // { "key", key },
        sb.AppendLineWithIndent("};", indent);
    }

    public static void GenerateArgs(StringBuilder sb, StringBuilder subSB, string path,
        PathsObject.RequestBodyClass requestBody)
    {
        var defaultValues = new Dictionary<string, PropertiesObject>();
        Dictionary<string, PropertiesObject>? properties = default;
        if (requestBody.Content.ContainsKey("application/json"))
            properties = requestBody.Content["application/json"].Schema.Properties;
        else if (requestBody.Content.ContainsKey("multipart/form-data"))
            properties = requestBody.Content["multipart/form-data"].Schema.Properties;
        if (properties != null)
        {
            var argSB = new StringBuilder();
            foreach (var (key, property) in properties)
            {
                var schema = Tools.ConvertToPascalCase(path.Replace("/", "-")) + "Properties";
                var type = GetType(subSB, schema, key, property, 2);
                property.ObjectType = type;
                if (type.IsNullable || property.Default != null)
                {
                    defaultValues.Add(key, property);
                }
                else if (key == "untilId" || key == "sinceId" || key == "untilDate" || key == "sinceDate" ||
                         property.Items != null) // force nullable types
                {
                    type.IsNullable = true;
                    property.ObjectType = type;
                    defaultValues.Add(key, property);
                }
                else
                {
                    argSB.Append($"{type.Type} {key},");
                }
            }

            foreach (var (key, property) in defaultValues)
                if (property.ObjectType != null)
                {
                    argSB.Append($"{property.ObjectType.Value.Type}");
                    if (property.ObjectType.Value.IsNullable)
                    {
                        argSB.Append($"? {key} = null,");
                    }
                    else if (property.Default != null)
                    {
                        argSB.Append($" {key} = ");
                        if (property.Enum != null)
                            argSB.Append(
                                $"{property.ObjectType.Value.Type}.{Tools.ConvertToPascalCase(property.Default.ToString())},");
                        else if (property.ObjectType.Value.Type == "string")
                            argSB.Append($"\"{property.Default}\",");
                        else
                            argSB.Append($"{property.Default},");
                    }
                }

            if (argSB.Length > 0) argSB.Length -= 1;
            sb.Append(argSB);
        }
    }

    public static Tools.ObjectType GetType(StringBuilder sb, string schema, string propertyName,
        PropertiesObject property, int indent)
    {
        var type = Tools.ParseObjectType(property.Type, property.Format);
        var nullable = type.IsNullable;
        if (type.Type == "object")
        {
            type = Tools.GenerateObjectType(sb, sb, schema, propertyName, property,
                property.SourceInterfaceName != null, indent);
        }
        else if (type.Type == "array" && property.Items?.Type != null)
        {
            type = Tools.GenerateArrayType(sb, sb, schema, propertyName, property.Items,
                property.SourceInterfaceName != null, indent);
        }
        else if (property.Enum != null)
        {
            if (property.SourceInterfaceName == null)
                Tools.GenerateEnums(sb, schema + Tools.ConvertToPascalCase(propertyName), property.Enum, indent);
            type.Type = $"{Tools.ConvertToPascalCase(schema) + Tools.ConvertToPascalCase(propertyName)}Enum";
        }

        type.IsNullable = nullable;
        return type;
    }

    public static void GenerateFunction(StringBuilder sb, string path, PathsObject pathObject,
        ApiJsonModels.HttpMethod httpMethod, int indent = 2)
    {
        var responseType = new Tools.ObjectType();
        var propertiesSB = new StringBuilder();
        var argsSB = new StringBuilder();
        var needToken = pathObject.Security != null;
        var useForm = pathObject.RequestBody?.Content.ContainsKey("multipart/form-data") ?? false;
        var useGet = httpMethod == ApiJsonModels.HttpMethod.Get;
        var needParam = pathObject.RequestBody != null;
        var foundResponse = pathObject.Responses?.ContainsKey(200) ?? false;
        var id = pathObject.OperationId.Split("___");
        var schema = Tools.ConvertToPascalCase(id[0]);
        var functionName = Tools.ConvertToPascalCase(id[^1]);
        var requestType = useForm ? "multipart/form-data" : "application/json";
        if (useGet) functionName = $"{functionName}Get";
        if (needParam) GenerateArgs(argsSB, propertiesSB, path, pathObject.RequestBody!);
        if (foundResponse)
        {
            var res = pathObject.Responses?[200].Content["application/json"].Schema;
            var multipleProperties = res?.AllOf ?? res?.OneOf ?? res?.AnyOf;
            if (multipleProperties != null) res.Type = "object";
            responseType = GetType(propertiesSB, schema, functionName, res, indent);
        }
        else
        {
            responseType.Type = "EmptyResponse";
        }

        sb.AppendWithIndent($"public async Task<Response", indent);
        sb.Append($"<{responseType.Type}>");
        sb.Append($"> {functionName}(");
        sb.Append(argsSB);
        sb.AppendLine(")");
        sb.AppendLineWithIndent("{", indent);
        if (needParam)
            if (pathObject.RequestBody?.Content.ContainsKey(requestType) ?? false)
                GenerateParamDictionaryCode(sb,
                    pathObject.RequestBody?.Content[requestType].Schema.Properties.Keys.ToList(), indent + 1);

        sb.AppendWithIndent($"var result = await _app.Request", indent + 1);
        if (useForm) sb.Append("FormData");
        sb.Append($"<{responseType.Type}>");
        sb.AppendLine("(");
        sb.AppendLineWithIndent($"\"{path}\", ", indent + 2);
        if (needParam) sb.AppendLineWithIndent("param, ", indent + 2);
        if (!foundResponse)
            sb.AppendLineWithIndent("successStatusCode: System.Net.HttpStatusCode.NoContent, ", indent + 2);
        sb.AppendLineWithIndent($"needToken: {(needToken ? "true" : "false")}", indent + 2);
        sb.AppendLineWithIndent(");", indent + 1);
        sb.AppendLineWithIndent("return result;", indent + 1);
        sb.AppendLineWithIndent("}", indent);
        sb.AppendLine();
        sb.Append(propertiesSB);
    }

    public static void Generate(Dictionary<string, Dictionary<ApiJsonModels.HttpMethod, PathsObject>> paths)
    {
        if (!Directory.Exists("./Controls")) Directory.CreateDirectory("./Controls");
        var thirdLevelPaths = new Dictionary<string, Dictionary<ApiJsonModels.HttpMethod, PathsObject>>();
        var sbs = new Dictionary<string, StringBuilder>();
        var classes = new HashSet<string>();
        // ignore paths
        var ignorePaths = new[]
        {
            "drive/files/check-existence",
            "i/2fa/",
            "i/registry/",
            "bubble-game/",
            "reversi/",
            "fetch-rss",
            "reset-db",
            "v2/" //四階層になるので一旦無視
        };
        foreach (var (p, pathsObject) in paths)
        {
            // 書き換えたいのでここで代入
            // 先頭の/を削除
            var path = p.Remove(0, 1);
            foreach (var ignorePath in ignorePaths)
                if (path.StartsWith(ignorePath, true, null))
                {
                    Console.WriteLine($"Skipped: {path}");
                    goto CONTINUE; //goto end of foreach loop
                }

            var pathTree = path.Split("/");
            if (pathTree.Length == 3)
            {
                thirdLevelPaths.Add(path, pathsObject);
            }
            else
            {
                Console.WriteLine($"Generating Controls for {path}...");
                var ns = Tools.ConvertToPascalCase(pathTree[0]);
                var className = Tools.ConvertToPascalCase(pathTree[0]);
                if (!sbs.ContainsKey(className))
                {
                    sbs[ns] = new StringBuilder();
                    sbs[ns].AppendLine("using Misharp.Models;");
                    sbs[ns].AppendLine("using System.Text.Json;");
                    sbs[ns].AppendLine("using System.Text.Json.Nodes;");
                    sbs[ns].AppendLine("using System.Runtime.Serialization;");
                    sbs[ns].AppendLine("namespace Misharp.Controls");
                    sbs[ns].AppendLine("{");
                    sbs[ns].AppendLineWithIndent($"public class {className}Api", 1);
                    sbs[ns].AppendLineWithIndent("{", 1);
                    sbs[ns].AppendLineWithIndent("private readonly App _app;", 2);
                    classes.Add(className);
                }

                foreach (var (httpMethod, pathObject) in pathsObject)
                    GenerateFunction(sbs[className], path, pathObject, httpMethod);
            }

            CONTINUE: ;
        }

        foreach (var (ns, sb) in sbs)
        {
            var alreadyAppendedClasses = new List<string>();
            var className = ns;
            foreach (var subClass in from path in thirdLevelPaths.Keys
                     let pathTree = path.Split("/")
                     let subClass = Tools.ConvertToPascalCase(pathTree[1])
                     where path.StartsWith(ns, true, null) && !alreadyAppendedClasses.Contains(subClass)
                     select subClass)
            {
                alreadyAppendedClasses.Add(subClass);
                sbs[ns].AppendLineWithIndent($"public readonly {ns}.{subClass}Api {subClass}Api;", 2);
            }

            sbs[ns].AppendLineWithIndent($"public {className}Api(App app)", 2);
            sbs[ns].AppendLineWithIndent("{", 2);
            sbs[ns].AppendLineWithIndent("this._app = app;", 3);
            foreach (var subClass in alreadyAppendedClasses)
                sbs[ns].AppendLineWithIndent($"this.{subClass}Api = new {ns}.{subClass}Api(this._app);", 3);
            sbs[ns].AppendLineWithIndent("}", 2);
            //欠落している}を追加
            sb.AppendLineWithIndent("}", 1);
            sb.AppendLine("}");
            // 3階層目のクラスがない場合はここで書き出す
            if (!thirdLevelPaths.ContainsKey(ns)) File.WriteAllText($"./Controls/{ns}.cs", sbs[ns].ToString());
        }

        var thirdLevelSbsDic = new Dictionary<string, Dictionary<string, StringBuilder>>();
        foreach (var (path, pathsObject) in thirdLevelPaths)
        {
            var pathTree = path.Split("/");
            var ns = Tools.ConvertToPascalCase(pathTree[0]);
            var className = Tools.ConvertToPascalCase(pathTree[1]);
            if (!thirdLevelSbsDic.ContainsKey(ns)) thirdLevelSbsDic[ns] = new Dictionary<string, StringBuilder>();
            if (!thirdLevelSbsDic[ns].ContainsKey(className))
            {
                thirdLevelSbsDic[ns][className] = new StringBuilder();
                thirdLevelSbsDic[ns][className].AppendLineWithIndent($"public class {className}Api", 1);
                thirdLevelSbsDic[ns][className].AppendLineWithIndent("{", 1);
                thirdLevelSbsDic[ns][className].AppendLineWithIndent("private readonly App _app;", 2);
                thirdLevelSbsDic[ns][className].AppendLineWithIndent($"public {className}Api(App app)", 2);
                thirdLevelSbsDic[ns][className].AppendLineWithIndent("{", 2);
                thirdLevelSbsDic[ns][className].AppendLineWithIndent("this._app = app;", 3);
                thirdLevelSbsDic[ns][className].AppendLineWithIndent("}", 2);
                classes.Add(className);
            }

            foreach (var (httpMethod, pathObject) in pathsObject)
                GenerateFunction(thirdLevelSbsDic[ns][className], path, pathObject, httpMethod);
        }

        foreach (var (ns, thirdLevelSbs) in thirdLevelSbsDic)
        {
            foreach (var (_, sb) in thirdLevelSbs)
            {
                if (sb == null) continue;
                sb.AppendLineWithIndent("}", 1); //欠落している}を追加
                sbs[ns].AppendLine($"namespace Misharp.Controls.{ns}");
                sbs[ns].AppendLine("{");
                sbs[ns].Append(sb);
                sbs[ns].AppendLine("}");
            }

            File.WriteAllText($"./Controls/{ns}.cs", sbs[ns].ToString());
        }
    }
}