using System;

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

        public static T GetRandomEnum<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(randomGen.Next(values.Length));
        }

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
