using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PawelOsajdaZadanieDomowe6.Models;
using PawelOsajdaZadanieDomowe6.Models.Entities;

namespace PawelOsajdaZadanieDomowe6.Controllers
{
    /// <summary>
    /// Kontroler obsługujący zamówienia
    /// </summary>
    public class OrdersController : Controller
    {
        // Zmienna przechowowująca kontekst bazy danych
        private readonly DataBaseContext _context;

        /// <summary>
        /// Konstruktor kontrolera
        /// </summary>
        /// <param name="context"></param>
        public OrdersController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Orders
        /// <summary>
        /// Metoda asynchroniczna obsługująca pobranie wszystkich zamówień wraz z informacjami o dostawach i danych użytkownia oraz wywołująca widok z tymi danymi
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            var dataBaseContext = _context.Orders.Include(o => o.Delivery).Include(o => o.UserInformations);
            return View(await dataBaseContext.ToListAsync());
        }

        // GET: Orders/Details/5
        /// <summary>
        /// Metoda asynchroniczna obsługująca pobranie danych oraz wywołanie widoku szczegółów danego laptopa  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Delivery)
                .Include(o => o.UserInformations)
                .Include(o => o.Suborders).ThenInclude(sub => sub.Laptop) // include pobiera obiekt połączony zależnością do danego obiektu, ThenInclude pobiera obiekt połączony do obiektu połączonego
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Edit/5
        /// <summary>
        /// Metoda asynchroniczna obsługująca funkcjonalność wyświetlenia konkretnego laptopa do edycji
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["DeliveryId"] = new SelectList(_context.Deliveries, "Id", "Type", order.DeliveryId);
            ViewData["UserInformationsId"] = new SelectList(_context.UserInformations, "Id", "Address", order.UserInformationsId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Metoda asynchroniczna obsługująca wyświetlnie widoku edycji zamówienia oraz przekazanie danch do tego widoku
        /// </summary>
        /// <param name="id"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserInformationsId,DeliveryId,Status")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
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
            ViewData["DeliveryId"] = new SelectList(_context.Deliveries, "Id", "Type", order.DeliveryId);
            ViewData["UserInformationsId"] = new SelectList(_context.UserInformations, "Id", "Address", order.UserInformationsId);
            return View(order);
        }

        // GET: Orders/Delete/5
        /// <summary>
        /// Metoda asynchroniczna obsługująca wyświetlenie widoku szczegółów zamówienia do usunięcia 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.Delivery)
                .Include(o => o.UserInformations)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        /// <summary>
        /// Metoda asynchroniczna obsługująca usunięcie z bazy danych zamówienia po uprzednim usunięciu podzamówień dla danego zamówienia
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        { 
            // najpierw trzeba usunć podzamówienia danego zamówienia
            // jest to konieczne ponieważ w bazie nie mogą istnieć 
            // podzamówienia bez odpowiadającego im zamówienia
            List<Suborder> subordersToDelete = await _context.Suborders.Where(p => p.OrderId == id).ToListAsync();
            _context.Suborders.RemoveRange(subordersToDelete);

            // znajduje po kluczu głównym
            var order = await _context.Orders.FindAsync(id);
            // usuwa wcześniej znalezione 
            _context.Orders.Remove(order);
            //zapis zmian
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Metoda zwracająca informacje czy istnieje dane zamówienie
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
