using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennApp.Models;

namespace TennApp.Data
{
    public class DbInitializer
    {
        public static void Initiliaze(ApplicationDbContext _context)
        {
            _context.Database.EnsureCreated();



            if (_context.Persons.Any())
            { return; } else { return; }

        }
    }
}
