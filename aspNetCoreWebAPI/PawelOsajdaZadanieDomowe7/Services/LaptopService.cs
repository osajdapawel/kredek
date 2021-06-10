using AutoMapper;
using PawelOsajdaZadanieDomowe7.Models.Entities;
using PawelOsajdaZadanieDomowe7.Repositories.Interfaces;
using PawelOsajdaZadanieDomowe7.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Services
{
    /// <summary>
    /// Interfejs do serwisu obsługi dostaw
    /// </summary>
    public class LaptopService : ILaptopsService
    {
        // Zmienna repozytorium
        private readonly ILaptopsRepository _laptopsRepository;
        // Zmienna mappera
        private readonly IMapper _mapper;

        /// <summary>
        /// Konstruktor serwisu laptopów
        /// </summary>
        /// <param name="laptopsRepository"></param>
        /// <param name="mapper"></param>
        public LaptopService(ILaptopsRepository laptopsRepository, IMapper mapper)
        {
            _laptopsRepository = laptopsRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Metoda asynchroniczna zwracjająca listę LaptopDTO wszystkich laptopów
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LaptopDTO>> Get()
        {
            var laptops = await _laptopsRepository.GetLaptops();
            return _mapper.Map<IEnumerable<LaptopDTO>>(laptops);
        }

        /// <summary>
        /// Metoda asynchroniczna zwracająca LaptopDTO laptopa o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<LaptopDTO> Get(int id)
        {
            var laptop = await _laptopsRepository.Get(id);
            return _mapper.Map<LaptopDTO>(laptop);
        }

        /// <summary>
        /// Metoda asynchroniczna usuwająca laptop o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True jeśli usunięto laptop, false jeśli nie istnieje dany laptop</returns>
        public async Task<bool> Delete(int id)
        {
            return await _laptopsRepository.Delete(id); 
        }

        /// <summary>
        /// Metoda asynchroniczna dodająca laptop 
        /// </summary>
        /// <param name="laptop"></param>
        /// <returns></returns>
        public async Task Post(Laptop laptop)
        {
            await _laptopsRepository.AddLaptop(laptop);
        }

        /// <summary>
        /// Metoda updateująca laptop
        /// </summary>
        /// <param name="laptop"></param>
        /// <param name="id"></param>
        /// <returns>True jeśli edytowano laptop, false jeśli nie istnieje dany laptop</returns>
        public async Task<bool> Put(Laptop laptop, int id)
        {
            laptop.Id = id;
            return await _laptopsRepository.Update(laptop);
        }
    }
}
