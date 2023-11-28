
namespace Quirks
{
    public static class FloatExtensions
    {
        public static int ToInt(this float value) => (int)value;
        public static long ToLong(this float value) => (long)value;

        public static float ToDeg(this float value) => value * Mathq.Rad2Deg;
        public static float ToRad(this float value) => value * Mathq.Deg2Rad;

        public static float Clamp(this float value, float min, float max) => Mathq.Clamp(value, min, max);
        public static float Clamp01(this float value) => Mathq.Clamp01(value);

    }
}
