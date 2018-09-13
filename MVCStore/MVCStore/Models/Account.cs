using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCStore.Models
{
    public class Account
    {
        public enum MembershipType
        {
            PayAsYouGo, Monthly, Annually
        }

        public byte Id { get; set; }
        public String UserName { get; set; }
        public Person Holder { get; set; }
        public List<Movie> Movies { get; set; }
        public MembershipType Membership { get; set; }


        public static Account[] GetAccounts()
        {
            Account[] accounts =
            {
                new Account{UserName = "Person98", Holder = new Person{FirstName = "Bob", SecondName= "Smith", DateOfBirth = new DateTime(1973, 02, 12)}, Membership = MembershipType.Monthly},
                new Account{UserName = "Person94", Holder = new Person{FirstName = "Sara", SecondName= "Gold", DateOfBirth = new DateTime(1984, 05, 22)}, Membership = MembershipType.Annually},
                new Account{UserName = "Person98", Holder = new Person{FirstName = "Sally", SecondName= "Walker", DateOfBirth = new DateTime(1991, 08, 15)}, Membership = MembershipType.PayAsYouGo}
                
            };

            return accounts;
        }

    }
}
