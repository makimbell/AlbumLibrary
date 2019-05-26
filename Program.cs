using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            var album = new Album("Yellow Submarine", "The Beatles");            
            var book = new Book("Moby-Dick", "Herman Melville");            
            var movie = new Movie("Lawrence of Arabia", "David Lean");
            
            Console.WriteLine("Album: " + album.Title + " by " + album.Artist);
            Console.WriteLine("Book: " + book.Title + " by " + book.Author);
            Console.WriteLine("Movie: " + movie.Title + " by " + movie.Director);
            
            Console.WriteLine(album.GetDisplayText());
            album.Loan("Andy Kimbell");
            Console.WriteLine(album.GetDisplayText());
            album.Return();
            Console.WriteLine(album.GetDisplayText());
        }
    }
}