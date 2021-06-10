using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Laptop
    /// </summary>
    interface ILaptopsRepository
    {
        /// <summary>
        /// Metoda zwracająca wszystkie laptopy z tabeli Laptops wraz z danymi karty graficznej i procesora z osobnych tabel
        /// </summary>
        /// <returns></returns>
        DataTable GetLaptops();

        /// <summary>
        /// Metoda odpowiadająca za zmniejszenie o podaną liczbę ilość sztuk laptopa o podanym Id
        /// </summary>
        /// <param name="laptopId">Id laptopa którego liczbę sztuk zmniejszamy</param>
        /// <param name="number">Liczba, o którą należy zmniejszyć liczbę sztuk laptopów </param>
        void DecreaseLaptopNumber(int laptopId, int number);

        /// <summary>
        /// Metoda zwracająca liczbę sztuk danego laptopa 
        /// </summary>
        /// <param name="laptopId"></param>
        /// <returns></returns>
        int getLaptopQuantity(int laptopId);        
    }
}
