using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PawelOsajdaZadanieDomowe7.Models.Entities;
using PawelOsajdaZadanieDomowe7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Controllers
{
    /// <summary>
    /// Kontroler laptopów
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LaptopsController : ControllerBase
    {
        // zmienna serwisu laptopów
        private readonly ILaptopsService _laptopsService;

        /// <summary>
        /// Konstruktor kontrolera laptopów
        /// </summary>
        /// <param name="laptopsService"></param>
        public LaptopsController(ILaptopsService laptopsService)
        {
            _laptopsService = laptopsService;
        }

        /// <summary>
        /// Zwraca wszystkie dostawy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var laptops = await _laptopsService.Get();
            return Ok(laptops);
        }

        /// <summary>
        /// Zwraca laptopa o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var laptop = await _laptopsService.Get(id);
            return Ok(laptop);
        }


        /// <summary>
        /// Dodaje nową dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Laptop laptop)
        {
            await _laptopsService.Post(laptop);
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
        public async Task<IActionResult> Put([FromBody] Laptop laptop, [FromRoute] int id)
        {
            if (await _laptopsService.Put(laptop, id))
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
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (await _laptopsService.Delete(id))
                return NoContent();
            else
                return NotFound();
        }
    }
}
