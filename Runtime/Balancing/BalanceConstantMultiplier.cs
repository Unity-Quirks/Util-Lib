using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class BalanceConstantMultiplier
    {
        [SerializeField] bool hasConstantMultiplier;
        [SerializeField] int levelOffset;
        [SerializeField] int levelConstant;
        [SerializeField] float constantMultiplier;

        public double GetMultiplier(int _level)
        {
            if (!hasConstantMultiplier || levelConstant == 0)
                return 1;

            double multiplier = 1;

            if (_level >= levelOffset)
            {
                int amount = (_level - levelOffset) / levelConstant;
                multiplier = (amount * constantMultiplier) + 1;
            }

            return multiplier;
        }

        public bool HasMultiplier(int _level)
        {
            if (!hasConstantMultiplier)
                return false;

            if (_level >= levelOffset)
                return true;

            return false;
        }
    }
}