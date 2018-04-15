using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TennApp.Models;

namespace TennApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<ReportType> ReportTypes { get; set; }
        public DbSet<TShirt> TShirts { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Tourney> Tourneys { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
