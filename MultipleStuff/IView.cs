using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public interface IView
    {
        void ShowResult(int version, double min, double max);
    }
}