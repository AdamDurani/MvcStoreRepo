using System;
using System.Collections.Generic;

namespace MVCStore.Models
{
    public partial class MoviePurchase
    {
        public int MoviePurchaseId { get; set; }
        public int AccountId { get; set; }
        public int MovieId { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public Account Account { get; set; }
        public Movie Movie { get; set; }
    }
}
