using System;
using System.Collections.Generic;

namespace MVCStore.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MoviePurchase = new HashSet<MoviePurchase>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Genre { get; set; }
        public DateTime DateOfRelease { get; set; }
        public decimal Price { get; set; }

        public ICollection<MoviePurchase> MoviePurchase { get; set; }
    }
}
