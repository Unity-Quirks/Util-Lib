using System;
using System.Runtime.CompilerServices;

namespace Quirks
{
    public static class Trigq
    {
        #region Sin

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the sine of angle x.</summary>
        public static double Sin(double x) => Math.Sin(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the sine of angle x.</summary>
        public static float Sin(float x) => MathF.Sin(x);

        #endregion

        #region Sinh

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sinh(double x) => Math.Sinh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sinh(float x) => MathF.Sinh(x);

        #endregion

        #region Asin

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-sine of x - the angle in radians whose sine is x.</summary>
        public static double Asin(double x) => Math.Asin(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-sine of x - the angle in radians whose sine is x.</summary>
        public static float Asin(float x) => MathF.Asin(x);

        #endregion

        #region Asinh

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Asinh(double x) => Math.Asinh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Asinh(float x) => MathF.Asinh(x);

        #endregion



        #region Cos

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the cosine of angle x.</summary>
        public static double Cos(double x) => Math.Cos(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the cosine of angle x.</summary>
        public static float Cos(float x) => MathF.Cos(x);

        #endregion

        #region Cosh

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Cosh(double x) => Math.Cosh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cosh(float x) => MathF.Cosh(x);

        #endregion

        #region Acos

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-cosine of x - the angle in radians whose cosine is x.</summary>
        public static double Acos(double x) => Math.Acos(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-cosine of x - the angle in radians whose cosine is x.</summary>
        public static float Acos(float x) => MathF.Acos(x);

        #endregion

        #region Acosh

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Acosh(double x) => Math.Acosh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Acosh(float x) => MathF.Acosh(x);

        #endregion



        #region Tan

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the tangent of angle x in radians.</summary>
        public static double Tan(double x) => Math.Tan(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the tangent of angle x in radians.</summary>
        public static float Tan(float x) => MathF.Tan(x);

        #endregion

        #region Tanh

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Tanh(double x) => Math.Tanh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Tanh(float x) => MathF.Tanh(x);

        #endregion

        #region Atan

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-tangent of x - the angle in radians whose tangent is x.</summary>
        public static double Atan(double x) => Math.Atan(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-tangent of x - the angle in radians whose tangent is x.</summary>
        public static float Atan(float x) => MathF.Atan(x);

        #endregion

        #region Atan2

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the angle in radians whose tangent is y/x.</summary>
        public static double Atan2(double y, double x) => Math.Atan2(y, x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the angle in radians whose tangent is y/x.</summary>
        public static float Atan2(float y, float x) => MathF.Atan2(y, x);

        #endregion

        #region Atanh

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Atanh(double x) => Math.Atanh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Atanh(float x) => MathF.Atanh(x);

        #endregion



        #region Sec

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the secant of an angle in radians, or hypotenuse / adjacent.</summary>
        public static float Sec(float x) => 1f / Cos(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the secant of an angle in radians, or hypotenuse / adjacent.</summary>
        public static double Sec(double x) => 1.0 / Cos(x);

        #endregion

        #region Sech

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the secant.</summary>
        public static float Sech(float x) => 1f / Cosh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-secant.</summary>
        public static double Sech(double x) => 1.0 / Cosh(x);

        #endregion

        #region Asec

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-secant.</summary>
        public static float Asec(float x) => Acos(1f / x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-secant.</summary>
        public static double Asec(double x) => Acos(1 / x);

        #endregion

        #region Asech

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the area-secant.</summary>
        public static float Asech(float x) => Acosh(1f / x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the area-secant.</summary>
        public static double Asech(double x) => Acosh(1.0 / x);

        #endregion



        #region Csc

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the cosecant of an angle in radians, or hypotenuse / opposite.</summary>
        public static float Csc(float x) => 1f / Sin(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the cosecant of an angle in radians, or hypotenuse / opposite.</summary>
        public static double Csc(double x) => 1.0 / Sin(x);

        #endregion

        #region Csch

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the hyperbolic-cosecant.</summary>
        public static float Csch(float x) => 1f / Sinh(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the hyperbolic-cosecant.</summary>
        public static double Csch(double x) => 1.0 / Sinh(x);

        #endregion

        #region Acsc

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-cosecant in radians.</summary>
        public static float Acsc(float x) => Asin(1f / x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-cosecant in radians.</summary>
        public static double Acsc(double x) => Asin(1.0 / x);

        #endregion

        #region Acsch

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the hyperbolic-area-cosecant.</summary>
        public static float Acsch(float x) => Asinh(1f / x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the hyperbolic-area-cosecant.</summary>
        public static double Acsch(double x) => Asinh(1.0 / x);

        #endregion



        #region Cot

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the cotangent of an angle in radians, or adjacent / opposite.</summary>
        public static float Cot(float x) => 1f / Tan(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the cotangent of an angle in radians, or adjacent / opposite.</summary>
        public static double Cot(double x) => 1.0 / Tan(x);

        #endregion

        #region Coth

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the hyperbolic-cotangent.</summary>
        public static float Coth(float x)
        {
            if (Mathq.Abs(x) > 19.1f)
                return Mathq.Sign(x);

            float exp2x = Mathq.Exp(x * 2f);
            return (exp2x + 1f) / (exp2x -1f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the hyperbolic-cotangent.</summary>
        public static double Coth(double x)
        {
            if (Mathq.Abs(x) > 19.1)
                return Mathq.Sign(x);

            double exp2x = Mathq.Exp(x * 2.0);
            return (exp2x + 1.0) / (exp2x - 1.0);
        }

        #endregion

        #region Acot

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-cotangent.</summary>
        public static float Acot(float x) => Atan(1f / x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the arc-cotangent.</summary>
        public static double Acot(double x) => Atan(1.0 / x);

        #endregion

        #region Acoth

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the hyperbolic-area-cotangent</summary>
        public static float Acoth(float x) => 0.5f * Mathq.Log((x + 1) / (x - 1), Mathq.E);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>Returns the hyperbolic-area-cotangent</summary>
        public static double Acoth(double x) => 0.5 * Mathq.Log((x + 1) / (x - 1), Mathq.doubleE);

        #endregion


        #region Versin

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Versin(float x) => 1f - Cos(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Versin(double x) => 1.0 - Cos(x);

        #endregion

        #region Vercos

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Vercos(float x) => 1f + Cos(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Vercos(double x) => 1.0 + Cos(x);

        #endregion

        #region Coversin

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Coversin(float x) => 1f - Sin(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Coversin(double x) => 1.0 - Sin(x);

        #endregion

        #region Covercos

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Covercos(float x) => 1f + Sin(x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Covercos(double x) => 1.0 + Sin(x);

        #endregion


        #region Degress To Radians

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DegToRad(float degrees) => degrees * Mathq.Deg2Rad;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double DegToRad(double degrees) => degrees * Mathq.doubleDeg2Rad;

        #endregion

        #region Radians To Degrees

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float RadToDeg(float radians) => radians * Mathq.Rad2Deg;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double RadToDeg(double radians) => radians * Mathq.doubleRad2Deg;

        #endregion


        #region Normalize

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float NormalizeAngle(float angle)
        {
            angle %= 360f;
            if (angle < 0) 
                angle += 360f;

            return angle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double NormalizeAngle(double angle)
        {
            angle %= 360.0;
            if (angle < 0.0)
                angle += 360.0;

            return angle;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float NormalizeAngleRadians(float angle)
        {
            angle %= Mathq.Tau;
            if (angle < 0f)
                angle += Mathq.Tau;

            return angle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double NormalizeAngleRadians(double angle)
        {
            angle %= Mathq.doubleTau;
            if (angle < 0.0)
                angle += Mathq.doubleTau;

            return angle;
        }

        #endregion

        #region Distance

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;

            return Mathq.Sqrt(dx * dx + dy * dy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(long x1, long y1, long x2, long y2)
        {
            long dx = x2 - x1;
            long dy = y2 - y1;

            return Mathq.Sqrt(dx * dx + dy * dy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Distance(float x1, float y1, float x2, float y2)
        {
            float dx = x2 - x1;
            float dy = y2 - y1;

            return Mathq.Sqrt(dx * dx + dy * dy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;

            return Mathq.Sqrt(dx * dx + dy * dy);
        }

        #endregion

        #region Direction

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Direction(int x1, int y1, int x2, int y2) => Atan2(y2 - y1, x2 - x1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Direction(long x1, long y1, long x2, long y2) => Atan2(y2 - y1, x2 - x1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Direction(float x1, float y1, float x2, float y2) => Atan2(y2 - y1, x2 - x1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Direction(double x1, double y1, double x2, double y2) => Atan2(y2 - y1, x2 - x1);

        #endregion

        #region DirectionToVector

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (float x, float y) DirectionToVector(float angle, float magnitude = 1f) => (Cos(angle) * magnitude, Sin(angle) * magnitude);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (double x, double y) DirectionToVector(double angle, double magnitude = 1.0) => (Cos(angle) * magnitude, Sin(angle) * magnitude);

        #endregion
    }
}
