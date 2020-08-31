using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Movies
{
    public class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie {Title = "The Dark Knight", Rating = 8.9f, Year = 2008 },
                new Movie {Title = "The King's Speech", Rating = 8.0f, Year = 2010 },
                new Movie {Title = "PeepeepoopooMan", Rating = 10.0f, Year = 1910 },
                new Movie {Title = "Star Wars V", Rating = 8.7f, Year = 1980 }
            };
            var query = movies.Where(m => m.Year > 2000)
                .OrderByDescending(m => m.Rating);
            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }


        }
    }
}
