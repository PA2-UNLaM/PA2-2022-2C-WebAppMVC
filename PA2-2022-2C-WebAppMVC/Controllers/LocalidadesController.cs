using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PA2_2022_2C_WebAppMVC.Data;
using PA2_2022_2C_WebAppMVC.Models;

namespace PA2_2022_2C_WebAppMVC.Controllers
{
    public class LocalidadesController : Controller
    {
        private readonly PA2_2022_2C_WebAppMVCContext _context;

        public LocalidadesController(PA2_2022_2C_WebAppMVCContext context)
        {
            _context = context;
        }

        // GET: Localidades
        public async Task<IActionResult> Index()
        {
              return View(await _context.Localidades.ToListAsync());
        }

        // GET: Localidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Localidades == null)
            {
                return NotFound();
            }

            var localidades = await _context.Localidades
                .FirstOrDefaultAsync(m => m.Localidad == id);
            if (localidades == null)
            {
                return NotFound();
            }

            return View(localidades);
        }

        // GET: Localidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Localidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Provincia,Localidad,NomLoc,Ciudad,NomCiudad")] Localidades localidades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localidades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(localidades);
        }

        // GET: Localidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Localidades == null)
            {
                return NotFound();
            }

            var localidades = await _context.Localidades.FindAsync(id);
            if (localidades == null)
            {
                return NotFound();
            }
            return View(localidades);
        }

        // POST: Localidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Provincia,Localidad,NomLoc,Ciudad,NomCiudad")] Localidades localidades)
        {
            if (id != localidades.Localidad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localidades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalidadesExists(localidades.Localidad))
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
            return View(localidades);
        }

        // GET: Localidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Localidades == null)
            {
                return NotFound();
            }

            var localidades = await _context.Localidades
                .FirstOrDefaultAsync(m => m.Localidad == id);
            if (localidades == null)
            {
                return NotFound();
            }

            return View(localidades);
        }

        // POST: Localidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Localidades == null)
            {
                return Problem("Entity set 'PA2_2022_2C_WebAppMVCContext.Localidades'  is null.");
            }
            var localidades = await _context.Localidades.FindAsync(id);
            if (localidades != null)
            {
                _context.Localidades.Remove(localidades);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalidadesExists(int id)
        {
          return _context.Localidades.Any(e => e.Localidad == id);
        }
    }
}
