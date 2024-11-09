using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Misharp
{
    internal static class Tools
    {
        internal static Random random = new();

        internal static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        internal static Dictionary<TKey, TValue> RemoveNullValues<TKey, TValue>(this Dictionary<TKey, TValue?> source) where TValue: notnull
            => (from kv in source
                where kv.Value != null
                select kv).ToDictionary(kv => kv.Key, kv => kv.Value);

        public static string? GetEnumMemberValue<T>(this T value) where T : Enum
        {
            return typeof(T)
                .GetTypeInfo()
                .DeclaredMembers
                .SingleOrDefault(x => x.Name == value.ToString())
                ?.GetCustomAttribute<EnumMemberAttribute>(false)
                ?.Value;
        }
    }
}
