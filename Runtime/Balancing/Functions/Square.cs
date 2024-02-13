using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class Square : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        [SerializeField] private double squareValue;
        public double SquareValue => squareValue;

        public Square(double baseValue, double squareValue)
        {
            this.baseValue = baseValue;
            this.squareValue = squareValue;
        }

        public double GetValue(int level)
        {
            if (level <= 0)
            {
                return baseValue;
            }

            return (Math.Pow(squareValue, 2) * level) + baseValue;
        }

        public int GetKey(double value)
        {
            throw new System.NotImplementedException();
        }
    }
}