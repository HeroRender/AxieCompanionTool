using System;
using System.Media;

namespace AxieResources
{
    public class Resource : IResource
    {
        int _Value = 0;
        int _MaxValue;

        public Resource(int value, int maxValue)
        {
            _Value = value;
            _MaxValue = maxValue;
        }

        public void Modify(int value)
        {
            if (value <= _MaxValue) _Value = value;
            else if (value > _MaxValue)
            {
                _Value = _MaxValue;
            }
            else if (value < 0)
            {
                _Value = 0;
            }
        }

        public int Value()
        {
            return _Value;
        }
    }
}
