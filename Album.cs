namespace Treehouse.MediaLibrary
{
    class Album
    {
        public readonly string Title;
        public readonly string Artist;
        public string Loanee = null;
        public bool OnLoan = false;
        
        public Album(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
        
        public string GetDisplayText()
        {
            if (OnLoan)
            {
                return ("Album: " + Title + " by " + Artist + ". Rented by " + Loanee);
            }
            
            return ("Album: " + Title + " by " + Artist + ". Available to rent. ");
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