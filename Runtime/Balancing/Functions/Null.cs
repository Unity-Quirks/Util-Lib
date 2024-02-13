
namespace Quirks.Balancing
{
    public class Null : IBalance
    {
        public double GetValue(int level)
        {
            return 0;
        }

        public int GetKey(double value)
        {
            return 0;
        }
    }
}