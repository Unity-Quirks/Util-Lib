using System;
using System.Runtime.CompilerServices;

namespace Quirks
{
    public static class Mathq
    {
        /// <summary>This is a double precision constant of Pi. Approximately 3.14.</summary>
        public const double doublePi = 3.14159265358979323846;

        /// <summary>This is a double precision constant of 2Pi. Approximately 6.28.</summary>
        public const double doubleTau = 6.28318530717958647692;

        /// <summary>This is a double precision constant of e also known as Euler's number. Approximately 2.72.</summary>
        public const double doubleE = 2.71828182845904523536;

        /// <summary>This is a double precision constant of the Golden Ratio. Approximately 1.62.</summary>
        public const double doubleGoldenRatio = 1.6180339887498948482;

        /// <summary>This is a double precision of the base 2 logarithm of e. Approximately 1.44.</summary>
        public const double doubleLog2E = 1.44269504088896340736;

        /// <summary>This is a double precision of the base 10 logarithm of e. Approximately 0.43.</summary>
        public const double doubleLog10E = 0.434294481903251827651;

        /// <summary>This is a double precision of the base 2 logarithm of e. Approximately 0.69.</summary>
        public const double doubleLogN2 = 0.693147180559945309417;

        /// <summary>This is a double precision of the base 10 logarithm of e. Approximately 2.30.</summary>
        public const double doubleLogN10 = 2.30258509299404568402;

        /// <summary>This is a double precision of the square root of 2. Approximately 1.41.</summary>
        public const double doubleSqrt2 = 1.41421356237309504880;

        /// <summary>This is the double precision of the difference between 1.0 and the next representable value.</summary>
        public const double doubleEpsilon = 2.22044604925031308085e-16;

        /// <summary>The double precision constant for positive infinity.</summary>
        public const double doubleInfinity = Double.PositiveInfinity;

        /// <summary>The double precision constant for Not a Number.</summary>
        public const double doubleNaN = Double.NaN;

        /// <summary>The double precision constant of the smallest positive normal number in a double.</summary>
        public const double doubleMinNormal = 2.22507385850720138309e-308;

        /// <summary>Degrees-to-radians conversion constant.</summary>
        public const double doubleDeg2Rad = doublePi / 180.0;

        /// <summary>Radians-to-degrees conversion constant.</summary>
        public const double doubleRad2Deg = 180.0 / doublePi;


        /// <summary>The mathematical constant of Pi. Approximately 3.14.</summary>
        public const float Pi = (float)doublePi;

        /// <summary>The mathematical constant of 2Pi. Approximately 6.28.</summary>
        public const float Tau = (float)doubleTau;

        /// <summary>The mathematical constant of e also known as Euler's number. Approximately 2.72.</summary>
        public const float E = (float)doubleE;

        /// <summary>The mathematical constant of the Golden Ratio. Approximately 1.62.</summary>
        public const float GoldenRatio = (float)doubleGoldenRatio;

        /// <summary>The base 2 logarithm of e. Approximately 1.44.</summary>
        public const float Log2E = (float)doubleLog2E;

        /// <summary>The base 10 logarithm of e. Approximately 0.43.</summary>
        public const float Log10E = (float)doubleLog10E;

        /// <summary>The natural logarithm of 2. Approximately 0.69.</summary>
        public const float LogN2 = (float)doubleLogN2;

        /// <summary>The natural logarithm of 10. Approximately 2.30.</summary>
        public const float LogN10 = (float)doubleLogN10;

        /// <summary>The square root of 2. Approximately 1.41.</summary>
        public const float Sqrt2 = (float)doubleSqrt2;

        /// <summary>This is the single precision of the difference between 1.0 and the next representable value.</summary>
        public const float Epsilon = 1.1920928955078125e-7f;

        /// <summary>The single precision constant for positive infinity.</summary>
        public const float Infinity = float.PositiveInfinity;

        /// <summary>The single precision constant for negative infinity.</summary>
        public const float NegativeInfinity = float.NegativeInfinity;

        /// <summary>The single precision constant for Not a Number.</summary>
        public const float NaN = float.NaN;

        /// <summary>The single precision constant of the smallest positive normal number in a float.</summary>
        public const float floatMinNormal = 1.175494350822287508e-38f;

