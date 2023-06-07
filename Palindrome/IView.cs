using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindrome
{
    public interface IView
    {
        void ShowStringResult(string s, bool result);
    }
}