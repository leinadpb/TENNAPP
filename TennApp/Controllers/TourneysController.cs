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
    public class TourneysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TourneysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tourneys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tourneys.ToListAsync());
        }

        // GET: Tourneys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourney = await _context.Tourneys
                .SingleOrDefaultAsync(m => m.TourneyID == id);
            if (tourney == null)
            {
                return NotFound();
            }

            return View(tourney);
        }

        // GET: Tourneys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tourneys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TourneyID,Name,Description,FechaInicio,FechaFin,Price")] Tourney tourney)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tourney);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tourney);
        }

        // GET: Tourneys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourney = await _context.Tourneys.SingleOrDefaultAsync(m => m.TourneyID == id);
            if (tourney == null)
            {
                return NotFound();
            }
            return View(tourney);
        }

        // POST: Tourneys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TourneyID,Name,Description,FechaInicio,FechaFin,Price")] Tourney tourney)
        {
            if (id != tourney.TourneyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tourney);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TourneyExists(tourney.TourneyID))
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
            return View(tourney);
        }

        // GET: Tourneys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tourney = await _context.Tourneys
                .SingleOrDefaultAsync(m => m.TourneyID == id);
            if (tourney == null)
            {
                return NotFound();
            }

            return View(tourney);
        }

        // POST: Tourneys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tourney = await _context.Tourneys.SingleOrDefaultAsync(m => m.TourneyID == id);
            _context.Tourneys.Remove(tourney);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TourneyExists(int id)
        {
            return _context.Tourneys.Any(e => e.TourneyID == id);
        }
    }
}
