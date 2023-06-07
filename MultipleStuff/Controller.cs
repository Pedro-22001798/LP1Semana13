using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class Controller
    {
        private IView view;
        public void Controller()
        {
            
        }

        public void Run(IView view)
        {
            this.view = view;
        }
    }
}