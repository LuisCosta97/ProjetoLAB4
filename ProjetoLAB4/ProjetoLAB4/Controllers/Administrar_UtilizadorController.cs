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
    public class Administrar_UtilizadorController : Controller
    {
        private readonly ProjetoLAB4Context _context;

        public Administrar_UtilizadorController(ProjetoLAB4Context context)
        {
            _context = context;
        }

        // GET: Administrar_Utilizador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Administrar_Utilizador.ToListAsync());
        }

        // GET: Administrar_Utilizador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrar_Utilizador = await _context.Administrar_Utilizador
                .FirstOrDefaultAsync(m => m.ID_Adminstrar_Utilizador == id);
            if (administrar_Utilizador == null)
            {
                return NotFound();
            }

            return View(administrar_Utilizador);
        }

        // GET: Administrar_Utilizador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrar_Utilizador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_Adminstrar_Utilizador,ID_Administrador,ID_Utilizadorr,Motivo,data_inicio,data_fim,Estado")] Administrar_Utilizador administrar_Utilizador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(administrar_Utilizador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(administrar_Utilizador);
        }

        // GET: Administrar_Utilizador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrar_Utilizador = await _context.Administrar_Utilizador.FindAsync(id);
            if (administrar_Utilizador == null)
            {
                return NotFound();
            }
            return View(administrar_Utilizador);
        }

        // POST: Administrar_Utilizador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_Adminstrar_Utilizador,ID_Administrador,ID_Utilizadorr,Motivo,data_inicio,data_fim,Estado")] Administrar_Utilizador administrar_Utilizador)
        {
            if (id != administrar_Utilizador.ID_Adminstrar_Utilizador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(administrar_Utilizador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Administrar_UtilizadorExists(administrar_Utilizador.ID_Adminstrar_Utilizador))
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
            return View(administrar_Utilizador);
        }

        // GET: Administrar_Utilizador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrar_Utilizador = await _context.Administrar_Utilizador
                .FirstOrDefaultAsync(m => m.ID_Adminstrar_Utilizador == id);
            if (administrar_Utilizador == null)
            {
                return NotFound();
            }

            return View(administrar_Utilizador);
        }

        // POST: Administrar_Utilizador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var administrar_Utilizador = await _context.Administrar_Utilizador.FindAsync(id);
            _context.Administrar_Utilizador.Remove(administrar_Utilizador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Administrar_UtilizadorExists(int id)
        {
            return _context.Administrar_Utilizador.Any(e => e.ID_Adminstrar_Utilizador == id);
        }
    }
}
