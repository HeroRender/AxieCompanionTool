using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxieCompanionTool.BOL
{
    public interface IResource
    {
        bool Modify(int value);
        bool Lose();
        bool Lose(int value);
        bool Gain();
        bool Gain(int value);
        int Value();
    }
}