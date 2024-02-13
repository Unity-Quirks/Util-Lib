using UnityEngine;
using System;

namespace Quirks.Balancing
{
    [Serializable]
    public class LevelValue
    {
        [SerializeField] int level;
        public int Level => level;

        [SerializeField] double value;
        public double Value => value;

        public LevelValue(int level, double value)
        {
            this.level = level;
            this.value = value;
        }
    }
}