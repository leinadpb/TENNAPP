using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.Models
{
    public class Bill
    {
        [Key]
        public int BillID { get; set; }

        [Required]
        [Range(0.0, Double.MaxValue)]
        public double Mount { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Bill code is too long.")]
        public String Code { get; set; }

        //Navigation properties
        public int PersonID { get; set; }
        public Person Person { get; set; }

        public int PaymentMethodID { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}
