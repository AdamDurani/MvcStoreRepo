using System;
using System.Collections.Generic;

namespace MVCStore.Models
{
    public partial class Person
    {
        public Person()
        {
            Account = new HashSet<Account>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Account> Account { get; set; }
    }
}
