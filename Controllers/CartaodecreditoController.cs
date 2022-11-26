#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pagamento.Models;

namespace pagamento.Controllers
{
    public class CartaodecreditoController : Controller
    {
        private readonly MyDbContext _context;

        public CartaodecreditoController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Cartaodecredito
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cartaodecredito.ToListAsync());
        }

        // GET: Cartaodecredito/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaodecredito = await _context.Cartaodecredito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartaodecredito == null)
            {
                return NotFound();
            }

            return View(cartaodecredito);
        }

        // GET: Cartaodecredito/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cartaodecredito/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero,Parcelas,Valor,Status")] Cartaodecredito cartaodecredito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartaodecredito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartaodecredito);
        }

        // GET: Cartaodecredito/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaodecredito = await _context.Cartaodecredito.FindAsync(id);
            if (cartaodecredito == null)
            {
                return NotFound();
            }
            return View(cartaodecredito);
        }

        // POST: Cartaodecredito/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero,Parcelas,Valor,Status")] Cartaodecredito cartaodecredito)
        {
            if (id != cartaodecredito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartaodecredito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartaodecreditoExists(cartaodecredito.Id))
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
            return View(cartaodecredito);
        }

        // GET: Cartaodecredito/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaodecredito = await _context.Cartaodecredito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartaodecredito == null)
            {
                return NotFound();
            }

            return View(cartaodecredito);
        }

        // POST: Cartaodecredito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartaodecredito = await _context.Cartaodecredito.FindAsync(id);
            _context.Cartaodecredito.Remove(cartaodecredito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartaodecreditoExists(int id)
        {
            return _context.Cartaodecredito.Any(e => e.Id == id);
        }
    }
}
