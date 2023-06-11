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
    public class KorisniciController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KorisniciController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Korisnici
        public async Task<IActionResult> Index()
        {
            return View(await _context.Korisnici.ToListAsync());
        }

        // GET: Korisnici/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnici = await _context.Korisnici
                .FirstOrDefaultAsync(m => m.Id == id);
            if (korisnici == null)
            {
                return NotFound();
            }

            return View(korisnici);
        }

        // GET: Korisnici/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Korisnici/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ime,Prezime,Username,Slika")] Korisnici korisnici)
        {
            if (ModelState.IsValid)
            {
                _context.Add(korisnici);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(korisnici);
        }

        // GET: Korisnici/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnici = await _context.Korisnici.FindAsync(id);
            if (korisnici == null)
            {
                return NotFound();
            }
            return View(korisnici);
        }

        // POST: Korisnici/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ime,Prezime,Username,Slika")] Korisnici korisnici)
        {
            if (id != korisnici.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(korisnici);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KorisniciExists(korisnici.Id))
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
            return View(korisnici);
        }

        // GET: Korisnici/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnici = await _context.Korisnici
                .FirstOrDefaultAsync(m => m.Id == id);
            if (korisnici == null)
            {
                return NotFound();
            }

            return View(korisnici);
        }

        // POST: Korisnici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var korisnici = await _context.Korisnici.FindAsync(id);
            _context.Korisnici.Remove(korisnici);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KorisniciExists(int id)
        {
            return _context.Korisnici.Any(e => e.Id == id);
        }
    }
}
