using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Controller
    {
        private string[] args;
        private IView? view;
        public Controller(string[] args)
        {
            this.args = args;
        }

        public void Run(IView view)
        {
            if (view == null)
            {
                throw new InvalidOperationException("View is not set.");
            }

            this.view = view;

            foreach(string s in args)
            {
                view.ShowStringResult(s,IsStringPalindrome(s));
            }
        }

        public bool IsStringPalindrome(string testString)
        {
            if (view == null)
            {
                throw new InvalidOperationException("View is not set.");
            }

            if(testString == null)
            {
                throw new ArgumentNullException();
            }
            else if(testString.Length < 2)
            {
                return true;
            }
            else
            {
                return CheckPalindrome(testString);
            }

            bool CheckPalindrome(string testString)
            {
                return testString.SequenceEqual(testString.Reverse());
            }
        }
    }
}