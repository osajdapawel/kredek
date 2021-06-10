using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawelOsajdaZadanieDomowe3.Models.Entities;
using PawelOsajdaZadanieDomowe3.Repositories.Interfaces;
using PawelOsajdaZadanieDomowe3.ViewModels;

namespace PawelOsajdaZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Laptops
    /// </summary>
    class LaptopsRepository : Repository,  ILaptopsRepository
    {
        /// <summary>
        /// Metoda odpowiadająca za zmniejszenie o podaną liczbę ilość sztuk laptopa o podanym Id
        /// </summary>
        /// <param name="laptopId">Id laptopa którego liczbę sztuk zmniejszamy</param>
        /// <param name="number">Liczba, o którą należy zmniejszyć liczbę sztuk laptopów</param>
        public void DecreaseLaptopNumber(int laptopId, int number)
        {
            Laptop laptop = DbContext.Laptops.SingleOrDefault(l => l.Id == laptopId);
            laptop.Quantity -= number;

            DbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda zwracająca ilość sztuk laptopa o danym Id
        /// </summary>
        /// <param name="laptopId"></param>
        /// <returns>-1 jeśli nie ma laptopa lub liczbę sztuk danego laptopa</returns>
        public int getLaptopQuantity(int laptopId)
        {
            return DbContext.Laptops.SingleOrDefault(l => l.Id == laptopId).Quantity;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie laptopy z tabeli Laptops wraz z danymi karty graficznej i procesora (osobne tabele)
        /// </summary>
        /// <returns>Data table z wynikiem zapytania - laptopy z danymi/returns>
        public List<LaptopViewModel> GetLaptopsViewModel()
        {
            List<Laptop> laptops = DbContext.Laptops.ToList();
            return Mapper.Map<List<Laptop>, List<LaptopViewModel>>(laptops);
        }
    }
}
