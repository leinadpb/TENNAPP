using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.Models
{
    public class ReportType
    {
        [Key]
        public int ReportTypeID { get; set; }

        [Required]
        [MaxLength(120, ErrorMessage = "Report name is too long.")]
        public String Name { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Reference code is too long.")]
        [MinLength(5, ErrorMessage = "Reference code is too short.")]
        public String ReferenceCode { get; set; }
    }
}
