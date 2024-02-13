using System;
using UnityEngine;

namespace Quirks.Balancing
{
    [Serializable]
    public class BaseBalance
    {
        [SerializeField] BalanceAdjustment adjustment;
        public BalanceAdjustment Adjustment => adjustment;

        [SerializeField] BalanceMultiplier multiplier;
        public BalanceMultiplier Multiplier => multiplier;

        [SerializeField] BalanceConstantMultiplier constantMultiplier;
        public BalanceConstantMultiplier ConstantMultiplier => constantMultiplier;

        [SerializeField] BaseBalanceType type = BaseBalanceType.Linear;
        [SerializeField] int levelOffset;

        public BaseBalanceType Type => type;

        #region

        [SerializeField] Null _null = new Null();
        [SerializeField] Linear linear;
        [SerializeField] Square square;
        [SerializeField] SquareRoot squareRoot;
        [SerializeField] Cube cube;
        [SerializeField] Exponential exponential;
        [SerializeField] ExponentialSin exponentialSin;
        [SerializeField] Logarithmic logarithmic;
        [SerializeField] Constant constant;
        [SerializeField] Quadratic quadratic;
        [SerializeField] Cubic cubic;

        #endregion

        public double BaseValue
        {
            get
            {
                switch (type)
                {
                    case BaseBalanceType.Linear:
                        return linear.BaseValue;
                    case BaseBalanceType.Square:
                        return square.BaseValue;
                    case BaseBalanceType.SquareRoot:
                        return squareRoot.BaseValue;
                    case BaseBalanceType.Cube:
                        return cube.BaseValue;
                    case BaseBalanceType.Exponential:
                        return exponential.BaseValue;
                    case BaseBalanceType.ExponentialSin:
                        return exponentialSin.BaseValue;
                    case BaseBalanceType.Logarithmic:
                        return logarithmic.BaseValue;
                    case BaseBalanceType.Constant:
                        return constant.BaseValue;
                    case BaseBalanceType.Quadratic:
                        return quadratic.BaseValue;
                    case BaseBalanceType.Cubic:
                        return cubic.BaseValue;
                    default:
                        return 0;
                }
            }
        }

        public double Increment
        {
            get
            {
                switch (type)
                {
                    case BaseBalanceType.Linear:
                        return linear.Increment;
                    case BaseBalanceType.Square:
                        return square.SquareValue;
                    case BaseBalanceType.SquareRoot:
                        return squareRoot.SquareValue;
                    case BaseBalanceType.Cube:
                        return cube.CubeValue;
                    case BaseBalanceType.Exponential:
                        return exponential.Exponent;
                    case BaseBalanceType.ExponentialSin:
                        return exponentialSin.Exponent;
                    case BaseBalanceType.Logarithmic:
                        return logarithmic.LogValue;
                    case BaseBalanceType.Constant:
                        return constant.BaseValue;
                    default:
                        return 0;
                }
            }
        }

        IBalance GetBalance()
        {
            switch (type)
            {
                case BaseBalanceType.Linear:
                    return linear;
                case BaseBalanceType.Square:
                    return square;
                case BaseBalanceType.SquareRoot:
                    return squareRoot;
                case BaseBalanceType.Cube:
                    return cube;
                case BaseBalanceType.Exponential:
                    return exponential;
                case BaseBalanceType.ExponentialSin:
                    return exponentialSin;
                case BaseBalanceType.Logarithmic:
                    return logarithmic;
                case BaseBalanceType.Constant:
                    return constant;
                case BaseBalanceType.Quadratic:
                    return quadratic;
                case BaseBalanceType.Cubic:
                    return cubic;
            }

            return _null;
        }

        public double GetValue(int _level)
        {
            var level = _level - levelOffset;

            double overrideValue = 0;
            if (adjustment.HasAdjustment(_level))
            {
                overrideValue = adjustment.GetAdjustment(_level);
            }

            double multiplierValue = 1;
            if (multiplier.HasMultiplier(_level))
            {
                multiplierValue = multiplier.GetMultiplier(_level);
            }

            double constantMultiValue = 1;
            if (constantMultiplier.HasMultiplier(_level))
            {
                constantMultiValue = constantMultiplier.GetMultiplier(_level);
            }

            return ((GetBalance().GetValue(level) + overrideValue) * multiplierValue) * constantMultiValue;
        }
    }
}