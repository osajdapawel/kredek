using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            string insertCommand = $"INSERT INTO Orders VALUES ( (SELECT UserInformationsId FROM Users WHERE Users.id = {userId.ToString()} ), null, null) SELECT  @@IDENTITY AS Id;";

            Connection.Open();

            SqlCommand createNewOrder = new SqlCommand(insertCommand, Connection);
            var tempOrderId = createNewOrder.ExecuteScalar();
           
            Connection.Close();

            int orderId = 0;

            if (tempOrderId == null)
                orderId = 0;
            else
                orderId = int.Parse(tempOrderId.ToString());

            return orderId;
        }

        /// <summary>
        /// Funkcja dodająca do zamówienia rodzaj dostawy i status "niespakowane"
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="deliveryName"></param>
        public void FinaliseOrder(int orderId, string deliveryName)
        {
            string updateOrder = $"UPDATE Orders SET DeliveryID = ( SELECT Deliveries.Id FROM Deliveries WHERE Deliveries.Type = '{deliveryName}' ), Status = 'Niespakowana' WHERE Orders.Id = {orderId.ToString()} ";

            Connection.Open();
            SqlCommand updateCommand = new SqlCommand(updateOrder, Connection);
            updateCommand.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
