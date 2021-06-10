using PawelOsajdaZadanieDomowe6.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe6.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Deliveries
    /// </summary>
    public interface IDeliveriesRepository
    {
        /// <summary>
        /// Metoda asynchroniczna zwracająca dostawy
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Delivery>> GetDeliveries();

        /// <summary>
        /// Metoda asynchroniczna dodająca nową dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        Task AddDelivery(Delivery delivery);

        /// <summary>
        /// Metoda asynchroniczna usuwająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteDeliveryById(int id);
        
        /// <summary>
        /// Metoda asynchroniczna zwracająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task <Delivery> GetDeliveryById(int id);

        /// <summary>
        /// Metoda update'ująca dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        Task Update(Delivery delivery);
    }
}
