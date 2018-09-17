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

        public int Id { get; set; }
        public string Title { get; set; }
        public GenreType Genre { get; set; }
        public DateTime DateOfRelease { get; set; }
        public double Price { get; set; }

        // Temporary hard-coded data

        public static Movie[] getMovies()
        {
            var movies = new Movie[]{
                new Movie(){Title = "Aliens", Genre = GenreType.Horror, DateOfRelease = new DateTime(1986, 04, 12), Price = 3.50}, 
                new Movie(){Title = "Pacific Rim", Genre = GenreType.Action, DateOfRelease = new DateTime(2014, 08, 22), Price = 5.99},
                new Movie(){Title = "Jurassic Park", Genre = GenreType.Adventure, DateOfRelease = new DateTime(1997, 11, 13), Price = 2.99},
                new Movie(){Title = "Home Alone", Genre = GenreType.Adventure, DateOfRelease = new DateTime(1991, 01, 17), Price = 2.99},
                new Movie(){Title = "American Physcho", Genre = GenreType.Thriller, DateOfRelease = new DateTime(1986, 12, 07), Price = 1.99}};
            return movies;
        }

        
    }
}
