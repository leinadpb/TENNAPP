using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TennApp.Data;
using TennApp.Models;
using TennApp.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace TennApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        //Dashboard View Model
        private DashboardViewModel _dashboardVM;
        private SearchViewModel _searchVM;

        public AdminController(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult SetSex()
        {
            ViewData["Users"] = new SelectList(_context.Persons.Where(p => p.Sexo == null), "PersonID", "FirstName");
            return View();
        }
        [HttpPost]
        public IActionResult SetSex(string sex, string user)
        {
            var person = _context.Persons.Where(p => p.PersonID == Int32.Parse(user)).FirstOrDefault();
            person.Sexo = sex.ToUpper();
            _context.SaveChanges();
            ViewData["Users"] = new SelectList(_context.Persons.Where(p => p.Sexo == null), "PersonID", "FirstName");
            return View();
        }

        [Authorize]
        public IActionResult Dashboard()
        {
            _dashboardVM = new DashboardViewModel();
            int TotalUsers = _context.Persons.ToList().Count();
            int TotalCategories = _context.Categories.ToList().Count();
            int TotalYoungUsers = _context.Persons.Where(p => p.Age != 0 && p.Age >= 12 && p.Age <= 19).ToList().Count();
            int TotalAdultUsers = _context.Persons.Where(p => p.Age != 0 && p.Age >= 20 && p.Age <= 39).ToList().Count();
            int TotalOldUsers = _context.Persons.Where(p => p.Age != 0 && p.Age >= 40 && p.Age <= 120).ToList().Count();
            int TotalMen = _context.Persons.Where(p => p.Sexo.Equals("M")).ToList().Count;
            int TotalWoman = _context.Persons.Where(p => p.Sexo.Equals("F")).ToList().Count;
            _dashboardVM.TotalUsers = TotalUsers;
            _dashboardVM.TotalCategories = TotalCategories;
            _dashboardVM.YoungUsers = TotalYoungUsers;
            _dashboardVM.AdultUsers = TotalAdultUsers;
            _dashboardVM.OldUsers = TotalOldUsers;
            _dashboardVM.TotalMen = TotalMen;
            _dashboardVM.TotalWomen = TotalWoman;
            return View(_dashboardVM);
        }

        [HttpGet]
        public IActionResult Search()
        {
            _searchVM = new SearchViewModel();
            _searchVM.Tshirts = _context.TShirts.ToList();
            return View(_searchVM);
        }
        [HttpGet]
        public async Task<IActionResult> SearchBy(String searchString, bool payed, bool confirmed, int? tshirt)
        {
            List<PersonWithTShirt> data; //Result set

            var query = from person in _context.Persons
                        join tshirts in _context.TShirts on person.TShirtID equals tshirts.TShirtID
                        select new PersonWithTShirt
                        {
                            ID = person.PersonID,
                            FirstName = person.FirstName,
                            SecondName = person.SecondName,
                            LastName = person.LastName,
                            SecondLastName = person.SecondLastName,
                            Phone = person.Phone,
                            Email = person.Email,
                            Account = person.Account,
                            Age = person.Age,
                            Confirmed = person.Confirmed,
                            Payment = person.Payment,
                            Biography = person.Biography,
                            Nickname = person.Nickname,
                            tshirtSize = tshirts.Size,
                            tshirtID = tshirts.TShirtID
                        };
            if (searchString != null)
            {
                query = query.Where(p => p.FirstName.Contains(searchString) || p.SecondName.Contains(searchString) || p.LastName.Contains(searchString) || p.SecondLastName.Contains(searchString));
                if (payed)
                {
                    query = query.Where(p => p.Payment == true);
                }
                if (confirmed)
                {
                    query = query.Where(p => p.Confirmed == true);
                }
                if(tshirt != null)
                {
                    if(tshirt != 5)
                    {
                        query = query.Where(p => p.tshirtID == tshirt);
                    }
                }
            }
            else
            {
                if (payed)
                {
                    query = query.Where(p => p.Payment == true);
                }
                if (confirmed)
                {
                    query = query.Where(p => p.Confirmed == true);
                }
                if (tshirt != null)
                {
                    if (tshirt != 5)
                    {
                        query = query.Where(p => p.tshirtID == tshirt);
                    }
                }
            }
            data = await query.ToListAsync();

            return View("Search", new SearchViewModel {
                People = data,
                Tshirts = _context.TShirts.ToList(),
                ResultQuantity = data.Count()
            });
        }
        [HttpGet]
        public async Task<IActionResult> Reports()
        {
            var availableReports = await _context.ReportTypes.ToListAsync();

            return View(new ReportsViewModel { Reports = availableReports });
        }
        [HttpPost]
        public async Task<IActionResult> Reports(String reportType)
        {
            //Reports definitions
            List<PersonsByCategory> dataGeneralReport = new List<PersonsByCategory>();
            List<PersonsByTourney> PersonsByTourney_Report = new List<PersonsByTourney>();


            //Choose the report type
            if (reportType.Equals("TENN001")) //Elaborar un reporte general
            {
                /**
                 * Mostrar todos los usuarios (con toda su información) por categoría.
                 * **/
                var query = _context.Categories
                    .Include(c => c.Persons)
                    .ToList();
                PersonsByCategory personByCategory;
                foreach(var category in query)
                {
                    personByCategory = new PersonsByCategory();
                    personByCategory.Category = category;
                    List<PersonWithTShirt> tempPersons = new List<PersonWithTShirt>();
                    personByCategory.PersonsQuantity = category.Persons.ToList().Count();
                    foreach(var p in category.Persons)
                    {
                        TShirt tempTShirt = await _context.TShirts.Where(ts => ts.TShirtID == p.TShirtID).SingleOrDefaultAsync();
                        tempPersons.Add(new PersonWithTShirt {
                            Account = p.Account,
                            FirstName = p.FirstName,
                            SecondLastName = p.SecondLastName,
                            SecondName = p.SecondName,
                            LastName = p.LastName,
                            Email = p.Email,
                            Phone = p.Phone,
                            Age = p.Age,
                            Confirmed = p.Confirmed,
                            Payment = p.Payment,
                            Biography = p.Biography,
                            tshirtSize = tempTShirt.Size,
                            tshirtID = tempTShirt.TShirtID
                        });
                    }
                    personByCategory.Persons = tempPersons;
                    dataGeneralReport.Add(personByCategory);

                }
                
            }
            else if (reportType.Equals("TENN002"))
            {
                var query = _context.Tourneys
                    .Include(t => t.Persons);
                List<Person> tempPerson;
                PersonsByTourney tmp;
                foreach(var report in await query.ToListAsync())
                {
                    tmp = new PersonsByTourney();
                    tmp.Tourney = report;
                    tempPerson = new List<Person>();
                    tmp.PersonsQuantity = report.Persons.ToList().Count();
                    foreach(var person in report.Persons)
                    {
                        tempPerson.Add(person);
                    }
                    tmp.Persons = tempPerson;
                    PersonsByTourney_Report.Add(tmp);
                }
            }
            var availableReports = await _context.ReportTypes.ToListAsync();
            return View(new ReportsViewModel {
                GeneralReport = dataGeneralReport,
                Reports = availableReports,
                PersonsByTourney = PersonsByTourney_Report
            });
        }
        public IActionResult Bills()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Payment()
        {
            var selectUsers = new SelectList(_context.Persons, "PersonID", "FullName");
            var selectTourneys = new SelectList(_context.Tourneys, "TourneyID", "Name");
            var selectPayment = new SelectList(_context.PaymentMethods, "PaymentMethodID", "Name");
            return View(new BillViewModel { Users = selectUsers,
                Tourneys = selectTourneys,
                Payments = selectPayment
            });
        }

        [HttpPost]
        public IActionResult RegisterPayment(String user_cedula, String tourney_id, String payment_id, String bill_mount)
        {
            var user = _context.Persons.Where(p => p.Cedula.Equals(user_cedula)).FirstOrDefault();
            var tourney = _context.Tourneys.Where(t => t.TourneyID == Int32.Parse(tourney_id)).FirstOrDefault();
            var paymentMethod = _context.PaymentMethods.Where(pm => pm.PaymentMethodID == Int32.Parse(payment_id)).FirstOrDefault();
            user.Payment = true;
            user.TourneyID = Int32.Parse(tourney_id);
            user.Tourney = tourney;
            _context.SaveChanges();
            //Create a new Bill
            var bills = _context.Bills.ToList();
            Bill bill = new Bill() {
                Mount = Double.Parse(bill_mount),
                Code = "TENN000" + (bills.Count + 1).ToString(),
                Person = user,
                PersonID = user.PersonID,
                PaymentMethodID = paymentMethod.PaymentMethodID,
                PaymentMethod = paymentMethod
            };
            _context.Bills.Add(bill);
            _context.SaveChanges();
            return RedirectToAction("Payment");
        }
        [HttpGet]
        public JsonResult GetUser(string user_cedula)
        {
            var user = _context.Persons.Where(p => p.Cedula.Equals(user_cedula)).FirstOrDefault();
            return Json(user);
        }

        [HttpPost]
        public async Task<IActionResult> Payment(string asd)
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetTorneo(string _id)
        {
            int id = Int32.Parse(_id);
            Tourney torneo = _context.Tourneys.Where(t => t.TourneyID == id).FirstOrDefault();
            return Json(torneo);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}