using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Quirks
{
    public static class Enumq
    {
        static readonly ThreadLocal<Random> threadLocalRandom = new ThreadLocal<Random>(() => new Random(GetSeed()));

        static Random Random = threadLocalRandom.Value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int GetSeed()
        {
            unchecked
            {
                int threadID = Thread.CurrentThread.ManagedThreadId;
                long timestamp = DateTime.UtcNow.Ticks;
                return (int)((threadID * 397) ^ timestamp);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool SameType(Enum a, Enum b) => a.GetType() == b.GetType();

        /// <summary>Compares two enum values by their underlying integer value</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Compare<T>(T a, T b) where T : struct, Enum => Comparer<long>.Default.Compare(Convert.ToInt64(a), Convert.ToInt64(b));

        /// <summary>Sorts enum values by their underlying integer value</summary>
        public static T[] Sort<T>(T[] values) where T : struct, Enum
        {
            Array.Sort(values, (a, b) => Compare(a, b));
            return values;
        }

        #region Parse

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Parse<T>(string value) where T : struct, Enum => Enum.TryParse<T>(value, out var result) ? result : throw new ArgumentException($"Invalid enum value: {value}");

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParse<T>(string value, out T result) where T : struct, Enum => Enum.TryParse(value, out result);

        #endregion

        #region Flags

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFlag<T>(T value, T flag) where T : struct, Enum
        {
            long longValue = Convert.ToInt64(value);
            long longFlag = Convert.ToInt64(flag);

            return (longValue & longFlag) == longFlag;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T SetFlag<T>(T value, T flag) where T : struct, Enum
        {
            long longValue = Convert.ToInt64(value);
            long longFlag = Convert.ToInt64(flag);

            long result = longValue | longFlag;
            return (T)Enum.ToObject(typeof(T), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ClearFlag<T>(T value, T flag) where T : struct, Enum
        {
            long longValue = Convert.ToInt64(value);
            long longFlag = Convert.ToInt64(flag);

            long result = longValue & ~longFlag;
            return (T)Enum.ToObject(typeof(T), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T ToggleFlag<T>(T value, T flag) where T : struct, Enum
        {
            long longValue = Convert.ToInt64(value);
            long longFlag = Convert.ToInt64(flag);

            long result = longValue ^ longFlag;
            return (T)Enum.ToObject(typeof(T), result);
        }

        /// <summary>Returns all individual flag values from a combined flags enum</summary>
        public static T[] GetFlags<T>(T flags) where T : struct, Enum
        {
            T[] allValues = GetAllValues<T>();
            List<T> result = new List<T>();

            foreach(T value in allValues)
            {
                if (HasFlag(flags, value) && Convert.ToInt64(value) != 0)
                    result.Add(value);
            }

            return result.ToArray();
        }

        /// <summary>Combines multiple enum values into a single flags value</summary>
        public static T CombineFlags<T>(params T[] flags) where T : struct, Enum
        {
            if (flags == null || flags.Length == 0)
                return default;

            long result = 0;
            foreach(T flag in flags)
            {
                result |= Convert.ToInt64(flag);
            }

            return (T)Enum.ToObject(typeof(T), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FlagCount<T>() => Enum.GetValues(typeof(T)).Length;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FlagSetCount<T>(T e) where T : struct, Enum
        {
            int count = 0;
            long value = Convert.ToInt64(e);

            while(value != 0)
            {
                value &= value - 1;
                count++;
            }

            return count;
        }

        #endregion

        #region Get / Querying

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GetName<T>(object value) where T : struct, Enum => Enum.GetName(typeof(T), value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string[] GetNames<T>() where T : struct, Enum => Enum.GetNames(typeof(T));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Type GetUnderlyingType<T>() where T : struct, Enum => Enum.GetUnderlyingType(typeof(T));

        /// <summary>Gets the next enum value in sequence (wraps around)</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetNext<T>(T current) where T : struct, Enum
        {
            T[] values = GetAllValues<T>();
            int index = Array.IndexOf(values, current);
            return values[(index + 1) % values.Length];
        }

        /// <summary>Gets the previous enum value in sequence (wraps around)</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetPrevious<T>(T current) where T : struct, Enum
        {
            T[] values = GetAllValues<T>();
            int index = Array.IndexOf(values, current);
            return values[(index - 1 + values.Length) % values.Length];
        }

        /// <summary>Gets all enum values as any array.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T[] GetAllValues<T>() => (T[])Enum.GetValues(typeof(T));

        /// <summary>Returns the highest numeric value for T.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetHighestValue<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            int max = 0;

            foreach(T value in values)
            {
                int intValue = Convert.ToInt32(value);
                if(intValue > max)
                    max = intValue;
            }

            return max;
        }

        /// <summary>Gets enum values in a specific range</summary>
        public static T[] GetRange<T>(T start, T end) where T : struct, Enum
        {
            T[] allValues = GetAllValues<T>();
            int startIndex = Array.IndexOf(allValues, start);
            int endIndex = Array.IndexOf(allValues, end);

            if (startIndex > endIndex)
                (startIndex, endIndex) = (endIndex, startIndex);

            T[] result = new T[endIndex - startIndex + 1];
            Array.Copy(allValues, startIndex, result, 0, result.Length);
            return result;
        }

        #region Random

        /// <summary>Gets a random enum value.</summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <returns>A randomly selected enum value.</returns>
        public static T GetRandomEnum<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(Random.Next(values.Length));
        }

        /// <summary>Gets a random enum value, excluding specified values.</summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="excludedValues">Array of enum values to exclude from random selection.</param>
        /// <returns>A randomly selected enum value.</returns>
        public static T GetRandomEnumExcluded<T>(params T[] excludedValues)
        {
            Array values = Enum.GetValues(typeof(T));
            Array filteredValues = values.Cast<T>().Where(value => !excludedValues.Contains(value)).ToArray();

            return (T)filteredValues.GetValue(Random.Next(filteredValues.Length));
        }

        /// <summary>Gets a random enum value, excluding specified values.</summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="excludedValues">IEnumerable of enum values to exclude from random selection.</param>
        /// <returns>A randomly selected enum value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T GetRandomEnumExcluded<T>(IEnumerable<T> excludedValues) => GetRandomEnumExcluded(excludedValues.ToArray());

        #endregion

        #endregion

        #region Validation

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(T value) where T : struct, Enum => Enum.IsDefined(typeof(T), value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined<T>(string value) where T : struct, Enum => Enum.TryParse<T>(value, out _) && Enum.IsDefined(typeof(T), value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFlagsEnum<T>() where T : struct, Enum => typeof(T).IsDefined(typeof(FlagsAttribute), false);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Validate<T>(T value) where T : struct, Enum
        {
            if (!IsDefined(value))
                throw new ArgumentException($"Value {value} is not defined in enum {typeof(T).Name}");
        }

        #endregion

            #region Conversion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt<T>(T value) where T : struct, Enum => Convert.ToInt32(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T FromInt<T>(int value) where T : struct, Enum => (T)Enum.ToObject(typeof(T), value);

        public static T SafeFromInt<T>(int value) where T : struct, Enum
        {
            if (Enum.IsDefined(typeof(T), value))
                return (T)Enum.ToObject(typeof(T), value);

            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToString<T>(T value, string format = "G") where T : struct, Enum => Enum.Format(typeof(T), value, format);

        #endregion

        /// <summary>Shuffles enum values</summary>
        public static T[] Shuffle<T>() where T : struct, Enum
        {
            T[] values = GetAllValues<T>();
            for (int i = values.Length - 1; i > 0; i--)
            {
                int j = Random.Next(0, i + 1);
                (values[i], values[j]) = (values[j], values[i]);
            }

            return values;
        }
    }
}
