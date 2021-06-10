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
    /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Suborders
    /// </summary>
    class SubordersRepository : Repository, ISubordersRepository
    {
        /// <summary>
        /// Metoda tworząca podzapytanie. Należy pamiętać aby zmniejszyć liczbę laptopów
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="laptopId"></param>
        /// <param name="quantity"></param>
        public void CreateSuborder(int orderId, int laptopId, int quantity)
        {
            Suborder suborderToCreate = new Suborder()
            {
                OrderId = orderId,
                LaptopId = laptopId,
                Quantity = quantity
            };

            DbContext.Suborders.Add(suborderToCreate);
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda zwracająca podzamówienia dla zamówenia, którego Id jest równe orderId
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>DataTable z wynikami zapytania</returns>
        public List<SuborderViewModel> GetSubordersOfParticularOrder(int orderId)
        {
            List<Suborder> suborders = DbContext.Suborders.Where(p => p.OrderId == orderId).ToList();
            return Mapper.Map<List<Suborder>, List<SuborderViewModel>>(suborders);
        }
    }
}
