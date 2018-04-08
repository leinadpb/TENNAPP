using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.Models
{
    public class PersonsByCategory
    {
        public Category Category { get; set; }
        public List<PersonWithTShirt> Persons { get; set; }
    }
}
