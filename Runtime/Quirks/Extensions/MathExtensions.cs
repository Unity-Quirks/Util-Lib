using System.Runtime.CompilerServices;

namespace Quirks
{
    public static class MathExtensions
    {
        #region ToInt

        // Bool
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt(this bool value) => value ? 1 : 0;

        // Float
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt(this float value) => (int)value;

        // Double
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt(this double value) => (int)value;

        #endregion

        #region ToLong

        // Bool
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToLong(this bool value) => value ? 1 : 0;

        // Float
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToLong(this float value) => (long)value;

        // Double
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToLong(this double value) => (long)value;

        #endregion

        #region ToFloat

        // Bool
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToFloat(this bool value) => value ? 1f : 0f;

        #endregion

        #region ToDouble

        // Bool
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble(this bool value) => value ? 1.0 : 0.0;

        #endregion

        #region ToDeg

        // Float
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToDeg(this float value) => value * Mathq.Rad2Deg;

        // Double
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDeg(this double value) => value * Mathq.Rad2Deg;

        #endregion

        #region ToRad

        // Float
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ToRad(this float value) => value * Mathq.Deg2Rad;

        // Double
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToRad(this double value) => value * Mathq.Deg2Rad;

        #endregion

        #region Clamp

        // Int
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(this int value, int min, int max) => Mathq.Clamp(value, min, max);

        // Float
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(this float value, float min, float max) => Mathq.Clamp(value, min, max);

        // Double
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(this double value, double min, double max) => Mathq.Clamp(value, min, max);

        #endregion

        #region Clamp01

        // Float
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp01(this float value) => Mathq.Clamp01(value);

        // Double
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp01(this double value) => Mathq.Clamp01(value);

        #endregion

        #region Squared

        // Int
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Squared(this int value) => value * value;

        // Long
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Squared(this long value) => value * value;

        // Float
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Squared(this float value) => value * value;

        // Double
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Squared(this double value) => value * value;

        #endregion

        #region Cubed

        // Int
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cubed(this int value) => value * value * value;

        // Long
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Cubed(this long value) => value * value * value;

        // Float
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cubed(this float value) => value * value * value;

        // Double
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cubed(this double value) => value * value * value;

        #endregion

        #region ToHexDec

        // Int
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToHexDec(this int value) => value.ToString("X");

        #endregion
    }
}
