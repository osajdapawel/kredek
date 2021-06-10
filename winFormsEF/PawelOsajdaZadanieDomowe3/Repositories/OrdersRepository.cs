using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawelOsajdaZadanieDomowe3.Models.Entities;
using PawelOsajdaZadanieDomowe3.Repositories.Interfaces;

namespace PawelOsajdaZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Orders
    /// </summary>
    class OrdersRepository : Repository, IOrdersRepository
    {
        /// <summary>
        /// Metoda tworząca nowe zamówienie
        /// </summary>
        /// <returns>Id stworzonego zamówienia</returns>
        public int CreateOrder(int userId)
        {
            User user = DbContext.Users.Single(p => p.Id == userId);

            Order orderToCreate = new Order()
            {
                UserInformationsId = user.UserInformationsId
            };

            DbContext.Orders.Add(orderToCreate);
            DbContext.SaveChanges();

            return orderToCreate.Id;
        }

        /// <summary>
        /// Funkcja dodająca do zamówienia rodzaj dostawy i status "niespakowane"
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="deliveryName"></param>
        public void FinaliseOrder(int orderId, string deliveryName)
        {
            Delivery delivery = DbContext.Deliveries.FirstOrDefault(d => d.Type == deliveryName);

            Order order = DbContext.Orders.SingleOrDefault(p => p.Id == orderId);

            order.DeliveryId = delivery.Id;
            order.Status = "Niespakowane";

            DbContext.SaveChanges();
        }
    }
}
