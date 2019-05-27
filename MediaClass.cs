using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Treehouse.MediaLibrary
{
    class MediaClass
    {
        public string Title;
        public string Loanee = null;
        public bool OnLoan = false;

        public MediaClass(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("A media must have a title");
            }
            else
            {
                Title = title;
            }
        }

        public void Loan(string loanee)
        {
            if (!OnLoan)
            {
                Loanee = loanee;
                OnLoan = true;
            }
        }

        public void Loan()
        {
            OnLoan = true;
            Loanee = "someone";
        }

        public void Return()
        {
            Loanee = null;
            OnLoan = false;
        }
    }
}
