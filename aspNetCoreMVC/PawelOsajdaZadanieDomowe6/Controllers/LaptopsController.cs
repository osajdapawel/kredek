using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PawelOsajdaZadanieDomowe6.Models;
using PawelOsajdaZadanieDomowe6.Models.Entities;
using PawelOsajdaZadanieDomowe6.Repositories;
using PawelOsajdaZadanieDomowe6.Repositories.Interfaces;

namespace PawelOsajdaZadanieDomowe6.Controllers
{
    /// <summary>
    /// Kontroler obsługujący laptopy
    /// </summary>
    public class LaptopsController : Controller
    {
        // Zmienna kontekstu bazy danych
        private readonly DataBaseContext _context;

        // Zmienna repozytorium
        private readonly ILaptopsRepository _laptopsRepository;

        /// <summary>
        /// Konstruktor kontrolera przypisujący zmiennym obsługi bazy danych odpowiednie wartości
        /// </summary>
        /// <param name="context"></param>
        /// <param name="laptopsRepository"></param>
        /// Wykorzystano tutaj repozytorium, ale tylko w jednej metodzie
        public LaptopsController(DataBaseContext context, ILaptopsRepository laptopsRepository)
        {
            _context = context;
            _laptopsRepository = laptopsRepository;
        }

        // GET: Laptops
        /// <summary>
        /// Metoda asynchoniczna obsługująca wyświetlenie widoku index listującego wszystkie laptopy
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            //var dataBaseContext = await _context.Laptops.Include(l => l.GraphicsCard).Include(l => l.Processor).ToListAsync();

            IEnumerable <Laptop> laptopsList =  await _laptopsRepository.GetLaptops();

            return View(laptopsList);

            //return View(await dataBaseContext.ToListAsync());
        }

        // GET: Laptops/Details/5
        /// <summary>
        /// Metoda asynchoniczna obsługująca wyświetlenie widoku szczegółów danego laptopa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptop = await _context.Laptops
                .Include(l => l.GraphicsCard)
                .Include(l => l.Processor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laptop == null)
            {
                return NotFound();
            }

            return View(laptop);
        }

        // GET: Laptops/Create
        /// <summary>
        /// Metoda asynchoniczna obsługująca wyświetlenie wyświetlenie widoku dodania nowego laptopa
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            ViewData["GraphicsCardId"] = new SelectList(_context.GraphicsCards, "Id", "Model");
            ViewData["ProcessorId"] = new SelectList(_context.Processors, "Id", "Model");
            return View();
        }

        // POST: Laptops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Metoda asynchoniczna obsługująca zapytanie typu post dodające laptopa do bazy
        /// </summary>
        /// <param name="laptop">Laptop do dodania</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProcessorId,GraphicsCardId,Model,Description,RamAmount,Quantity,Price")] Laptop laptop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laptop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GraphicsCardId"] = new SelectList(_context.GraphicsCards, "Id", "Model", laptop.GraphicsCardId);
            ViewData["ProcessorId"] = new SelectList(_context.Processors, "Id", "Model", laptop.ProcessorId);
            return View(laptop);
        }

        // GET: Laptops/Edit/5
        /// <summary>
        /// Metoda asynchoniczna obsługująca wyświetlenie obsługująca wyświetenie widoku edycji danego laptopa
        /// </summary>
        /// <param name="id">Id laptopa do edycji</param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptop = await _context.Laptops.FindAsync(id);
            if (laptop == null)
            {
                return NotFound();
            }
            ViewData["GraphicsCardId"] = new SelectList(_context.GraphicsCards, "Id", "Model", laptop.GraphicsCardId);
            ViewData["ProcessorId"] = new SelectList(_context.Processors, "Id", "Model", laptop.ProcessorId);
            return View(laptop);
        }

        // POST: Laptops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Metoda asynchoniczna obsługująca zapytanie typu post edytująca laptop w badzie danych
        /// </summary>
        /// <param name="id"></param>
        /// <param name="laptop"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProcessorId,GraphicsCardId,Model,Description,RamAmount,Quantity,Price")] Laptop laptop)
        {
            if (id != laptop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laptop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaptopExists(laptop.Id))
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
            ViewData["GraphicsCardId"] = new SelectList(_context.GraphicsCards, "Id", "Model", laptop.GraphicsCardId);
            ViewData["ProcessorId"] = new SelectList(_context.Processors, "Id", "Model", laptop.ProcessorId);
            return View(laptop);
        }

        // GET: Laptops/Delete/5
        /// <summary>
        /// Metoda asynchoniczna obsługująca zapytanie typu get zwracająca widok konkretnego laptopa do usunięcia
        /// </summary>
        /// <param name="id">Id laptopa do usunięcia dla którego zostanie wyświetlony widok okna potwierdznia</param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laptop = await _context.Laptops
                .Include(l => l.GraphicsCard)
                .Include(l => l.Processor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laptop == null)
            {
                return NotFound();
            }

            return View(laptop);
        }

        // POST: Laptops/Delete/5
        /// <summary>
        /// Metoda asynchoniczna obsługująca zapytanie typu post usuwające konkretny laptop z bazy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laptop = await _context.Laptops.FindAsync(id);
            _context.Laptops.Remove(laptop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        /// <summary>
        /// Funkkcja zwracjąca czy istnieje laptop o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool LaptopExists(int id)
        {
            return _context.Laptops.Any(e => e.Id == id);
        }
    }
}
