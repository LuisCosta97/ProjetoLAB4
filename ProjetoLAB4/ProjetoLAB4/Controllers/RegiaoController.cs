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
    public class RegiaoController : Controller
    {
        private readonly ProjetoLAB4Context _context;

        public RegiaoController(ProjetoLAB4Context context)
        {
            _context = context;
        }

        // GET: Regiao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Regiao.ToListAsync());
        }

        // GET: Regiao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regiao = await _context.Regiao
                .FirstOrDefaultAsync(m => m.ID == id);
            if (regiao == null)
            {
                return NotFound();
            }

            return View(regiao);
        }

        // GET: Regiao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Regiao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,RegiaoNome")] Regiao regiao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(regiao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(regiao);
        }

        // GET: Regiao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regiao = await _context.Regiao.FindAsync(id);
            if (regiao == null)
            {
                return NotFound();
            }
            return View(regiao);
        }

        // POST: Regiao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,RegiaoNome")] Regiao regiao)
        {
            if (id != regiao.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(regiao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegiaoExists(regiao.ID))
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
            return View(regiao);
        }

        // GET: Regiao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regiao = await _context.Regiao
                .FirstOrDefaultAsync(m => m.ID == id);
            if (regiao == null)
            {
                return NotFound();
            }

            return View(regiao);
        }

        // POST: Regiao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var regiao = await _context.Regiao.FindAsync(id);
            _context.Regiao.Remove(regiao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegiaoExists(int id)
        {
            return _context.Regiao.Any(e => e.ID == id);
        }
    }
}
