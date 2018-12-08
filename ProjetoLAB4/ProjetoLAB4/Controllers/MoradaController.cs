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
    public class MoradaController : Controller
    {
        private readonly ProjetoLAB4Context _context;

        public MoradaController(ProjetoLAB4Context context)
        {
            _context = context;
        }

        // GET: Morada
        public async Task<IActionResult> Index()
        {
            return View(await _context.Morada.ToListAsync());
        }

        // GET: Morada/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morada = await _context.Morada
                .FirstOrDefaultAsync(m => m.ID_Morada == id);
            if (morada == null)
            {
                return NotFound();
            }

            return View(morada);
        }

        // GET: Morada/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Morada/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_Morada,Rua,Cidade,Codigo_Postal")] Morada morada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(morada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(morada);
        }

        // GET: Morada/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morada = await _context.Morada.FindAsync(id);
            if (morada == null)
            {
                return NotFound();
            }
            return View(morada);
        }

        // POST: Morada/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_Morada,Rua,Cidade,Codigo_Postal")] Morada morada)
        {
            if (id != morada.ID_Morada)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(morada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoradaExists(morada.ID_Morada))
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
            return View(morada);
        }

        // GET: Morada/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morada = await _context.Morada
                .FirstOrDefaultAsync(m => m.ID_Morada == id);
            if (morada == null)
            {
                return NotFound();
            }

            return View(morada);
        }

        // POST: Morada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var morada = await _context.Morada.FindAsync(id);
            _context.Morada.Remove(morada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoradaExists(int id)
        {
            return _context.Morada.Any(e => e.ID_Morada == id);
        }
    }
}
