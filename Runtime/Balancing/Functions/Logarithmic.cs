using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class Logarithmic : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        [SerializeField] private double logValue;
        public double LogValue => logValue;

        public Logarithmic(double baseValue, double logValue)
        {
            this.baseValue = baseValue;
            this.logValue = logValue;
        }

        public double GetValue(int level)
        {
            double power = Math.Max(0, level);
            if (power == 0)
            {
                return baseValue;
            }

            return (Math.Log(logValue) * level) + baseValue;
        }

        public int GetKey(double value)
        {
            throw new System.NotImplementedException();
        }
    }
}