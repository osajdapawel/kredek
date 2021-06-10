using PawelOsajdaZadanieDomowe7.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Services
{
    /// <summary>
    /// Interfejs definiujący metody związane z serwisem dostaw
    /// </summary>
    public interface IDeliveriesService
    {
        /// <summary>
        /// Metoda asynchroniczna zwracająca dostawy
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Delivery>> Get();

        /// <summary>
        /// Metoda asynchroniczna dodająca nową dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        Task Post(Delivery delivery);

        /// <summary>
        /// Metoda asynchroniczna usuwająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(int id);

        /// <summary>
        /// Metoda asynchroniczna zwracająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Delivery> Get(int id);

        /// <summary>
        /// Metoda update'ująca dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        Task<bool> Put(Delivery delivery, int id);
    }
}
