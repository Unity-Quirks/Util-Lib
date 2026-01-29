using System.Collections.Generic;
using System.Linq;

namespace Quirks.Collections
{
    public static class DictionaryExtensions
    {
        /// <summary>Returns the requsted KeyValuePair.</summary>
        public static KeyValuePair<TKey, TValue> GetPair<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            return new KeyValuePair<TKey, TValue>(key, dictionary[key]);
        }

        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> kvp, out TKey key, out TValue value)
        {
            key = kvp.Key;
            value = kvp.Value;
        }

        /// <summary>Returns a randomly selected Value from the given Dictionary.</summary>
        public static IEnumerable<TValue> GetRandomValue<TKey, TValue>(this IDictionary<TKey, TValue> dict)
        {
            yield return dict.ElementAt(Randomq.Range(0, dict.Count - 1)).Value;
        }

        /// <summary>
        /// Returns a randomly picked Value and swaps its Key.
        /// Use only if you want to move Values to random Keys.
        /// </summary>
        public static KeyValuePair<TKey, TValue> PickRandomAndSwap<TKey, TValue>(this IDictionary<TKey, TValue> dict, ref int size)
        {
            int index = Randomq.Range(0, size - 1);

            KeyValuePair<TKey, TValue> temp = GetPair(dict, dict.ElementAt(index).Key);

            dict[temp.Key] = dict.ElementAt(size - 1).Value;
            dict[dict.ElementAt(index).Key] = temp.Value;

            size--;

            return temp;
        }

        /// <summary>
        /// Shuffles the Dictionary Values randomly
        /// Use only if you want to shuffle Values to random Keys.
        /// </summary>
        public static void Shuffle<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
            for (int size = dict.Count; size > 1; PickRandomAndSwap(dict, ref size)) ;
        }
    }
}
