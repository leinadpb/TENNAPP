using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TennApp.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "First name too long.")]
        public String FirstName { get; set; }

        [MaxLength(30, ErrorMessage = "Second name too long.")]
        public String SecondName { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Last name too long.")]
        public String LastName { get; set; }

        [MaxLength(30, ErrorMessage = "Second last name too long.")]
        public String SecondLastName { get; set; }

        public String FullName {
            get; set;
        }

        [MaxLength(30, ErrorMessage = "The nickname is too long.")]
        public String Nickname { get; set; }

        [MaxLength(22, ErrorMessage = "The phone number is too long.")]
        public String Phone { get; set; }

        [MaxLength(70, ErrorMessage = "The email is too long.")]
        public String Email { get; set; }

        [Range(0, 110, ErrorMessage = "The age is not in a valid range.")]
        public int Age { get; set; }

        public bool Confirmed { get; set; }

        public bool Payment { get; set; }

        [MaxLength(20, ErrorMessage = "The account number is too long.")]
        public String Account { get; set; }

        //public String Tshirt { get; set; }

        [MaxLength(80, ErrorMessage = "Biography is too long.")]
        public String Biography { get; set; }

        [MaxLength(12, ErrorMessage = "Identification too long.")]
        public String Cedula { get; set; }

        //Navigation properties
        public int TShirtID { get; set; }
        public TShirt TShirt { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public List<Bill> Bills { get; set; }

        public int TourneyID { get; set; }
        public Tourney Tourney { get; set; }

    }
}
