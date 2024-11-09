namespace Generator.Extensions
{
    public static class IDictionaryExtentions
    {
        public static Dictionary<TKey, TValue> Merge<TKey, TValue>(
          this Dictionary<TKey, TValue> target, Dictionary<TKey, TValue> source
        ) => target.Concat(source)
          .GroupBy(pair => pair.Key, (_, pairs) => pairs.First())
          .ToDictionary(pair => pair.Key, pair => pair.Value);

        public static Dictionary<TKey, TValue> Update<TKey, TValue>(
          this Dictionary<TKey, TValue> target, Dictionary<TKey, TValue> source
        ) => target.Concat(source)
          .GroupBy(pair => pair.Key, (_, pairs) => pairs.Last())
          .ToDictionary(pair => pair.Key, pair => pair.Value);
    }
}