        /// <summary>Degrees-to-radians conversion constant.</summary>
        public const float Deg2Rad = Pi / 180f;

        /// <summary>Radians-to-degrees conversion constant.</summary>
        public const float Rad2Deg = 180f / Pi;

        #region AsInt

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an uint as an int.</summary>
        public static int AsInt(uint x) => (int)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a long as an int.</summary>
        public static int AsInt(long x) => (int)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an ulong as an int.</summary>
        public static int AsInt(ulong x) => (int)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a float as an int.</summary>
        public static int AsInt(float x) => (int)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a double as an int.</summary>
        public static int AsInt(double x) => (int)x;

        #endregion

        #region AsUInt

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an int as an uint.</summary>
        public static uint AsUInt(int x) => (uint)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a long as an uint.</summary>
        public static uint AsUInt(long x) => (uint)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an ulong as an uint.</summary>
        public static uint AsUInt(ulong x) => (uint)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a float as an uint.</summary>
        public static uint AsUInt(float x) => (uint)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a double as an uint.</summary>
        public static uint AsUInt(double x) => (uint)x;

        #endregion

        #region AsLong

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an int as a long.</summary>
        public static long AsLong(int x) => (long)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an uint as a long.</summary>
        public static long AsLong(uint x) => (long)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an ulong as a long.</summary>
        public static long AsLong(ulong x) => (long)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a float as a long.</summary>
        public static long AsLong(float x) => (long)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a double as a long.</summary>
        public static long AsLong(double x) => (long)x;

        #endregion

        #region AsULong

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an int as an ulong.</summary>
        public static ulong AsULong(int x) => (ulong)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an uint as an ulong.</summary>
        public static ulong AsULong(uint x) => (ulong)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a long as an ulong.</summary>
        public static ulong AsULong(long x) => (ulong)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a float as an ulong.</summary>
        public static ulong AsULong(float x) => (ulong)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a double as an ulong.</summary>
        public static ulong AsULong(double x) => (ulong)x;

        #endregion

        #region AsFloat

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an int as a float.</summary>
        public static float AsFloat(int x) => (float)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an uint as a float.</summary>
        public static float AsFloat(uint x) => (float)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a long as a float.</summary>
        public static float AsFloat(long x) => (float)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an ulong as a float.</summary>
        public static float AsFloat(ulong x) => (float)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a double as a float.</summary>
        public static float AsFloat(double x) => (float)x;

        #endregion

        #region AsDouble

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an int as a double.</summary>
        public static double AsDouble(int x) => (double)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an uint as a double.</summary>
        public static double AsDouble(uint x) => (double)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a long as a double.</summary>
        public static double AsDouble(long x) => (double)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns an ulong as a double.</summary>
        public static double AsDouble(ulong x) => (double)x;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns a float as a double.</summary>
        public static double AsDouble(float x) => (double)x;

        #endregion

