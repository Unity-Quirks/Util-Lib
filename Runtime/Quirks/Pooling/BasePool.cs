using System;

namespace Quirks.Pooling
{
    /// <summary>Base class for object pooling systems</summary>
    public abstract class BasePool<T> : IDisposable where T : IPoolable
    {
        protected readonly Func<T> factory;

        protected int totalCreated;
        protected int totalInPool;
        protected int maxSize = -1;

        /// <summary>Total number of objects created by this pool</summary>
        public int TotalCreated => totalCreated;

        /// <summary>Number of objects currently in the pool</summary>
        public int CountInPool => totalInPool;

        /// <summary>Maximum size of the pool (-1 for unlimited)</summary>
        public int MaxSize
        {
            get => maxSize;
            set => maxSize = value;
        }

        protected BasePool(Func<T> factory)
        {
            this.factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        /// <summary>Get an object from the pool</summary>
        public abstract T Get();

        /// <summary>Return an object to the pool</summary>
        public abstract void Return(T item);

        /// <summary>Clear all objects from the pool</summary>
        public abstract void Clear();

        /// <summary>Pre-warm the pool with objects</summary>
        public abstract void Prewarm(int count);

        /// <summary>Dispose the pool and any managed resources</summary>
        public virtual void Dispose()
        {
            Clear();
        }
    }
}

