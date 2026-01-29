using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class ExponentialSin : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        [SerializeField] private double exponent;
        public double Exponent => exponent;

        private double sinStep
        {
            get
            {
                return sinStep;
            }
            set
            {
                sinStep = value < 1 ? 1 : value;
            }
        }
        public double SinStep => sinStep;

        public ExponentialSin(double baseValue, double exponent, double sinStep)
        {
            this.baseValue = baseValue;
            this.exponent = exponent;
            this.sinStep = sinStep;
        }

        public double GetValue(int level)
        {
            double power = Math.Max(0, level);
            if (power == 0)
            {
                return baseValue;
            }

            double b = Math.Pow(exponent, power);
            return (Math.Sin(b / 1d) + b) + baseValue;
        }

        public int GetKey(double value)
        {
            throw new System.NotImplementedException();
        }
    }
}