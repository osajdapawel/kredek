using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawelOsajdaZadanieDomowe3.Models.Entities;
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
            List<(string s, int n)> deliveryTypesList = new List<(string s, int n)>();

            List<Delivery> deliveries = DbContext.Deliveries.ToList();

            for(int i =0; i < deliveries.Count; i ++)
            {
                deliveryTypesList.Add(( deliveries[i].Type, deliveries[i].Price));
            }

            return deliveryTypesList;
        }
    }
}
