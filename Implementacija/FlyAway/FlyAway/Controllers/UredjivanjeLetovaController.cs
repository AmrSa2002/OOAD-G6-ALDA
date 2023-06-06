using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FlyAway.Data;
using FlyAway.Models;

namespace FlyAway.Controllers
{
    public class UredjivanjeLetovaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UredjivanjeLetovaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UredjivanjeLetova
        public async Task<IActionResult> Index()
        {
            return View(await _context.Let.ToListAsync());
        }

        // GET: UredjivanjeLetova/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @let = await _context.Let
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@let == null)
            {
                return NotFound();
            }

            return View(@let);
        }

        // GET: UredjivanjeLetova/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UredjivanjeLetova/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BrojAviona,BrojSlobodnihMjesta,Destinacija,Cijena,Vrijeme_Polijetanja,Vrijeme_Slijetanja,Datum_Polaska,TipLeta")] Let @let)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@let);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@let);
        }

        // GET: UredjivanjeLetova/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @let = await _context.Let.FindAsync(id);
            if (@let == null)
            {
                return NotFound();
            }
            return View(@let);
        }

        // POST: UredjivanjeLetova/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BrojAviona,BrojSlobodnihMjesta,Destinacija,Cijena,Vrijeme_Polijetanja,Vrijeme_Slijetanja,Datum_Polaska,TipLeta")] Let @let)
        {
            if (id != @let.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@let);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LetExists(@let.Id))
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
            return View(@let);
        }

        // GET: UredjivanjeLetova/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @let = await _context.Let
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@let == null)
            {
                return NotFound();
            }

            return View(@let);
        }

        // POST: UredjivanjeLetova/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @let = await _context.Let.FindAsync(id);
            _context.Let.Remove(@let);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LetExists(int id)
        {
            return _context.Let.Any(e => e.Id == id);
        }
    }
}
