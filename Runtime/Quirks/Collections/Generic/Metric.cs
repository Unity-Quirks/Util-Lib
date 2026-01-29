using System;
using System.Collections.Generic;
using System.Linq;

namespace Quirks.Collections.Generic
{
    public class Metric<T> where T : struct, IComparable<T>, IConvertible
    {
        readonly Queue<(DateTime timeStamp, T value)> records;

        /// <summary>The maximum number of records to keep. Defaults to int.MaxValue</summary>
        readonly int maxRecords;

        /// <summary>The time span after which records are automatically removed.</summary>
        readonly TimeSpan retentionTime;

        public Metric(int maxRecords = int.MaxValue, TimeSpan? retentionTime = null)
        {
            this.records = new Queue<(DateTime, T)>();

            this.maxRecords = maxRecords;
            this.retentionTime = retentionTime ?? TimeSpan.MaxValue; // Default to Max Value
        }

        /// <summary>Add a new record with the provided value.</summary>
        public void Add(T value)
        {
            records.Enqueue((DateTime.UtcNow, value));

            CheckRecords();
        }

        /// <summary>Removes all records.</summary>
        public void Clear() => records.Clear();

        #region Gets

        /// <summary>Returns the current number of records.</summary>
        public int Count => records.Count;

        /// <summary>Returns the minimum value among all records.</summary>
        public T Min
        {
            get
            {
                if (records.Count == 0)
                    return default;

                return records.Min(r => r.value);
            }
        }

        public T MinSince(TimeSpan timeSpan)
        {
            if (records.Count == 0)
                return default;

            DateTime cutOff = DateTime.UtcNow - timeSpan;
            List<(DateTime timeStamp, T value)> filteredRecords = records.Where(r => r.timeStamp >= cutOff).ToList();

            if (filteredRecords.Count == 0)
                return default;

            return filteredRecords.Min(r => r.value);
        }

        /// <summary>Returns the maximum value among all records.</summary>
        public T Max
        {
            get
            {
                if (records.Count == 0)
                    return default;

                return records.Max(r => r.value);
            }
        }

        public T MaxSince(TimeSpan timeSpan)
        {
            if (records.Count == 0)
                return default;

            DateTime cutOff = DateTime.UtcNow - timeSpan;
            List<(DateTime timeStamp, T value)> filteredRecords = records.Where(r => r.timeStamp >= cutOff).ToList();

            if (filteredRecords.Count == 0)
                return default;

            return filteredRecords.Max(r => r.value);
        }

        /// <summary>Returns the sum of all values.</summary>
        public T Sum
        {
            get
            {
                if (records.Count == 0)
                    return default;

                return (T)Convert.ChangeType(records.Sum(r => Convert.ToDouble(r.value)), typeof(T));
            }
        }
        /// <summary>Returns the sum of all values.</summary>
        public T Total => Sum;

        public T SumSince(TimeSpan timeSpan)
        {
            if (records.Count == 0)
                return default;

            DateTime cutOff = DateTime.UtcNow - timeSpan;
            List<(DateTime timeStamp, T value)> filteredRecords = records.Where(r => r.timeStamp >= cutOff).ToList();

            if (filteredRecords.Count == 0)
                return default;

            return (T)Convert.ChangeType(filteredRecords.Sum(r => Convert.ToDouble(r.value)), typeof(T));
        }
        public T TotalSince(TimeSpan timeSpan) => SumSince(timeSpan);

        /// <summary>Returns the average of all values.</summary>
        public T Average
        {
            get
            {
                if (records.Count == 0)
                    return default;

                return (T)Convert.ChangeType(records.Average(r => Convert.ToDouble(r.value)), typeof(T));
            }
        }

        public T AverageSince(TimeSpan timeSpan)
        {
            if (records.Count == 0)
                return default;

            DateTime cutOff = DateTime.UtcNow - timeSpan;
            List<(DateTime timeStamp, T value)> filteredRecords = records.Where(r => r.timeStamp >= cutOff).ToList();

            if (filteredRecords.Count == 0)
                return default;

            return (T)Convert.ChangeType(filteredRecords.Average(r => Convert.ToDouble(r.value)), typeof(T));
        }

        #endregion

        /// <summary>Internal method to ensure collection does not exceed its parameter. </summary>
        void CheckRecords()
        {
            // Remove oldest records if exceeding max records
            while (records.Count > maxRecords)
            {
                records.Dequeue();
            }

            // Remove records older than the retention time
            while (records.Count > 0 && records.Peek().timeStamp < DateTime.UtcNow - retentionTime)
            {
                records.Dequeue();
            }
        }
    }
}
