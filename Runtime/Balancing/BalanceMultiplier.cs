using System;
using System.Collections.Generic;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class BalanceMultiplier
    {
        [SerializeField] bool hasMultiplier;
        [SerializeField] List<LevelValue> levelValues = new List<LevelValue>();

        public double GetMultiplier(int _level)
        {
            if (!hasMultiplier)
                return 1;

            double multiplier = 1;

            for (int i = 0; i < levelValues.Count; i++)
            {
                if (_level >= levelValues[i].Level)
                    multiplier += levelValues[i].Value;
                else
                    break;
            }

            return multiplier;
        }

        public bool HasMultiplier(int _level)
        {
            if (!hasMultiplier)
                return false;

            for (int i = 0; i < levelValues.Count; i++)
            {
                if (_level >= levelValues[i].Level)
                    return true;
            }

            return false;
        }
    }
}