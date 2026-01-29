using System;
using System.Collections.Generic;

namespace Quirks.Pooling
{
    public class ListPool<T> : BasePool<T> where T : IPoolable
    {
        readonly List<T> items;

        public ListPool(Func<T> factory, int initialCapacity = 10) : base(factory)
        {
            items = new List<T>(initialCapacity);
        }

        public ListPool(Func<T> factory, int initialSize, int initialCapacity = 10) : base(factory)
        {
            items = new List<T>(initialCapacity);
            Prewarm(initialSize);
        }

        public override T Get()
        {
            T item;

            if(items.Count > 0)
            {
                int last = items.Count - 1;
                item = items[last];

                items.RemoveAt(last);
                totalInPool--;
            }
            else
            {
                item = factory();
                totalCreated++;
            }

            item.OnGet();
            return item;
        }

        public override void Return(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (maxSize > 0 && totalInPool >= maxSize)
                return;  // Don't add to pool if at max size

            item.OnReturn();
            items.Add(item);
            totalInPool++;
        }

        public override void Clear()
        {
            foreach(T item in items)
            {
                item.OnDispose();
            }

            items.Clear();
            totalInPool = 0;
        }

        public override void Prewarm(int count)
        {
            for(int i = 0; i < count; i++)
            {
                if (maxSize > 0 && totalInPool >= maxSize)
                    break;

                T item = factory();

                item.OnReturn();
                items.Add(item);

                totalCreated++;
                totalInPool++;
            }
        }
    }
}