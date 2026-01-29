using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Quirks
{
    public static partial class Randomq
    {
        static readonly ThreadLocal<Random> threadLocalRandom = new ThreadLocal<Random>(() => new Random(GetSeed()));

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

        static Random Random => threadLocalRandom.Value;

        /// <summary>Returns true if a coin flips heads (50% Chance)</summary>
        public static bool CoinFlip => Float < 0.5f;

        /// <summary>Returns a non-negative random integer.</summary>
        public static int Int => Random.Next();

        /// <summary>Returns a random floating-point value from 0f (inclusive) to 1f (exclusive).</summary>
        public static float Float => (float)Random.NextDouble();

        /// <summary>Returns a random floating-point value from 0.0 (inclusive) to 1.0 (exclusive).</summary>
        public static double Double => Random.NextDouble();

        #region Seed

        public static void SetSeed(int seed) => threadLocalRandom.Value = new Random(seed);

        public static void ResetSeed() => threadLocalRandom.Value = new Random(GetSeed());

        #endregion

        #region Range

        #region Integer

        /// <summary>Returns a Random int between 0 and max</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Range(int max) => Random.Next(max);

        /// <summary>Returns a Random int between the min and max(inclusive)</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Range(int min = 0, int max = 100) => Random.Next(min, max + 1);

        /// <summary>Returns True if the number is less than the threshold</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool RangeThreshold(int min = 0, int max = 100, int threshold = 50) => Range(min, max) < threshold ? true : false;

        #endregion

        #region Float

        /// <summary>Returns a Random float between 0 and max</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Range(float max) => Float * max;

        /// <summary>Returns a Random float between the min and max</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Range(float min = 0f, float max = 1f) => (float)(Random.NextDouble() * (max - min) + min);

        /// <summary>Returns True if the number is less than the threshold</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool RangeThreshold(float min = 0f, float max = 1f, float threshold = 0.5f) => Range(min, max) < threshold ? true : false;

        #endregion

        #region Double

        /// <summary>Returns a Random double between 0.0 and max</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Range(double max) => Double * max;

        /// <summary>Returns a Random double between the min and max</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Range(double min = 0.0, double max = 1.0) => Random.NextDouble() * (max - min) + min;

        /// <summary>Returns True if the number is less than the threshold</summary>
        /// <param name="min">Smallest number</param>
        /// <param name="max">Largest number</param>
        /// <param name="threshold">Number Threshold</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool RangeThreshold(double min = 0.0, double max = 1.0, double threshold = 0.5) => Range(min, max) < threshold ? true : false;

        #endregion

        #endregion

        #region Probability

        /// <summary>Returs true with given probability (0.0 to 1.0)</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Chance(float probability) => probability <= 0f ? false : probability >= 1f ? true : Float < probability;

        /// <summary>Returns true approximately once every n times.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool OneIn(int n) => n > 0 && Range(0, n - 1) == 0;

        #endregion

        #region Selection

        public static T Choice<T>(params T[] items)
        {
            if (items == null || items.Length == 0)
                throw new ArgumentException("Items cannot be empty", nameof(items));

            return items[Range(0, items.Length - 1)];
        }

        public static T Choice<T>(IList<T> items)
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("Items cannot be empty", nameof(items));

            return items[Range(0, items.Count - 1)];
        }

        public static T Choice<T>(ICollection<T> items)
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("Items cannot be empty", nameof(items));

            return items.ElementAt(Range(0, items.Count - 1));
        }

        #endregion

        #region Shuffling

        public static void Shuffle<T>(T[] array)
        {
            for(int i = array.Length - 1; i > 0; i--)
            {
                int j = Range(0, i);
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        public static void Shuffle<T>(IList<T> array)
        {
            for (int i = array.Count - 1; i > 0; i--)
            {
                int j = Range(0, i);
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        #endregion
    }
}
