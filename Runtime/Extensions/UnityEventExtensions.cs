using UnityEngine.Events;

namespace Quirks
{
    public static class UnityEventExtensions
    {
        public static void SetListener(this UnityEvent uEvent, UnityAction call)
        {
            uEvent.RemoveAllListeners();
            uEvent.AddListener(call);
        }

        public static void SetListener<T>(this UnityEvent<T> uEvent, UnityAction<T> call)
        {
            uEvent.RemoveAllListeners();
            uEvent.AddListener(call);
        }
    }
}
