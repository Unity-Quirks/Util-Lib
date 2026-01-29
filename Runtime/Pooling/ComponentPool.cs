using System;
using UnityEngine;

namespace Quirks.Pooling
{
    public class ComponentPool<T> where T : Component, IPoolable
    {
        readonly BasePool<T> pool;
        readonly Transform parent;

        readonly bool setActiveState;

        public ComponentPool(BasePool<T> pool, Transform parent = null, bool setActiveState = true)
        {
            this.pool = pool ?? throw new ArgumentNullException(nameof(pool));
            this.parent = parent;
            this.setActiveState = setActiveState;
        }

        public T Get()
        {
            T item  = pool.Get();

            item.transform.SetParent(parent, false);

            if (setActiveState)
                item.gameObject.SetActive(true);

            return item;
        }

        public void Return(T item)
        {
            if (item == null)
                return;

            item.transform.SetParent(parent, false);

            if (setActiveState)
                item.gameObject.SetActive(false);

            pool.Return(item);
        }

        public void Clear() => pool.Clear();
        public void Prewarm(int count) => pool.Prewarm(count);
    }
}
