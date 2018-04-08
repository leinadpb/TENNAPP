using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennApp.Models
{
    public class PersonWithTShirt
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String SecondName { get; set; }
        public String LastName { get; set; }
        public String SecondLastName { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Account { get; set; }
        public int Age { get; set; }
        public bool Confirmed { get; set; }
        public bool Payment { get; set; }
        public String Biography { get; set; }
        public String Nickname { get; set; }
        public String tshirtSize { get; set; }
        public int tshirtID { get; set; }
    }
}
