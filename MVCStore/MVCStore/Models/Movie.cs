using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCStore.Models
{
    public partial class Movie
    {
        public enum MovieGenre
        {
            Horror, Action, Romance, Thriller, Adventure
        };



        public Movie()
        {
            MoviePurchase = new HashSet<MoviePurchase>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public MovieGenre Genre { get; set; }
        [DisplayName("Release Date")]
        public DateTime DateOfRelease {get; set; }
        public decimal Price { get; set; }

        public ICollection<MoviePurchase> MoviePurchase { get; set; }

        public string GetReleaseDate()
        {
            return DateOfRelease.ToShortDateString();
        }    
    }
}
