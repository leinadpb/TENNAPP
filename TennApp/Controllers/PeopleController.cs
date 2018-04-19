using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TennApp.Data;
using TennApp.Models;

namespace TennApp.Controllers
{
    [Authorize]
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Persons.Include(p => p.Category).Include(p => p.TShirt).Include(p => p.Tourney);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons
                .Include(p => p.Category)
                .Include(p => p.TShirt)
                .Include(p => p.Tourney)
                .SingleOrDefaultAsync(m => m.PersonID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: People/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name");
            ViewData["TShirtID"] = new SelectList(_context.TShirts, "TShirtID", "Size");
            ViewData["TourneyID"] = new SelectList(_context.Tourneys, "TourneyID", "Name");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,FirstName,SecondName,LastName,SecondLastName,Nickname,Phone,Email,Age,Confirmed,Payment,Account,Biography,Cedula,TShirtID,CategoryID,TourneyID")] Person person, string user_sex)
        {
            if (ModelState.IsValid)
            {
                person.FullName = person.FirstName + " " + person.LastName; // Add fullname to person
                person.Sexo = user_sex;
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name", person.CategoryID);
            ViewData["TShirtID"] = new SelectList(_context.TShirts, "TShirtID", "Size", person.TShirtID);
            ViewData["TourneyID"] = new SelectList(_context.Tourneys, "TourneyID", "Name", person.TourneyID);
            return View(person);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons.SingleOrDefaultAsync(m => m.PersonID == id);
            if (person == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name", person.CategoryID);
            ViewData["TShirtID"] = new SelectList(_context.TShirts, "TShirtID", "Size", person.TShirtID);
            ViewData["TourneyID"] = new SelectList(_context.Tourneys, "TourneyID", "Name", person.TourneyID);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonID,FirstName,SecondName,LastName,SecondLastName,Nickname,Phone,Email,Age,Confirmed,Payment,Account,Biography,Cedula,TShirtID,CategoryID,TourneyID")] Person person, string sex)
        {
            if (id != person.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    person.Sexo = sex;
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.PersonID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories, "CategoryID", "Name", person.CategoryID);
            ViewData["TShirtID"] = new SelectList(_context.TShirts, "TShirtID", "Size", person.TShirtID);
            ViewData["TourneyID"] = new SelectList(_context.Tourneys, "TourneyID", "FechaFin", person.TourneyID);
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons
                .Include(p => p.Category)
                .Include(p => p.TShirt)
                .Include(p => p.Tourney)
                .SingleOrDefaultAsync(m => m.PersonID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Persons.SingleOrDefaultAsync(m => m.PersonID == id);
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.Persons.Any(e => e.PersonID == id);
        }
    }
}
