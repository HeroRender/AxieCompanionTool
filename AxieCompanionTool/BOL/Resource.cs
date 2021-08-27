using System;
using System.Media;

namespace AxieCompanionTool.BOL
{
    public class Resource : IResource
    {
        int _Value = 0;
        int _MaxValue;

        public Resource(int maxValue)
        {
            _MaxValue = maxValue;
        }

        public bool Gain() => Modify(_Value + 1);

        public bool Gain(int value) => Modify(_Value + value);

        public bool Lose() => Modify(_Value - 1);

        public bool Lose(int value) => Modify(_Value - value);

        // Will return TRUE if input value is lessthan 0 or greaterthan the max value
        public bool Modify(int value)
        {
            if (value <= _MaxValue && value >= 0)
            {
                _Value = value;
                return false;
            }
            else if (value > _MaxValue)
            {
                _Value = _MaxValue;
            }
            else if (value < 0)
            {
                _Value = 0;
            }

            return true;
        }

        public int Value() => _Value;
    }
}
