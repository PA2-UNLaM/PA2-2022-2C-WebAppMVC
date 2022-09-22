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
    public class CotizarViajeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IProvinciasRepository _repository;


        public CotizarViajeController(AppDbContext context, IProvinciasRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        // GET: CotizarViaje
        public async Task<IActionResult> Index()
        {
              return View(await _context.Viajes.ToListAsync());
        }

        // GET: CotizarViaje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Viajes == null)
            {
                return NotFound();
            }

            var viajes = await _context.Viajes
                .FirstOrDefaultAsync(m => m.IdServicio == id);
            if (viajes == null)
            {
                return NotFound();
            }

            return View(viajes);
        }

        // GET: CotizarViaje/Create
        public async Task<IActionResult> CreateAsync()
        {
            var provinciasList = await _repository.ToListAsync();
            ViewData["ProvinciaOrigen"] = new SelectList(provinciasList, "Provincia", "NomProvincia");

            return View();
        }

        // POST: CotizarViaje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cliente,IdServicio,Vehiculo,Origen,Destino,Km,CantViajes")] Viajes viajes)
        {
            if (!ModelState.IsValid)
            {
                return View(viajes);
            }
            if (ModelState.IsValid)
            {
                _context.Add(viajes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viajes);
        }

        // GET: CotizarViaje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Viajes == null)
            {
                return NotFound();
            }

            var viajes = await _context.Viajes.FindAsync(id);
            if (viajes == null)
            {
                return NotFound();
            }
            return View(viajes);
        }

        // POST: CotizarViaje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Fecha,Cliente,IdServicio,Vehiculo,Origen,Destino,Km,CantViajes")] Viajes viajes)
        {
            if (id != viajes.IdServicio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viajes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViajesExists(viajes.IdServicio))
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
            return View(viajes);
        }

        // GET: CotizarViaje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Viajes == null)
            {
                return NotFound();
            }

            var viajes = await _context.Viajes
                .FirstOrDefaultAsync(m => m.IdServicio == id);
            if (viajes == null)
            {
                return NotFound();
            }

            return View(viajes);
        }

        // POST: CotizarViaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Viajes == null)
            {
                return Problem("Entity set 'AppDbContext.Viajes'  is null.");
            }
            var viajes = await _context.Viajes.FindAsync(id);
            if (viajes != null)
            {
                _context.Viajes.Remove(viajes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViajesExists(int id)
        {
          return _context.Viajes.Any(e => e.IdServicio == id);
        }
    }
}
