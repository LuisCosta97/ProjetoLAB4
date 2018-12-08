using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoLAB4.Models;

namespace ProjetoLAB4.Controllers
{
    public class ProdutorController : Controller
    {
        private readonly ProjetoLAB4Context _context;

        public ProdutorController(ProjetoLAB4Context context)
        {
            _context = context;
        }

        // GET: Produtor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtor.ToListAsync());
        }

        // GET: Produtor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtor = await _context.Produtor
                .FirstOrDefaultAsync(m => m.ID == id);
            if (produtor == null)
            {
                return NotFound();
            }

            return View(produtor);
        }

        // GET: Produtor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProdutorNome")] Produtor produtor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtor);
        }

        // GET: Produtor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtor = await _context.Produtor.FindAsync(id);
            if (produtor == null)
            {
                return NotFound();
            }
            return View(produtor);
        }

        // POST: Produtor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProdutorNome")] Produtor produtor)
        {
            if (id != produtor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutorExists(produtor.ID))
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
            return View(produtor);
        }

        // GET: Produtor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtor = await _context.Produtor
                .FirstOrDefaultAsync(m => m.ID == id);
            if (produtor == null)
            {
                return NotFound();
            }

            return View(produtor);
        }

        // POST: Produtor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtor = await _context.Produtor.FindAsync(id);
            _context.Produtor.Remove(produtor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutorExists(int id)
        {
            return _context.Produtor.Any(e => e.ID == id);
        }
    }
}
