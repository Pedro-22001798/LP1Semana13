using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class Controller
    {
        private IView? view;
        private SuperList superList;
        public Controller(SuperList superList)
        {
            this.superList = superList;
        }

        public void Run(IView view)
        {
            if (view == null)
            {
                throw new InvalidOperationException("View is not set.");
            }

            this.view = view;

            double min1, max1;
            superList.GetMinMax1(out min1, out max1);
            view.ShowResult(1,min1,max1);

            (double min2, double max2) = superList.GetMinMax2();
            view.ShowResult(2,min2,max2);

            double min3 = double.MinValue;
            double max3 = double.MaxValue;
            superList.GetMinMax3(ref min3, ref max3);
            view.ShowResult(3,min3,max3);

            var(Min4,Max4) = superList.GetMinMax4();
            view.ShowResult(4,Min4,Max4);
        }
    }
}