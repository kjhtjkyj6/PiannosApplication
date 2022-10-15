using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PiannosApplication.Data;
using PiannosApplication.Models;

namespace PiannosApplication.Controllers
{
    public class PiannosController : Controller
    {
        private readonly PiannosApplicationContext _context;

        public PiannosController(PiannosApplicationContext context)
        {
            _context = context;
        }

        // GET: Piannos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Piannos.ToListAsync());
        }

        // GET: Piannos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var piannos = await _context.Piannos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (piannos == null)
            {
                return NotFound();
            }

            return View(piannos);
        }

        // GET: Piannos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Piannos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Company,Type,Color,Price,WireType,CustomerReview")] Piannos piannos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(piannos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(piannos);
        }

        // GET: Piannos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var piannos = await _context.Piannos.FindAsync(id);
            if (piannos == null)
            {
                return NotFound();
            }
            return View(piannos);
        }

        // POST: Piannos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company,Type,Color,Price,WireType,CustomerReview")] Piannos piannos)
        {
            if (id != piannos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(piannos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PiannosExists(piannos.Id))
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
            return View(piannos);
        }

        // GET: Piannos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var piannos = await _context.Piannos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (piannos == null)
            {
                return NotFound();
            }

            return View(piannos);
        }

        // POST: Piannos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var piannos = await _context.Piannos.FindAsync(id);
            _context.Piannos.Remove(piannos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PiannosExists(int id)
        {
            return _context.Piannos.Any(e => e.Id == id);
        }
    }
}
