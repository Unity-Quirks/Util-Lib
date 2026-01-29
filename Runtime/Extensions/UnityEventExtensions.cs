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

        public static bool HasListeners(this UnityEvent uEvent) => uEvent != null && uEvent.GetPersistentEventCount() > 0;

        public static UnityEvent Then(this UnityEvent first, UnityEvent second)
        {
            UnityEvent combined = new UnityEvent();
            first.AddListener(() => combined.Invoke());
            second.AddListener(() => combined.Invoke());

            return combined;
        }

        public static UnityEvent Chain(this UnityEvent first, UnityAction call)
        {
            UnityEvent chained = new UnityEvent();
            first.AddListener(() =>
            {
                call?.Invoke();
                chained.Invoke();
            });
            return chained;
        }

        public static void AddOneTimeListener(this UnityEvent uEvent, UnityAction call)
        {
            UnityAction wrapper = null;
            wrapper = () =>
            {
                call?.Invoke();
                uEvent.RemoveListener(wrapper);
            };
            uEvent.AddListener(wrapper);
        }

        public static void AddOneTimeListener<T>(this UnityEvent<T> uEvent, UnityAction<T> call)
        {
            UnityAction<T> wrapper = null;
            wrapper = (arg) =>
            {
                call?.Invoke(arg);
                uEvent.RemoveListener(wrapper);
            };
            uEvent.AddListener(wrapper);
        }
    }
}
