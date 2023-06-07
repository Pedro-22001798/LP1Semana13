using System;
using System.Collections.Generic;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Controller controller = new Controller(args);
            IView view = new View(controller);
            controller.Run(view);
        }
    }
}