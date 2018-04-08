using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TennApp.ViewModels
{
    public class BillViewModel
    {
        public SelectList Users { get; set; }
        public SelectList Payments { get; set; }
        public SelectList Tourneys { get; set; }
        public int PersonID { get; set; }
        public int TourneyID { get; set; }
        public int PaymentMethodID { get; set; }
    }
}
