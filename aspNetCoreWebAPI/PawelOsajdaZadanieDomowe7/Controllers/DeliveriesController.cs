using Microsoft.AspNetCore.Mvc;
using PawelOsajdaZadanieDomowe7.Models.Entities;
using PawelOsajdaZadanieDomowe7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PawelOsajdaZadanieDomowe7.Controllers
{
    /// <summary>
    /// Kontroler dostaw
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        // zmienna serwisu dostaw
        private readonly IDeliveriesService _deliveriesService;

        /// <summary>
        /// Konstruktor kontrolera dostaw
        /// </summary>
        /// <param name="deliveriesService"></param>
        public DeliveriesController(IDeliveriesService deliveriesService)
        {
            _deliveriesService = deliveriesService;
        }

        /// <summary>
        /// Zwraca wszystkie dostawy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var deliveries = await _deliveriesService.Get();
            return Ok(deliveries);
        }

        /// <summary>
        /// Zwraca dostawę o konkretnym id
        /// </summary>
        /// <param name="id">ID dostawy do wyświetlenia</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var deliveries = await _deliveriesService.Get(id);
            return Ok(deliveries);
        }

        /// <summary>
        /// Dodaje nową dostawę
        /// </summary>
        /// <param name="delivery">Dostawa do dodania</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Delivery delivery)
        {
            await _deliveriesService.Post(delivery);
            return Ok();
        }

        /// <summary>
        /// Edytuje dostawę o wskazanym Id 
        /// </summary>
        /// <param name="delivery"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put([FromBody]Delivery delivery, [FromRoute]int id)
        {
            if (await _deliveriesService.Put(delivery, id))
                return Ok();
            else
                return NotFound();
        }

        /// <summary>
        /// Usuwa dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            if (await _deliveriesService.Delete(id))
                return NoContent();
            else
                return NotFound();
        }
    }
}
