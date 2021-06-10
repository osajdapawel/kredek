using PawelOsajdaZadanieDomowe7.Models.Entities;
using PawelOsajdaZadanieDomowe7.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Services
{
    /// <summary>
    /// Interfejs definiujący metody związane z serwisem obsługi laptopów
    /// </summary>
    public interface ILaptopsService
    {
        /// <summary>
        /// Metoda asynchroniczna zwracająca wszystkie laptopy
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<LaptopDTO>> Get();

        /// <summary>
        /// Metoda asynchroniczna zwracająca laptop o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<LaptopDTO> Get(int id);

        /// <summary>
        /// Metoda asynchroniczna dodająca nowego laptopa
        /// </summary>
        /// <param name="laptop"></param>
        /// <returns></returns>
        Task Post(Laptop laptop);

        /// <summary>
        /// Metoda asynchroniczna usuwająca laptop o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(int id);

        /// <summary>
        /// Metoda update'ująca dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        Task<bool> Put(Laptop laptop, int id);
    }
}
