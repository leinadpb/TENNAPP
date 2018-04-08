using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennApp.Models;
namespace TennApp.ViewModels
{
    public class ReportsViewModel
    {
        public List<ReportType> Reports { get; set; }
        public List<PersonsByCategory> GeneralReport { get; set; }
    }
}
