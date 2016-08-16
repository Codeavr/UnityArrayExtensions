using System;
using System.Collections;
using System.Collections.Generic;

namespace Codeavr
{
    internal static partial class ArrayExtensions
    {
        public static bool InRange<T>(this T[] array, int index)
        {
            return array != null && index >= 0 && index < array.Length;
        }
        public static bool InRange(this ICollection array, int index)
        {
            return array != null && index >= 0 && index < array.Count;
        }
        public static T PickRandom<T>(this T[] array)
        {
            if (array != null && array.Length > 0)
            {
                int randomIndex = UnityEngine.Random.Range(0, array.Length);
                return array[randomIndex];
            }
            return default(T);
        }
        public static T PickRandom<T>(this List<T> list)
        {
            if (list != null && list.Count > 0)
            {
                int randomIndex = UnityEngine.Random.Range(0, list.Count);
                return list[randomIndex];
            }
            return default(T);
        }
        public static void RemoveNulls<T>(this List<T> array)
        {
            for (int i = 0; i < array.Count; i++)
                if (array[i] == null) array.RemoveAt(i--);
        }
        public static bool Empty<T>(this T[] obj)
        {
            return obj == null || obj.Length == 0;
        }
        public static TValue Get<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key)
        {
            TValue result;
            dict.TryGetValue(key, out result);
            return result;
        }
    };
};