using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Deliveries
    /// </summary>
    interface IDeliveries
    {
        /// <summary>
        /// Metoda zwracająca listę nazw i cen poszczególnych typów dostaw
        /// </summary>
        /// <returns></returns>
        List<(string s, int n)> getDeliveryTypes();
    }
}
