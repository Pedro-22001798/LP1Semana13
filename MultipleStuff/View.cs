using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class View : IView
    {
        private Controller controller;
        public View(Controller controller)
        {
            this.controller = controller;
        }
    }
}