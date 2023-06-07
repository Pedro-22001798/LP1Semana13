using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Controller controller = new Controller();
            IView view = new View(controller);
            controller.Run(view);
        }
    }
}