using System.Collections.Generic;

namespace Quirks.Collections.Generic
{
    public class TimedBuffer
    {
        public readonly List<double> timeBuffer;
        public readonly List<int> valueBuffer;

        public readonly double timePeriod;

        public TimedBuffer(double timePeriod)
        {
            this.timeBuffer = new List<double>();
            this.valueBuffer = new List<int>();
            this.timePeriod = timePeriod;
        }

        ~TimedBuffer()
        {
            timeBuffer.Clear();
            valueBuffer.Clear();
        }

        public void Update(double time)
        {
            for (int i = 0; i < timeBuffer.Count; i++)
            {
                if (timeBuffer[i] + timePeriod <= time)
                {
                    timeBuffer.RemoveAt(i);
                    valueBuffer.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Add(double time, int value)
        {
            Update(time);

            timeBuffer.Add(time);
            valueBuffer.Add(value);
        }

        public int GetBufferSize()
        {
            int total = 0;
            if (timeBuffer.Count > 0)
            {
                for (int i = 0; i < timeBuffer.Count; i++)
                {
                    total += valueBuffer[i];
                }
            }

            return total;
        }

        public int GetBufferSizeAverage() => (int)((float)GetBufferSize() / timeBuffer.Count);
    }
}
