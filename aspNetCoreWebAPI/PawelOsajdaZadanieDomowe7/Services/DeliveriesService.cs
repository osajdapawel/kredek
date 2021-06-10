using PawelOsajdaZadanieDomowe7.Models.Entities;
using PawelOsajdaZadanieDomowe7.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Services
{
    /// <summary>
    /// Serwis do obsługi dostaw
    /// </summary>
    public class DeliveriesService : IDeliveriesService
    {
        // zmienna repozytorium
        private readonly IDeliveriesRepository _deliveriesRepository;

        /// <summary>
        /// Konstruktor repozytorium
        /// </summary>
        /// <param name="deliveriesRepository"></param>
        public DeliveriesService(IDeliveriesRepository deliveriesRepository)
        {
            _deliveriesRepository = deliveriesRepository;
        }

        /// <summary>
        /// Metoda asynchroniczna zwracajaca listę dostaw
        /// </summary>
        /// <returns>Lista LaptopDTO</returns>
        public async Task<IEnumerable<Delivery>> Get()
            => await _deliveriesRepository.GetDeliveries();

        /// <summary>
        /// Metoda asynchroniczna zwracajaca dostawę o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>LaptopDTO</returns>
        public async Task<Delivery> Get(int id)
            => await _deliveriesRepository.GetDeliveryById(id);

        /// <summary>
        /// Metoda asynchroniczna dodająca dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        public async Task Post(Delivery delivery)
        {
            await _deliveriesRepository.AddDelivery(delivery);
        }

        /// <summary>
        /// Metoda asynchroniczna edytująca dostawę o podanym id
        /// </summary>
        /// <param name="delivery"></param>
        /// <param name="id"></param>
        /// <returns>True - udało się zaktualizować, false - nie zautalizowano - nie ma takiej dostawy</returns>
        public async Task<bool> Put(Delivery delivery, int id)
        {
            delivery.Id = id;
            return await _deliveriesRepository.Update(delivery);
        }

        /// <summary>
        /// Metoda asynchroniczna usuwająca dostawę o podanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True - udało się usunąć, false - nie usunięto - nie ma takiej dostawy</returns>
        public async Task<bool> Delete(int id)
        {
            return await _deliveriesRepository.DeleteDeliveryById(id);
        }
    }
}
