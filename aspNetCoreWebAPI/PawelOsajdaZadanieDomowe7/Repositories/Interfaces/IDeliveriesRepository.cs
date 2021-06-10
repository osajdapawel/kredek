using PawelOsajdaZadanieDomowe7.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Repositories.Interfaces
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
        Task<bool> DeleteDeliveryById(int id);
        
        /// <summary>
        /// Metoda asynchroniczna zwracająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task <Delivery> GetDeliveryById(int id);

        /// <summary>
        /// Metoda asynchroniczna update'ująca dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns>True - udało się zaktualizować, false - nie zautalizowano - nie ma takiej dostawy</returns>
        Task<bool> Update(Delivery delivery);
    }
}
