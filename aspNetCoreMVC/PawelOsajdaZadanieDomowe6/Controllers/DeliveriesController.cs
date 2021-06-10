using Microsoft.AspNetCore.Mvc;
using PawelOsajdaZadanieDomowe6.Models.Entities;
using PawelOsajdaZadanieDomowe6.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe6.Controllers
{
    /// <summary>
    /// Kontroler obsługujący dostawy
    /// </summary>
    public class DeliveriesController : Controller
    {
        // zmienna repozytorium
        private readonly IDeliveriesRepository _deliveriesRepository;

        /// <summary>
        /// Konstruktor kontrolera dostaw
        /// </summary>
        /// <param name="deliveriesRepository">Repozytorium dostaw podawane przez program</param>
        public DeliveriesController(IDeliveriesRepository deliveriesRepository)
        {
            _deliveriesRepository = deliveriesRepository;
        }

        /// <summary>
        /// Metoda asynchroniczna pobierająca dostawy i uruchamiająca widok dostaw
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            return View( await _deliveriesRepository.GetDeliveries());
        }

        /// <summary>
        /// Metoda uruchamiająca widok do tworzenia 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        /// <summary>
        /// Metoda asynchroniczna służąca do dodania dostawy
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        /// Używamy bindowania do modelu Delivery bez id 
        /// ponieważ SQL Serwer ma ustawione automatyczne dodawanie Id do Delivery
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Type,DeliveryTime,Price")] Delivery delivery) 
        {
            await _deliveriesRepository.AddDelivery(delivery);

            return RedirectToAction(nameof(Index));
        }
        
        /// <summary>
        /// Asynchroniczna metoda obsługująca usuwanie dostawy
        /// </summary>
        /// <param name="id">Id dosatwy do usuniecia</param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int id) 
        {
            await _deliveriesRepository.DeleteDeliveryById(id);

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Metoda asynchroniczna obsługująca edycję dostawy i przenosząca usera do panelu edycji
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Edit(int id)
        {
            var delivery = await _deliveriesRepository.GetDeliveryById(id);

            return View(delivery);
        }

        /// <summary>
        /// Metoda asynchroniczna edutująca dostawę w bazie danych 
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Edit([Bind("Id,Type,DeliveryTime,Price")] Delivery delivery)
        {
            await _deliveriesRepository.Update(delivery);

            return RedirectToAction(nameof(Index));
        }
    }
}
