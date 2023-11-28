
namespace Quirks
{
    public static class IntExtensions
    {
        public static string ToHexDec(this int value) => value.ToString("X");

        public static int Clamp(this int value, int min, int max) => Mathq.Clamp(value, min, max);
    }
}
