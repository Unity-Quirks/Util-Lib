using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class Quadratic : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        [SerializeField] private double b;
        public double B => b;

        [SerializeField] private double c;
        public double C => c;

        /// <summary>
        /// y = a + bx + cx^2
        /// </summary>
        public Quadratic(double baseValue, double b, double c)
        {
            this.baseValue = baseValue;
            this.b = b;
            this.c = c;
        }

        public double GetValue(int level)
        {
            double x = Math.Max(0, level);
            if (x == 0)
            {
                return baseValue;
            }

            return baseValue + (b * x) + (c * Math.Pow(x, 2));
        }

        public int GetKey(double value)
        {
            throw new NotImplementedException();
        }
    }
}