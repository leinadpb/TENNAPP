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
            { return; } //The database has been initiliazed.

            
            
            /**
             *  CATEGORY'S TYPES
             */
            CategoryType C1 = new CategoryType { Name="C-1" };
            CategoryType C2 = new CategoryType { Name = "C-2" };
            CategoryType C3 = new CategoryType { Name = "C-3" };
            CategoryType NoType = new CategoryType { Name = "" };
            _context.CategoryTypes.Add(C1);
            _context.CategoryTypes.Add(C2);
            _context.CategoryTypes.Add(C3);
            _context.CategoryTypes.Add(NoType);
            _context.SaveChanges();

            /**
             *  CATEGORIES
             */
            Category Fosiles = new Category //CategoryID = 1
            {
                Name = "FOSILES",
                Type = C1,
                Description = "",
                MaxAge = 0,
                MinAge = 0
            };
            Category Hechizeras = new Category //CategoryID = 2
            {
                Name = "HECHIZERAS",
                Type = C2,
                Description = "",
                MaxAge = 0,
                MinAge = 0
            };
            Category Calaveras = new Category //CategoryID = 3
            {
                Name = "CALAVERAS",
                Type = C3,
                Description = "",
                MaxAge = 0,
                MinAge = 0
            };
            Category Reliquias = new Category //CategoryID = 4
            {
                Name = "RELIQUIAS",
                Type = C2,
                Description = "Jovenes y Expertos",
                MaxAge = 35,
                MinAge = 19
            };
            Category MegaNovatas = new Category //CategoryID = 5
            {
                Name = "MEGA-NOVATAS",
                Type = NoType,
                Description = "",
                MaxAge = 0,
                MinAge = 0
            };
            Category Vestijios = new Category //CategoryID = 6
            {
                Name = "VESTIJIOS",
                Type = C2,
                Description = "",
                MaxAge = 0,
                MinAge = 45
            };
            Category Despojo = new Category //CategoryID = 7
            {
                Name = "DESPOJO",
                Type = C3,
                Description = "",
                MaxAge = 0,
                MinAge = 45
            };
            Category CadaveresNovatos = new Category //CategoryID = 8
            {
                Name = "CADAVERES-NOVATOS",
                Type = NoType,
                Description = "",
                MaxAge = 0,
                MinAge = 0
            };
            Category Momias = new Category //CategoryID = 9
            {
                Name = "CADAVERES-NOVATOS",
                Type = C3,
                Description = "",
                MaxAge = 35,
                MinAge = 0
            };
            Category NoCategory = new Category //CategoryID = 10
            {
                Name = "SIN-CATEGORIA",
                Type = NoType,
                Description = "",
                MaxAge = 0,
                MinAge = 0
            };
            _context.Categories.Add(Fosiles);
            _context.Categories.Add(Hechizeras);
            _context.Categories.Add(Calaveras);
            _context.Categories.Add(Reliquias);
            _context.Categories.Add(MegaNovatas);
            _context.Categories.Add(Vestijios);
            _context.Categories.Add(Despojo);
            _context.Categories.Add(CadaveresNovatos);
            _context.Categories.Add(Momias);
            _context.Categories.Add(NoCategory);
            _context.SaveChanges();

            /**
             * TShirts
             */
            TShirt Small = new TShirt // TShirtID = 1
            {
                Size = "Small",
            };
            TShirt Medium = new TShirt // TShirtID = 2
            {
                Size = "Medium",
            };
            TShirt Large = new TShirt // TShirtID = 3
            {
                Size = "Large",
            };
            TShirt XL = new TShirt // TShirtID = 4
            {
                Size = "XL",
            };
            TShirt XLarge = new TShirt // TShirtID = 5
            {
                Size = "X-Large",
            };
            _context.TShirts.Add(Small);
            _context.TShirts.Add(Medium);
            _context.TShirts.Add(Large);
            _context.TShirts.Add(XL);
            _context.TShirts.Add(XLarge);
            _context.SaveChanges();

            /**
             * PERSONS - Fosiles
             */
            var persons = new Person[]{
                new Person {
                    FirstName = "Carlos",
                    SecondName = "",
                    LastName = "Sully",
                    SecondLastName = "Bonelly",
                    Nickname = "",
                    Phone = "(809) 383-9024",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 3,
                    TShirt = Large,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };

            foreach(var p in persons)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Hehizeras
             */
            var persons2 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons2)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Calaveras
             */
            var persons3 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons3)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Magas-Novatas
             */
            var persons4 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons4)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Veestijios
             */
            var persons5 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons5)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Despojo
             */
            var persons6 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons6)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Reliquias
             */
            var persons7 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons7)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Cadaveres-Novatos
             */
            var persons8 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons8)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Momias
             */
            var persons9 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons9)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();

            /**
             * PERSONS - Sin categoria
             */
            var persons10 = new Person[]
            {
                new Person {
                    FirstName = "",
                    SecondName = "",
                    LastName = "",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 12,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 1,
                    Category = Fosiles
                },
            };
            foreach (var p in persons10)
            {
                _context.Persons.Add(p);
            }
            _context.SaveChanges();


            /**
             * REPORT'S TYPES
             */
            var ReportTypes = new ReportType[]
            {
                new ReportType{
                    Name = "General",
                    ReferenceCode = "TENN001"
                },
                new ReportType{
                    Name = "Por categoria",
                    ReferenceCode = "TENN002"
                },
                new ReportType{
                    Name = "Por nombre de usuarios",
                    ReferenceCode = "TENN003"
                },
                new ReportType{
                    Name = "Usuarios pagos y confirmados",
                    ReferenceCode = "TENN004"
                },
                new ReportType{
                    Name = "Usuarios pagos",
                    ReferenceCode = "TENN005"
                },
                new ReportType{
                    Name = "Todos los torneos",
                    ReferenceCode = "TENN006"
                },
                new ReportType{
                    Name = "Usuarios confirmados",
                    ReferenceCode = "TENN007"
                },
                new ReportType{
                    Name = "Cantidad de usuarios pagos y confirmados por categoria",
                    ReferenceCode = "TENN008"
                },
                new ReportType{
                    Name = "Porcentaje de usuarios pagos y no pagos",
                    ReferenceCode = "TENN009"
                },
                new ReportType{
                    Name = "Porcentaje de usuarios confirmados y no confirmados",
                    ReferenceCode = "TENN0010"
                },
                new ReportType{
                    Name = "Usuarios que han realizado al menos un pago",
                    ReferenceCode = "TENN0011"
                },
                new ReportType{
                    Name = "Usuarios que han participado en cada torneo",
                    ReferenceCode = "TENN0012"
                },
            };
            foreach(var rt in ReportTypes)
            {
                _context.ReportTypes.Add(rt);
            }
            _context.SaveChanges();
        }
    }
}
