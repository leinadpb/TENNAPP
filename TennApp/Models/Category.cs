using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(70, ErrorMessage = "Too long name.")]
        public String Name { get; set; }

        [MaxLength(80, ErrorMessage = "Too long description.")]
        public String Description { get; set; }

        [Range(0,110,ErrorMessage = "Not a valid age.")]
        public int MaxAge { get; set; }

        [Range(0,110, ErrorMessage = "Not a valid age.")]
        public int MinAge { get; set; }

        [Required]
        public CategoryType Type { get; set; }

        //Navigation Properties
        public List<Person> Persons { get; set; }
        public List<Bill> Bills { get; set; }

    }
}
