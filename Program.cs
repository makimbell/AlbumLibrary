using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            try
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

                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());

                DetectMediaType(album);
                DetectMediaType(book);
                DetectMediaType(movie);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.ReadLine();
        }

        static void DetectMediaType(MediaClass item)
        {
            if (item is Album)
            {
                Console.WriteLine(item.Title + " is an album");
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " is a book");
            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a movie");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered");
            }
        }
    }
}