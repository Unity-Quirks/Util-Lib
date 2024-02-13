
namespace Quirks.Balancing
{
    public interface IBalance
    {
        double GetValue(int _level);

        int GetKey(double _value);
    }
}