using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindrome
{
    public class View : IView
    {
        private Controller controller;
        public View(Controller controller)
        {
            this.controller = controller;
        }

        public void ShowStringResult(string s, bool result)
        {
            if(result == true)
            {
                Console.WriteLine($"{s} -> true");
            }
            else
            {
                Console.WriteLine($"{s} -> false");
            }
        }
    }
}