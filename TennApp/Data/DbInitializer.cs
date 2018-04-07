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
            TShirt TBA = new TShirt // TShirtID = 5
            {
                Size = "TBA",

            };
            TShirt XXL = new TShirt // TShirtID = 6
            {
                Size = "XXL",
            };
            _context.TShirts.Add(Small);
            _context.TShirts.Add(Medium);
            _context.TShirts.Add(Large);
            _context.TShirts.Add(XL);
            _context.TShirts.Add(TBA);
            _context.TShirts.Add(XXL);
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
                    FirstName = "Alfredo",
                    SecondName = "",
                    LastName = "Camacho",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "39025179",
                    TShirtID = 3,
                    TShirt = Large,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Edwin",
                    SecondName = "",
                    LastName = "Rios",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8098529877",
                    Email = "riosedwin@hotmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "112923149",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Emanuel",
                    SecondName = "",
                    LastName = "Cordero",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8297606039",
                    Email = "emmanuel.dlsc@gmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "97556636",
                    TShirtID = 4,
                    TShirt = XL,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Jorge",
                    SecondName = "",
                    LastName = "Niño",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8096627777",
                    Email = "jorgebischoff@yahoo.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "743406704",
                    TShirtID = 4,
                    TShirt = XL,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Jose",
                    SecondName = "Agustin",
                    LastName = "Sanchez",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8098475558",
                    Email = "jasr979@yahoo.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "710944851",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Jose",
                    SecondName = "Francisco",
                    LastName = "Martich",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8299046037",
                    Email = "jfrancisco@farmaciacristiana.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "770411320",
                    TShirtID = 3,
                    TShirt = Large,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Leovanny",
                    SecondName = "",
                    LastName = "Garcia",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8096691769",
                    Email = "leovanny_g@yahoo.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "117081950",
                    TShirtID = 4,
                    TShirt = XL,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Luis",
                    SecondName = "Manuel",
                    LastName = "Almanzar",
                    SecondLastName = "Marte",
                    Nickname = "",
                    Phone = "8093303409",
                    Email = "luisml.almanzar@gmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "790884209",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Manuel",
                    SecondName = "",
                    LastName = "Simo",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8095190304",
                    Email = "manuel.simo@avon.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "A cuenta",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
                },
                new Person {
                    FirstName = "Miguel",
                    SecondName = "Angel",
                    LastName = "Villaman",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8295697101",
                    Email = "miguelangelvillaman95@gmail.com",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "A cuenta",
                    TShirtID = 6,
                    TShirt = XXL,
                    Biography = "",
                    CategoryID = 8,
                    Category = CadaveresNovatos
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
                    FirstName = "Bismark",
                    SecondName = "",
                    LastName = "Tavarez",
                    SecondLastName = "Valenzuela",
                    Nickname = "",
                    Phone = "",
                    Email = "bistavarez21@hotmail.com",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "Caja",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Hamid",
                    SecondName = "",
                    LastName = "Trinidad",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8295993196",
                    Email = "hamidtrinidad@gmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "810000361",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Alejandro",
                    SecondName = "",
                    LastName = "Abreu",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "alejandro.abreu31@hotmail.com",
                    Age = 23,
                    Confirmed = false,
                    Payment = false,
                    Account = "785738857",
                    TShirtID = 1,
                    TShirt = Small,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Alejandro",
                    SecondName = "",
                    LastName = "Acebal",
                    SecondLastName = "Caney",
                    Nickname = "",
                    Phone = "8296472442",
                    Email = "aacebal@acarq.do",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "15100000",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Carlos",
                    SecondName = "",
                    LastName = "Cabral",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8094464000",
                    Email = "ccarloscabral@gmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "705508216",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Carlos",
                    SecondName = "",
                    LastName = "Espinal",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8098779022",
                    Email = "promogrhapicsolution@gmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "14142270",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Carlos",
                    SecondName = "",
                    LastName = "Lopez",
                    SecondLastName = "Collado",
                    Nickname = "",
                    Phone = "8293404159",
                    Email = "dr.carloslopezcollado@gmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "57465703",
                    TShirtID = 3,
                    TShirt = Large,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Dariel",
                    SecondName = "",
                    LastName = "Correa",
                    SecondLastName = "Amador",
                    Nickname = "",
                    Phone = "8293614607",
                    Email = "ing.darielca@gmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "A cuenta",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Dichens",
                    SecondName = "",
                    LastName = "Salcedo",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "dichenssalcedo@gmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "100528306",
                    TShirtID = 2,
                    TShirt = Medium,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
                },
                new Person {
                    FirstName = "Edmundo",
                    SecondName = "",
                    LastName = "Messina",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8297411146",
                    Email = "edmundo.messinagmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "789414190",
                    TShirtID = 3,
                    TShirt = Large,
                    Biography = "",
                    CategoryID = 9,
                    Category = Momias
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
                    FirstName = "Francisco",
                    SecondName = "Maria",
                    LastName = "Garcia",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8098388183",
                    Email = "f.ramg@hotmail.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Laura",
                    SecondName = "",
                    LastName = "Suero",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8493562818",
                    Email = "",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Abraham",
                    SecondName = "",
                    LastName = "Galan",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8299863571",
                    Email = "galanfidel@hotmail.com",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Claudio",
                    SecondName = "",
                    LastName = "Abreu",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "claudio_abreu@yahoo.com",
                    Age = 0,
                    Confirmed = false,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Luis",
                    SecondName = "",
                    LastName = "Batista",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8093504346",
                    Email = "luis.bolivar809@hotmail.com",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Noel",
                    SecondName = "",
                    LastName = "Ciprian",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "8097026797",
                    Email = "noelcp91@hotmail.com",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Jose",
                    SecondName = "Daniel",
                    LastName = "Jimenez",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "djdaniyo2001@hotmail.com",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Bernardo",
                    SecondName = "",
                    LastName = "Marte",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Carlos",
                    SecondName = "",
                    LastName = "De la Cruz",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "delacruz.carlos@gmail.com",
                    Age = 12,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Carlos",
                    SecondName = "Jose",
                    LastName = "Romero",
                    SecondLastName = "Pou",
                    Nickname = "",
                    Phone = "",
                    Email = "carlosblend@hotmail.com",
                    Age = 12,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
                },
                new Person {
                    FirstName = "Jose",
                    SecondName = "Luis",
                    LastName = "Aquino",
                    SecondLastName = "",
                    Nickname = "",
                    Phone = "",
                    Email = "jaquinosallent@gmail.com",
                    Age = 0,
                    Confirmed = true,
                    Payment = false,
                    Account = "",
                    TShirtID = 5,
                    TShirt = TBA,
                    Biography = "",
                    CategoryID = 10,
                    Category = NoCategory
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
