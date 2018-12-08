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
    public class VinhoController : Controller
    {
        private readonly ProjetoLAB4Context _context;

        public VinhoController(ProjetoLAB4Context context)
        {
            _context = context;
        }

        // GET: Vinho
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vinho.ToListAsync());
        }

        // GET: Vinho/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vinho = await _context.Vinho
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vinho == null)
            {
                return NotFound();
            }

            return View(vinho);
        }

        // GET: Vinho/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vinho/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,ID_Regiao,ID_Tipo,ID_Produtor,Teor_Alcoolico,Caminho_Fotografia,Ano,Categoria")] Vinho vinho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vinho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vinho);
        }

        // GET: Vinho/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vinho = await _context.Vinho.FindAsync(id);
            if (vinho == null)
            {
                return NotFound();
            }
            return View(vinho);
        }

        // POST: Vinho/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,ID_Regiao,ID_Tipo,ID_Produtor,Teor_Alcoolico,Caminho_Fotografia,Ano,Categoria")] Vinho vinho)
        {
            if (id != vinho.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vinho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VinhoExists(vinho.ID))
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
            return View(vinho);
        }

        // GET: Vinho/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vinho = await _context.Vinho
                .FirstOrDefaultAsync(m => m.ID == id);
            if (vinho == null)
            {
                return NotFound();
            }

            return View(vinho);
        }

        // POST: Vinho/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vinho = await _context.Vinho.FindAsync(id);
            _context.Vinho.Remove(vinho);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VinhoExists(int id)
        {
            return _context.Vinho.Any(e => e.ID == id);
        }
    }
}
