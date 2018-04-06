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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Explicity define on-to-one relation between Category and CategoryType
            builder.Entity<Category>()
                .HasOne(c => c.Type)
                .WithOne(ct => ct.Category)
                .HasForeignKey<CategoryType>(ct => ct.CategoryID);

            //Explicity define on-to-one relation between Bill y PaymentMethod
            builder.Entity<Bill>()
                .HasOne(b => b.PaymentMethod)
                .WithOne(pm => pm.Bill)
                .HasForeignKey<PaymentMethod>(pm => pm.BillID);
        }
    }
}
