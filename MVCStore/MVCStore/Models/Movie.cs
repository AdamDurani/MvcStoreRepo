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
        public String Title { get; set; }
        public GenreType Genre { get; set; }
        public int DateOfRelease { get; set; }
        public double Price { get; set; }


        
    }
}
