using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawelOsajdaZadanieDomowe3.Repositories.Interfaces;

namespace PawelOsajdaZadanieDomowe3.Repositories
{
    /// <summary>
    ///     /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Deliveries
    /// </summary>
    class DeliveriesRepository : Repository, IDeliveries
    {
        /// <summary>
        /// Metoda zwracająca listę nazw i cen poszczególnych typów dostaw
        /// </summary>
        /// <returns></returns>
        public List<(string s, int n)> getDeliveryTypes()
        {
            List < (string s, int n)> deliveryTypesList = new List<(string s, int n)>();
            string querry = "SELECT Deliveries.Type, Deliveries.Price FROM Deliveries;";

            Connection.Open();

            SqlCommand adapter = new SqlCommand(querry, Connection);
            SqlDataReader dataReader = adapter.ExecuteReader();     // utwórz obiekt dataReadera

            while (dataReader.Read())                               // czytaj dane do czasu skończenia wierszy
            {
                // zapis danych do listy
                deliveryTypesList.Add((dataReader.GetString(0), (int)dataReader.GetValue(1)));
            }
            Connection.Close();

            return deliveryTypesList;
        }
    }
}
