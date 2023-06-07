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
            Console.WriteLine($"{s} -> {result}");
        }
    }
}