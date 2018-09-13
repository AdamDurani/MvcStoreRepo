using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCStore.Models
{
    public class Movie
    {
        public enum GenreType
        {
            Horror, Adventure, Action, Thriller
        }

        public byte Id { get; set; }
        public string Title { get; set; }
        public GenreType Genre { get; set; }
        public DateTime DateOfRelease { get; set; }
        public double Price { get; set; }

        // Temporary hard-coded data

        public static Movie[] getMovies()
        {
            var movies = new Movie[]{new Movie(){Title = "Aliens", Genre = GenreType.Horror, DateOfRelease = new DateTime(1986, 04, 12), Price = 3.50}};
            return movies;
        }

        
    }
}
