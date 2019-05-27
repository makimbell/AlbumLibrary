namespace Treehouse.MediaLibrary
{
    class Book : MediaClass
    {
        public readonly string Author;
        
        public Book(string title, string author) 
            : base(title)
        {
            Author = author;
        }
        public string GetDisplayText()
        {
            if (OnLoan)
            {
                return ("Book: " + Title + " by " + Author + ". Rented by " + Loanee);
            }

            return ("Book: " + Title + " by " + Author + ". Available to rent. ");
        }
    }
}