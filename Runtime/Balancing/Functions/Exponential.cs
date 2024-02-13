using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class Exponential : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        [SerializeField] private double exponent;
        public double Exponent => exponent;

        public Exponential(double baseValue, double exponent)
        {
            this.baseValue = baseValue;
            this.exponent = exponent;
        }

        public double GetValue(int level)
        {
            double power = Math.Max(0, level);
            if (power == 0)
            {
                return baseValue;
            }

            return Math.Pow(exponent, power) + baseValue;
        }

        public int GetKey(double _value)
        {
            throw new System.NotImplementedException();
        }
    }
}