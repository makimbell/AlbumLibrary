namespace Treehouse.MediaLibrary
{
    class Album : MediaClass
    {
        public readonly string Artist;
        
        public Album(string title, string artist)
            : base(title)
        {
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
    }
}