        #region Pow

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Pow(float x, float y) => MathF.Pow(x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Pow(double x, double y) => Math.Pow(x, y);

        #endregion

        #region Sqrt

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the square root of x.</summary>
        public static float Sqrt(float x) => MathF.Sqrt(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the square root of x.</summary>
        public static double Sqrt(double x) => Math.Sqrt(x);

        #endregion

        #region Cbrt

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cbrt(float x) => MathF.Cbrt(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cbrt(double x) => Math.Cbrt(x);

        #endregion

        #region Abs

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the absolute value of x.</summary>
        public static double Abs(double x) => Math.Abs(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the absolute value of x.</summary>
        public static float Abs(float x) => MathF.Abs(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the absolute value of x.</summary>
        public static int Abs(int x) => Math.Abs(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the absolute value of x.</summary>
        public static long Abs(long x) => Math.Abs(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the absolute value of x.</summary>
        public static short Abs(short x) => Math.Abs(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the absolute value of x.</summary>
        public static sbyte Abs(sbyte x) => Math.Abs(x);

        #endregion

        #region Exp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Exp(float x) => MathF.Exp(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Exp(double x) => Math.Exp(x);

        #endregion

        #region Sign

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(sbyte x) => Math.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(short x) => Math.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(int x) => Math.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(uint x) => Math.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(long x) => Math.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(decimal x) => Math.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(float x) => MathF.Sign(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sign(double x) => Math.Sign(x);

        #endregion

        #region Gamma

        // Questionable Please Test
        public static float Gamma(float value, float absMax, float gamma)
        {
            bool isNegative = value < 0f;
            float absoluteValue = Abs(value);

            if(absoluteValue > absMax)
            {
                return isNegative ? -absoluteValue : absoluteValue;
            }

            float result = Pow(absoluteValue / absMax, gamma) * absMax;
            return isNegative ? -result : result;
        }
        public static double Gamma(double value, double absMax, double gamma)
        {
            bool isNegative = value < 0f;
            double absoluteValue = Abs(value);

            if (absoluteValue > absMax)
            {
                return isNegative ? -absoluteValue : absoluteValue;
            }

            double result = Pow(absoluteValue / absMax, gamma) * absMax;
            return isNegative ? -result : result;
        }

        #endregion

        #region Factorial

        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Input should be a non-negative integer.");

            if (n > 20)
                throw new ArgumentException("Input is too large for 32-bit representation.");

            if (n == 0 || n == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= n ; i++)
            {
                result *= i;
            }

            return result;
        }

        public static float Factorial(float n)
        {
            if (n < 0)
                throw new ArgumentException("Input should be a non-negative number.");

            return Gamma(n + 1, 20, 2);
        }

        public static double Factorial(double n)
        {
            if (n < 0)
                throw new ArgumentException("Input should be a non-negative number.");

            return Gamma(n + 1, 170, 2);
        }

        #endregion

        #region Sum

        /// <summary>Returns the sum of two or more values.</summary>
        public static int Sum(params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }
        /// <summary>Returns the sum of two or more values.</summary>
        public static uint Sum(params uint[] values)
        {
            uint sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }
        /// <summary>Returns the sum of two or more values.</summary>
        public static long Sum(params long[] values)
        {
            long sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }
        /// <summary>Returns the sum of two or more values.</summary>
        public static ulong Sum(params ulong[] values)
        {
            ulong sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }
        /// <summary>Returns the sum of two or more values.</summary>
        public static float Sum(params float[] values)
        {
            float sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }
        /// <summary>Returns the sum of two or more values.</summary>
        public static double Sum(params double[] values)
        {
            double sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum;
        }

        #endregion

        #region Average

        /// <summary>Returns the average of two or more values.</summary>
        public static int Average(params int[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            return Sum(values) / values.Length;
        }
        /// <summary>Returns the average of two or more values.</summary>
        public static uint Average(params uint[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            return Sum(values) / AsUInt(values.Length);
        }
        /// <summary>Returns the average of two or more values.</summary>
        public static long Average(params long[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            return Sum(values) / values.Length;
        }
        /// <summary>Returns the average of two or more values.</summary>
        public static ulong Average(params ulong[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            return Sum(values) / AsULong(values.Length);
        }
        /// <summary>Returns the average of two or more values.</summary>
        public static float Average(params float[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            return Sum(values) / values.Length;
        }
        /// <summary>Returns the average of two or more values.</summary>
        public static double Average(params double[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            return Sum(values) / values.Length;
        }

        #endregion

        #region Min

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the minimum of two int values.</summary>
        public static int Min (int x, int y) => x < y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the minimum of two uint values.</summary>
        public static uint Min(uint x, uint y) => x < y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the minimum of two long values.</summary>
        public static long Min(long x, long y) => x < y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the minimum of two ulongvalues.</summary>
        public static ulong Min(ulong x, ulong y) => x < y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the minimum of two float values.</summary>
        public static float Min(float x, float y) => x < y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the minimum of two double values.</summary>
        public static double Min(double x, double y) => x < y ? x : y;

        /// <summary>Returns the minimum of two or more int values.</summary>
        public static int Min(params int[] values)
        {
            if (values.Length == 0)
                return 0;

            int min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }

            return min;
        }

        /// <summary>Returns the minimum of two or more uint values.</summary>
        public static uint Min(params uint[] values)
        {
            if (values.Length == 0)
                return 0;

            uint min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }

            return min;
        }

        /// <summary>Returns the minimum of two or more long values.</summary>
        public static long Min(params long[] values)
        {
            if (values.Length == 0)
                return 0;

            long min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }

            return min;
        }

        /// <summary>Returns the minimum of two or more ulong values.</summary>
        public static ulong Min(params ulong[] values)
        {
            if (values.Length == 0)
                return 0;

            ulong min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }

            return min;
        }

        /// <summary>Returns the minimum of two or more float values.</summary>
        public static float Min(params float[] values)
        {
            if (values.Length == 0)
                return 0;

            float min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }

            return min;
        }

        /// <summary>Returns the minimum of two or more double values.</summary>
        public static double Min(params double[] values)
        {
            if (values.Length == 0)
                return 0;

            double min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }

            return min;
        }

        #endregion

        #region Max

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the maximum of two int values.</summary>
        public static int Max(int x, int y) => x > y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the maximum of two uint values.</summary>
        public static uint Max(uint x, uint y) => x > y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the maximum of two long values.</summary>
        public static long Max(long x, long y) => x > y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the maximum of two ulongvalues.</summary>
        public static ulong Max(ulong x, ulong y) => x > y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the maximum of two float values.</summary>
        public static float Max(float x, float y) => x > y ? x : y;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the maximum of two double values.</summary>
        public static double Max(double x, double y) => x > y ? x : y;

        /// <summary>Returns the maximum of two or more int values.</summary>
        public static int Max(params int[] values)
        {
            if (values.Length == 0)
                return 0;

            int max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
            }

            return max;
        }
        /// <summary>Returns the maximum of two or more uint values.</summary>
        public static uint Max(params uint[] values)
        {
            if (values.Length == 0)
                return 0;

            uint max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
            }

            return max;
        }
        /// <summary>Returns the maximum of two or more long values.</summary>
        public static long Max(params long[] values)
        {
            if (values.Length == 0)
                return 0;

            long max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
            }

            return max;
        }
        /// <summary>Returns the maximum of two or more ulong values.</summary>
        public static ulong Max(params ulong[] values)
        {
            if (values.Length == 0)
                return 0;

            ulong max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
            }

            return max;
        }
        /// <summary>Returns the maximum of two or more float values.</summary>
        public static float Max(params float[] values)
        {
            if (values.Length == 0)
                return 0;

            float max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
            }

            return max;
        }
        /// <summary>Returns the maximum of two or more double values.</summary>
        public static double Max(params double[] values)
        {
            if (values.Length == 0)
                return 0;

            double max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
            }

            return max;
        }

        #endregion

        #region Range

        /// <summary>Returns the range of two or more int values.</summary>
        public static int Range(params int[] values) => Max(values) - Min(values);

        /// <summary>Returns the range of two or more uint values.</summary>
        public static uint Range(params uint[] values) => Max(values) - Min(values);

        /// <summary>Returns the range of two or more long values.</summary>
        public static long Range(params long[] values) => Max(values) - Min(values);

        /// <summary>Returns the range of two or more ulong values.</summary>
        public static ulong Range(params ulong[] values) => Max(values) - Min(values);

        /// <summary>Returns the range of two or more float values.</summary>
        public static float Range(params float[] values) => Max(values) - Min(values);

        /// <summary>Returns the range of two or more double values.</summary>
        public static double Range(params double[] values) => Max(values) - Min(values);

        #endregion

        #region Mean

        public static int Mean(params int[] values) => Sum(values) / values.Length;
        public static uint Mean(params uint[] values) => AsUInt(Sum(values) / values.Length);
        public static long Mean(params long[] values) => Sum(values) / values.Length;
        public static ulong Mean(params ulong[] values) => Sum(values) / (ulong)values.Length;
        public static float Mean(params float[] values) => Sum(values) / values.Length;
        public static double Mean(params double[] values) => Sum(values) / values.Length;

        #endregion

        #region Median

        /// <summary>Calculates the median of an array of int.</summary>
        public static int Median(params int[] values)
        {
            if (values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            int[] temp = new int[values.Length];
            Array.Copy(values, temp, values.Length);

            Array.Sort(temp);

            int count = temp.Length;
            if (count % 2 == 0)
            {
                int a = temp[count / 2 - 1];
                int b = temp[count / 2];
                return (a + b) / 2;
            }
            else
            {
                return temp[count / 2];
            }
        }
        /// <summary>Calculates the median of an array of uint.</summary>
        public static uint Median(params uint[] values)
        {
            if (values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            uint[] temp = new uint[values.Length];
            Array.Copy(values, temp, values.Length);

            Array.Sort(temp);

            int count = temp.Length;
            if (count % 2 == 0)
            {
                uint a = temp[count / 2 - 1];
                uint b = temp[count / 2];
                return (a + b) / 2;
            }
            else
            {
                return temp[count / 2];
            }
        }
        /// <summary>Calculates the median of an array of long.</summary>
        public static long Median(params long[] values)
        {
            if (values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            long[] temp = new long[values.Length];
            Array.Copy(values, temp, values.Length);

            Array.Sort(temp);

            int count = temp.Length;
            if (count % 2 == 0)
            {
                long a = temp[count / 2 - 1];
                long b = temp[count / 2];
                return (a + b) / 2;
            }
            else
            {
                return temp[count / 2];
            }
        }
        /// <summary>Calculates the median of an array of ulong.</summary>
        public static ulong Median(params ulong[] values)
        {
            if (values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            ulong[] temp = new ulong[values.Length];
            Array.Copy(values, temp, values.Length);

            Array.Sort(temp);

            int count = temp.Length;
            if (count % 2 == 0)
            {
                ulong a = temp[count / 2 - 1];
                ulong b = temp[count / 2];
                return (a + b) / 2;
            }
            else
            {
                return temp[count / 2];
            }
        }
        /// <summary>Calculates the median of an array of float.</summary>
        public static float Median(params float[] values)
        {
            if (values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            float[] temp = new float[values.Length];
            Array.Copy(values, temp, values.Length);

            Array.Sort(temp);

            int count = temp.Length;
            if (count % 2 == 0)
            {
                float a = temp[count / 2 - 1];
                float b = temp[count / 2];
                return (a + b) / 2f;
            }
            else
            {
                return temp[count / 2];
            }
        }
        /// <summary>Calculates the median of an array of double.</summary>
        public static double Median(params double[] values)
        {
            if (values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            double[] temp = new double[values.Length];
            Array.Copy(values, temp, values.Length);

            Array.Sort(temp);

            int count = temp.Length;
            if (count % 2 == 0)
            {
                double a = temp[count / 2 - 1];
                double b = temp[count / 2];
                return (a + b) / 2.0;
            }
            else
            {
                return temp[count / 2];
            }
        }

        #endregion

        #region Mode

        /// <summary>Calculates the mode of an array of int.</summary>
        public static int Mode(params int[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            Array.Sort(values);

            int mode = values[0];
            int maxCount = 1;
            int currentCount = 1;
            int currentValue = values[0];

            for(int i = 1; i < values.Length; i++)
            {
                if(values[i] == currentValue)
                {
                    currentCount++;
                    if(currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mode = currentValue;
                    }
                }
                else
                {
                    currentValue = values[i];
                    currentCount = 1;
                }
            }

            return mode;
        }

        /// <summary>Calculates the mode of an array of uint.</summary>
        public static uint Mode(params uint[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            Array.Sort(values);

            uint mode = values[0];
            int maxCount = 1;
            int currentCount = 1;
            uint currentValue = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == currentValue)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mode = currentValue;
                    }
                }
                else
                {
                    currentValue = values[i];
                    currentCount = 1;
                }
            }

            return mode;
        }

        /// <summary>Calculates the mode of an array of long.</summary>
        public static long Mode(params long[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            Array.Sort(values);

            long mode = values[0];
            int maxCount = 1;
            int currentCount = 1;
            long currentValue = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == currentValue)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mode = currentValue;
                    }
                }
                else
                {
                    currentValue = values[i];
                    currentCount = 1;
                }
            }

            return mode;
        }

        /// <summary>Calculates the mode of an array of ulong.</summary>
        public static ulong Mode(params ulong[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            Array.Sort(values);

            ulong mode = values[0];
            int maxCount = 1;
            int currentCount = 1;
            ulong currentValue = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == currentValue)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mode = currentValue;
                    }
                }
                else
                {
                    currentValue = values[i];
                    currentCount = 1;
                }
            }

            return mode;
        }

