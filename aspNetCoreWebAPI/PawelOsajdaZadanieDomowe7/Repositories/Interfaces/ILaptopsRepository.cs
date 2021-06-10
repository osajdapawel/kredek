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
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Laptop - częściowa komunikacja
    /// </summary>
    public interface ILaptopsRepository
    {

        /// <summary>
        /// Metoda asynchroniczna zwracająca laptopy
        /// </summary>
        /// <returns>Lista laptopów</returns>
        Task <IEnumerable<Laptop> > GetLaptops();

        /// <summary>
        /// Metoda asynchroniczna zwracająca laptop o konkretnym id
        /// </summary>
        /// <param name="id">Id laptopa do wyświetlenia</param>
        /// <returns>Laptop o konkretnym id</returns>
        Task<Laptop> Get(int id);

        /// <summary>
        /// Metoda asynchroniczna dodająca laptop
        /// </summary>
        /// <param name="laptop"></param>
        /// <returns></returns>
        Task AddLaptop(Laptop laptop);

        /// <summary>
        /// Metoda asynchroniczna usuwająca laptop o konkretnym id
        /// </summary>
        /// <param name="id">Id laptopa do usunięcia</param>
        /// <returns>True jeśli usunięto obiekt, False jeśli nie ma takiego obiektu - nie usunięto laptopa</returns>
        Task<bool> Delete(int id);

        /// <summary>
        /// Metoda edytująca laptop
        /// </summary>
        /// <param name="laptop"></param>
        /// <returns>True jeśli edytowano obiekt, False jeśli nie ma takiego obiektu - nie edytowano laptopa</returns>
        Task<bool> Update(Laptop laptop);

 
    }
}
