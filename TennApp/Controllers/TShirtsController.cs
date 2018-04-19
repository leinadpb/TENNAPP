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
    public class TShirtsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TShirtsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TShirts
        public async Task<IActionResult> Index()
        {
            return View(await _context.TShirts.ToListAsync());
        }

        // GET: TShirts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tShirt = await _context.TShirts
                .SingleOrDefaultAsync(m => m.TShirtID == id);
            if (tShirt == null)
            {
                return NotFound();
            }

            return View(tShirt);
        }

        // GET: TShirts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TShirts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TShirtID,Size")] TShirt tShirt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tShirt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tShirt);
        }

        // GET: TShirts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tShirt = await _context.TShirts.SingleOrDefaultAsync(m => m.TShirtID == id);
            if (tShirt == null)
            {
                return NotFound();
            }
            return View(tShirt);
        }

        // POST: TShirts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TShirtID,Size")] TShirt tShirt)
        {
            if (id != tShirt.TShirtID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tShirt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TShirtExists(tShirt.TShirtID))
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
            return View(tShirt);
        }

        // GET: TShirts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tShirt = await _context.TShirts
                .SingleOrDefaultAsync(m => m.TShirtID == id);
            if (tShirt == null)
            {
                return NotFound();
            }

            return View(tShirt);
        }

        // POST: TShirts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tShirt = await _context.TShirts.SingleOrDefaultAsync(m => m.TShirtID == id);
            _context.TShirts.Remove(tShirt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TShirtExists(int id)
        {
            return _context.TShirts.Any(e => e.TShirtID == id);
        }
    }
}
