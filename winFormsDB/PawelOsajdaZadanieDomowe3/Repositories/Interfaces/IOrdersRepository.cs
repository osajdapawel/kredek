using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Orders
    /// </summary>
    interface IOrdersRepository
    {
        /// <summary>
        /// Metoda tworząca nowe zamówienie
        /// </summary>
        /// <returns>Id zamowienia</returns>
        int CreateOrder(int userId);

        /// <summary>
        /// Funkcja dodająca do zamówienia rodzaj dostawy i status "niespakowane"
        /// </summary>
        /// <param name="userId"></param>
        void FinaliseOrder(int orderId, string deliveryName);
    }
}
