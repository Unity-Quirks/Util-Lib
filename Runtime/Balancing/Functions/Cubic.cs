using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class Cubic : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        [SerializeField] private double b;
        public double B => b;

        [SerializeField] private double c;
        public double C => c;

        [SerializeField] private double d;
        public double D => d;

        /// <summary>
        /// y = a + bx + cx^2 + dx^3
        /// </summary>
        public Cubic(double baseValue, double b, double c, double d)
        {
            this.baseValue = baseValue;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public double GetValue(int level)
        {
            double x = Math.Max(0, level);
            if (x == 0)
            {
                return baseValue;
            }

            return baseValue + (b * x) + (c * Math.Pow(x, 2)) + (d * Math.Pow(x, 3));
        }

        public int GetKey(double value)
        {
            throw new NotImplementedException();
        }
    }
}