using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennApp.Models;

namespace TennApp.ViewModels
{
    public class SearchViewModel
    {
        public List<PersonWithTShirt> People { get; set; }
        public List<TShirt> Tshirts { get; set; }
    }
}
