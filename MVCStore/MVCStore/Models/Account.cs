using System;
using System.Collections.Generic;

namespace MVCStore.Models
{
    public partial class Account
    {
        public Account()
        {
            MoviePurchase = new HashSet<MoviePurchase>();
        }

        public int AccountId { get; set; }
        public string UserName { get; set; }
        public int PersonId { get; set; }
        public int MembershipType { get; set; }

        public Person Person { get; set; }
        public ICollection<MoviePurchase> MoviePurchase { get; set; }
    }
}
