using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TennApp.Models
{
    public class CategoryType
    {
        [Key]
        public int CategoryTypeID { get; set; }

        [MaxLength(5, ErrorMessage = "Too long type.")]
        public String Name { get; set; }

        //Navigation properties
        public List<Category> Categories { get; set; }



    }
}
