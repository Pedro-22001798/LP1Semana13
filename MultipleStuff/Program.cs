using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SuperList superList = new SuperList();
            superList.Add(10.5);
            superList.Add(2.5);
            superList.Add(5.3);
            superList.Add(20.8);
            superList.Add(12.3);
            superList.Add(5.5);
            superList.Add(7.1);
            superList.Add(11.2);
            superList.Add(52.3);
            superList.Add(35.2);

            Controller controller = new Controller(superList);
            IView view = new View(controller);
            controller.Run(view);
        }
    }
}