using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class Constant : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        public Constant(double baseValue)
        {
            this.baseValue = baseValue;
        }

        public double GetValue(int level) => baseValue;

        public int GetKey(double value) => throw new System.NotImplementedException();
    }
}