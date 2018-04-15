using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennApp.Models;

namespace TennApp.Models
{
    public class PersonsByTourney
    {
        public Tourney Tourney { get; set; }
        public List<Person> Persons { get; set; }
    }
}
