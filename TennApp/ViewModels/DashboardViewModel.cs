using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalUsers { get; set; }
        public int TotalCategories { get; set; }
        public int YoungUsers { get; set; }
        public int AdultUsers { get; set; }
        public int OldUsers { get; set; }
        public int TotalMen { get; set; }
        public int TotalWomen { get; set; }

    }
}
