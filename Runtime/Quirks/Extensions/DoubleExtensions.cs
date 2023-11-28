
namespace Quirks
{
    public static class DoubleExtensions
    {
        public static int ToInt(this double value) => (int)value;
        public static long ToLong(this double value) => (long)value;

        public static double ToDeg(this double value) => value * Mathq.Rad2Deg;
        public static double ToRad(this double value) => value * Mathq.Deg2Rad;

        public static double Clamp(this double value, double min, double max) => Mathq.Clamp(value, min, max);
        public static double Clamp01(this double value) => Mathq.Clamp01(value);
    }
}
