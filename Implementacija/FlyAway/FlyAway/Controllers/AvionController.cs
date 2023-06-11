using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlyAway.Data;
using FlyAway.Models;
using Microsoft.AspNetCore.Authorization;

namespace FlyAway.Controllers
{
    [Authorize]
    public class AvionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AvionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Avion
        public async Task<IActionResult> Index()
        {
            return View(await _context.Avion.ToListAsync());
        }

        // GET: Avion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (avion == null)
            {
                return NotFound();
            }

            return View(avion);
        }

        // GET: Avion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Avion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv")] Avion avion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(avion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(avion);
        }

        // GET: Avion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion.FindAsync(id);
            if (avion == null)
            {
                return NotFound();
            }
            return View(avion);
        }

        // POST: Avion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv")] Avion avion)
        {
            if (id != avion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvionExists(avion.Id))
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
            return View(avion);
        }

        // GET: Avion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (avion == null)
            {
                return NotFound();
            }

            return View(avion);
        }

        // POST: Avion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var avion = await _context.Avion.FindAsync(id);
            _context.Avion.Remove(avion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvionExists(int id)
        {
            return _context.Avion.Any(e => e.Id == id);
        }
    }
}
