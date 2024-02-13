using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class Cube : IBalance
    {
        [SerializeField] private double baseValue;
        public double BaseValue => baseValue;

        [SerializeField] private double cubeValue;
        public double CubeValue => cubeValue;

        public Cube(double baseValue, double cubeValue)
        {
            this.baseValue = baseValue;
            this.cubeValue = cubeValue;
        }

        public double GetValue(int level)
        {
            if (level <= 0)
            {
                return baseValue;
            }

            return (Math.Pow(cubeValue, 3) * level) + baseValue;
        }

        public int GetKey(double value)
        {
            throw new System.NotImplementedException();
        }

    }
}