        /// <summary>Calculates the mode of an array of float.</summary>
        public static float Mode(params float[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            Array.Sort(values);

            float mode = values[0];
            int maxCount = 1;
            int currentCount = 1;
            float currentValue = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == currentValue)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mode = currentValue;
                    }
                }
                else
                {
                    currentValue = values[i];
                    currentCount = 1;
                }
            }

            return mode;
        }

        /// <summary>Calculates the mode of an array of double.</summary>
        public static double Mode(params double[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            Array.Sort(values);

            double mode = values[0];
            int maxCount = 1;
            int currentCount = 1;
            double currentValue = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == currentValue)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mode = currentValue;
                    }
                }
                else
                {
                    currentValue = values[i];
                    currentCount = 1;
                }
            }

            return mode;
        }

        #endregion

        #region StandardDeviation

        public static int StandardDeviation(params int[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            int sum = Sum(values);
            float mean = (float)sum / values.Length;
            float temp = 0;

            for (int i = 0; i < values.Length; i++)
            {
                temp += (values[i] - mean) * (values[i] - mean);
            }

            return AsInt(Sqrt(temp / (values.Length - 1)));
        }
        public static uint StandardDeviation(params uint[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            uint sum = Sum(values);
            float mean = (float)sum / values.Length;
            float temp = 0;

            for (int i = 0; i < values.Length; i++)
            {
                temp += (values[i] - mean) * (values[i] - mean);
            }

            return AsUInt(Sqrt(temp / (values.Length - 1)));
        }
        public static long StandardDeviation(params long[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            long sum = Sum(values);
            float mean = (float)sum / values.Length;
            float temp = 0;

            for (int i = 0; i < values.Length; i++)
            {
                temp += (values[i] - mean) * (values[i] - mean);
            }

            return AsLong(Sqrt(temp / (values.Length - 1)));
        }
        public static ulong StandardDeviation(params ulong[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            ulong sum = Sum(values);
            float mean = (float)sum / values.Length;
            float temp = 0;

            for (int i = 0; i < values.Length; i++)
            {
                temp += (values[i] - mean) * (values[i] - mean);
            }

            return AsULong(Sqrt(temp / (values.Length - 1)));
        }
        public static float StandardDeviation(params float[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            float sum = Sum(values);
            float mean = sum / values.Length;
            float temp = 0;

            for (int i = 0; i < values.Length; i++)
            {
                temp += (values[i] - mean) * (values[i] - mean);
            }

            return Sqrt(temp / (values.Length - 1));
        }
        public static double StandardDeviation(params double[] values)
        {
            if (values == null || values.Length == 0)
                throw new InvalidOperationException("Empty Collection");

            double sum = Sum(values);
            double mean = sum / values.Length;
            double temp = 0;

            for (int i = 0; i < values.Length; i++)
            {
                temp += (values[i] - mean) * (values[i] - mean);
            }

            return Sqrt(temp / (values.Length - 1));
        }

        #endregion

        #region Variance

        public static int Variance(params int[] values) => StandardDeviation(values) * StandardDeviation(values);
        public static uint Variance(params uint[] values) => StandardDeviation(values) * StandardDeviation(values);
        public static long Variance(params long[] values) => StandardDeviation(values) * StandardDeviation(values);
        public static ulong Variance(params ulong[] values) => StandardDeviation(values) * StandardDeviation(values);
        public static float Variance(params float[] values) => StandardDeviation(values) * StandardDeviation(values);
        public static double Variance(params double[] values) => StandardDeviation(values) * StandardDeviation(values);

        #endregion

        #region Percent

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the percentage of a value in a total.</summary>
        public static int Percent(int value, int total) => (value * 100) / total;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the percentage of a value in a total.</summary>
        public static uint Percent(uint value, uint total) => (value * 100) / total;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the percentage of a value in a total.</summary>
        public static long Percent(long value, long total) => (value * 100) / total;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the percentage of a value in a total.</summary>
        public static ulong Percent(ulong value, ulong total) => (value * 100) / total;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the percentage of a value in a total.</summary>
        public static float Percent(float value, float total) => (value * 100) / total;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the percentage of a value in a total.</summary>
        public static double Percent(double value, double total) => (value * 100) / total;

        #endregion

        #region Clamp

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint value, uint min, uint max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long value, long min, long max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong value, ulong min, ulong max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double min, double max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Clamp<T>(T value, T min, T max) where T : System.IComparable<T>
        {
            return value.CompareTo(max) > 0 ?
                max : value.CompareTo(min) < 0 ?
                min : value;
        }

        #endregion

        #region Clamp01

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp01(float value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp01(double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;

            return value;
        }

        #endregion

        #region Log

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log(float x) => MathF.Log(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log(double x) => Math.Log(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log(float x, float newBase) => MathF.Log(x, newBase);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log(double x, double newBase) => Math.Log(x, newBase);

        #endregion

        #region Log2

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log2(float x) => MathF.Log(x) / Log2E;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log2(double x) => Math.Log(x) / doubleLog2E;

        #endregion

        #region Log10

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Log10(float x) => MathF.Log10(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Log10(double x) => Math.Log10(x);

        #endregion

        #region Floor

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(float value) => MathF.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Floor(double value) => Math.Floor(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FloorToInt(float value) => AsInt(MathF.Floor(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int FloorToInt(double value) => AsInt(Math.Floor(value));

        #endregion

        #region Ceil

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceil(float value) => MathF.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Ceil(double value) => Math.Ceiling(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CeilToInt(float value) => AsInt(MathF.Ceiling(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CeilToInt(double value) => AsInt(Math.Ceiling(value));

        #endregion

        #region Round

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(float value, int digits = 0) => MathF.Round(value, digits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Round(double value, int digits = 0) => Math.Round(value, digits);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RoundToInt(float value) => AsInt(MathF.Round(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RoundToInt(double value) => AsInt(Math.Round(value));

        #endregion

        #region Angle

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Angle(float x1, float y1, float x2, float y2) => Trigq.Atan2(y2 - y1, x2 - x1) + Rad2Deg;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Angle(double x1, double y1, double x2, double y2) => Trigq.Atan2(y2 - y1, x2 - x1) + doubleRad2Deg;

        #endregion

        #region AngleAverage

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float AngleAverage(float a, float b) => Interpq.Lerp(a, b, 0.5f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double AngleAverage(double a, double b) => Interpq.Lerp(a, b, 0.5);

        #endregion

        #region Truncate

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal Truncate(decimal x) => Math.Truncate(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(float x) => MathF.Truncate(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Truncate(double x) => Math.Truncate(x);

        #endregion

        #region DivRem

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //<summary>DivRem function for integers.</summary>
        public static void DivRem(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //<summary>DivRem function for floats.</summary>
        public static void DivRem(float dividend, float divisor, out float quotient, out float remainder)
        {
            quotient = AsFloat(Floor(AsDouble(dividend) / AsDouble(divisor)));
            remainder = dividend % divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //<summary>DivRem function for doubles.</summary>
        public static void DivRem(double dividend, double divisor, out double quotient, out double remainder)
        {
            quotient = Floor(dividend / divisor);
            remainder = dividend % divisor;
        }

        #endregion

        #region HexDec

        /// <summary>Converts a hexadecimal string to a decimal number.</summary>
        public static int HexDec(string hexString) => int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);

        #endregion

        #region Cubic Midpoint Ease In Out

        // Credits to @FreyaHolmer on twitter for sharing this amazing piece of art.
        // https://twitter.com/FreyaHolmer/status/1727809161784652029

        public static float CubicMidpointEaseInOut(float x, float w)
        {
            float slope = 3 * (w < 0.5f ? w : 1 - w); // Slope at x = 0.5
            return x <= 0.5f ? HermiteInterpolation(0, 0, w, slope, 2 * x) : HermiteInterpolation(w, slope, 1, 0, 2 * x - 1);
        }

        static float HermiteInterpolation(float startValue, float startSlope, float endValue, float endSlope, float x)
        {
            float xSquared = x * x;
            float xCubed = xSquared * x;

            return xCubed * (2 * startValue + startSlope - 2 * endValue + endSlope) +
                xSquared * (-3 * startValue - 2 * startSlope + 3 * endValue - endSlope) +
                x * startSlope +
                startValue;
        }

        #endregion
    }
}
