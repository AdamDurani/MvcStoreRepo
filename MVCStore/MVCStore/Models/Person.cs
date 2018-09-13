using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCStore.Models
{
    public class Person
    {
        public byte Id { get; set; }
        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        
    }
}
