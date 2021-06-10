using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Suborders
    /// </summary>
    interface ISubordersRepository
    {

        /// <summary>
        /// Metoda tworząca podzamówienie
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="laptopId"></param>
        /// <param name="quantity"></param>
        void CreateSuborder(int orderId, int laptopId, int quantity);

        /// <summary>
        /// Metoda zwracająca podzamówienia dla zamówenia, którego Id jest równe orderId
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>DataTable z wynikami zapytania</returns>
        DataTable GetSubordersOfParticularOrder(int orderId);
    }
}
