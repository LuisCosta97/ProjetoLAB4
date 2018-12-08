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
    public class AdministradorController : Controller
    {
        private readonly ProjetoLAB4Context _context;

        public AdministradorController(ProjetoLAB4Context context)
        {
            _context = context;
        }

        // GET: Administrador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Administrador.ToListAsync());
        }

        // GET: Administrador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrador = await _context.Administrador
                .FirstOrDefaultAsync(m => m.ID_Administrador == id);
            if (administrador == null)
            {
                return NotFound();
            }

            return View(administrador);
        }

        // GET: Administrador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Username,Password,Email,ID_Administrador")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(administrador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(administrador);
        }

        // GET: Administrador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrador = await _context.Administrador.FindAsync(id);
            if (administrador == null)
            {
                return NotFound();
            }
            return View(administrador);
        }

        // POST: Administrador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Username,Password,Email,ID_Administrador")] Administrador administrador)
        {
            if (id != administrador.ID_Administrador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(administrador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdministradorExists(administrador.ID_Administrador))
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
            return View(administrador);
        }

        // GET: Administrador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var administrador = await _context.Administrador
                .FirstOrDefaultAsync(m => m.ID_Administrador == id);
            if (administrador == null)
            {
                return NotFound();
            }

            return View(administrador);
        }

        // POST: Administrador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var administrador = await _context.Administrador.FindAsync(id);
            _context.Administrador.Remove(administrador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdministradorExists(int id)
        {
            return _context.Administrador.Any(e => e.ID_Administrador == id);
        }
    }
}
