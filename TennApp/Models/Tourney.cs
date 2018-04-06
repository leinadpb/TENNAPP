using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.Models
{
    public class Tourney
    {
        [Key]
        public int TourneyID { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Tourney name too long.")]
        public String Name { get; set; }

        [MaxLength(120, ErrorMessage = "The description is too long.")]
        public String Description { get; set; }

        [Required]
        public String FechaInicio { get; set; }

        [Required]
        public String FechaFin { get; set; }

        //Navigation properties
        public List<Person> Persons { get; set; }

    }
}
