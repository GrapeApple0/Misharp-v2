using System.Text;

namespace Generator.Extensions
{
    public static class StringBuilderExtensions
    {
        public static void AppendLineWithIndent(this StringBuilder sb, string value, int indent)
        {
            sb.Append(new string('\t', indent));
            sb.AppendLine(value);
        }

        public static void AppendWithIndent(this StringBuilder sb, string value, int indent)
        {
            sb.Append(new string('\t', indent));
            sb.Append(value);
        }
    }
}
