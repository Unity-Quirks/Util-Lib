using System.Collections.Generic;
using UnityEngine;
using System;

namespace Quirks.Balancing
{
    [Serializable]
    public class BalanceAdjustment
    {
        [SerializeField] bool hasAdjustment;
        [SerializeField] List<LevelValue> levelValues = new List<LevelValue>();

        public double GetAdjustment(int _level)
        {
            if (!hasAdjustment)
                return 0;

            for (int i = levelValues.Count - 1; i >= 0; i--)
            {
                if (levelValues[i].Level <= _level)
                    return levelValues[i].Value;
            }

            return 0;
        }

        public bool HasAdjustment(int _level)
        {
            if (!hasAdjustment)
                return false;
            for (int i = levelValues.Count - 1; i >= 0; i--)
            {
                if (levelValues[i].Level <= _level)
                    return true;
            }

            return false;
        }
    }
}