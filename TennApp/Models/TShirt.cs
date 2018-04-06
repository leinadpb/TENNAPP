using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.Models
{
    public class TShirt
    {
        [Key]
        public int TShirtID { get; set; }

        [Required]
        [MaxLength(7, ErrorMessage = "TShirt size is too long.")]
        public String Size { get; set; }

        //Navigation Properties
        public List<Person> Persons { get; set; }


    }
}
