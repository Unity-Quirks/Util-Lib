
namespace Quirks.Pooling
{
    public interface IPoolable
    {
        /// <summary>Called when object is taken from pool</summary>
        void OnGet();

        /// <summary>Called when object is returned to pool</summary>
        void OnReturn();

        /// <summary>Called when pool is cleared</summary>
        void OnDispose();
    }
}