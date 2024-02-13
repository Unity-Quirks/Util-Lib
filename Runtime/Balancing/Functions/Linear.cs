using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class Linear : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        [SerializeField] private double increment;
        public double Increment => increment;

        public Linear(double baseValue, double increment)
        {
            this.baseValue = baseValue;
            this.increment = increment;
        }

        public double GetValue(int level)
        {
            double factor = Math.Max(0, level);
            return baseValue + (factor * increment);
        }

        public int GetKey(double value)
        {
            throw new System.NotImplementedException();
        }
    }
}