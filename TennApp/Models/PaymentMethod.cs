using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.Models
{
    public class PaymentMethod
    {
        [Key]
        public int PaymentMethodID { get; set; }

        public String Name { get; set; }

        //Navigation properties
        public int BillID { get; set; }
        public Bill Bill { get; set; }

    }
}
