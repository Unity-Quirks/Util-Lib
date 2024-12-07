using System;
using System.Collections.Generic;
using System.Linq;

namespace Quirks
{
    public static class Enumq
    {
        static Random randomGen = new Random();

        public static bool SameType(Enum a, Enum b) => a.GetType() == b.GetType();

        public static T Parse<T>(string value) => (T)Enum.Parse(typeof(T), value);

        public static int FlagCount<T>() => Enum.GetValues(typeof(T)).Length;

        public static int FlagSetCount<T>(T e)
        {
            if (!typeof(T).IsEnum) return -1;

            int setBits = 0;
            long target = (long)(object)e;

            for (int i = 0; i < 32; i++)
            {
                if (((target >> i) & 1) == 1)
                    setBits++;
            }

            return setBits;
        }

        /// <summary>Gets all enum values as any array.</summary>
        public static T[] GetAllValues<T>() => (T[])Enum.GetValues(typeof(T));

        /// <summary>Gets a random enum value.</summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <returns>A randomly selected enum value.</returns>
        public static T GetRandomEnum<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(randomGen.Next(values.Length));
        }

        /// <summary>Gets a random enum value, excluding specified values.</summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="excludedValues">Array of enum values to exclude from random selection.</param>
        /// <returns>A randomly selected enum value.</returns>
        public static T GetRandomEnumExcluded<T>(params T[] excludedValues)
        {
            Array values = Enum.GetValues(typeof(T));
            Array filteredValues = values.Cast<T>().Where(value => !excludedValues.Contains(value)).ToArray();

            return (T)filteredValues.GetValue(randomGen.Next(filteredValues.Length));
        }

        /// <summary>Gets a random enum value, excluding specified values.</summary>
        /// <typeparam name="T">The enum type</typeparam>
        /// <param name="excludedValues">IEnumerable of enum values to exclude from random selection.</param>
        /// <returns>A randomly selected enum value.</returns>
        public static T GetRandomEnumExcluded<T>(IEnumerable<T> excludedValues) => GetRandomEnumExcluded(excludedValues.ToArray());

        /// <summary>Returns the highest numeric value for T.</summary>
        public static int GetHighestValue<T>()
        {
            Type enumType = typeof(T);

            int highestValue = 0;
            Array pidValues = Enum.GetValues(enumType);
            foreach (T pid in pidValues)
            {
                object obj = Enum.Parse(enumType, pid.ToString());
                int value = Convert.ToInt32(obj);
                highestValue = Math.Max(highestValue, value);
            }

            return highestValue;
        }
    }
}
