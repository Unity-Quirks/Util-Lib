
namespace Quirks
{
    public static class BoolExtensions
    {
        public static int ToInt(this bool value) => value ? 1 : 0;
        public static long ToLong(this bool value) => value ? 1 : 0;
        public static float ToFloat(this bool value) => value ? 1f : 0f;
        public static double ToDouble(this bool value) => value ? 1.0 : 0.0;
    }
}
