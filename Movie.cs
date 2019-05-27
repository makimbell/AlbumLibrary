namespace Treehouse.MediaLibrary
{
    class Movie : MediaClass
    {
        public readonly string Director;
        
        public Movie(string title, string director)
            : base(title)
        {
            Director = director;
        }
        public string GetDisplayText()
        {
            if (OnLoan)
            {
                return ("Movie: " + Title + " by " + Director + ". Rented by " + Loanee);
            }

            return ("Movie: " + Title + " by " + Director + ". Available to rent. ");
        }
    }
}