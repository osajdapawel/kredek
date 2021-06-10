using PawelOsajdaZadanieDomowe6.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe6.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Laptop - częściowa komunikacja
    /// </summary>
    public interface ILaptopsRepository
    {

        /// <summary>
        /// Metoda asynchroniczna zwracająca laptopy
        /// </summary>
        /// <returns></returns>
        Task < IEnumerable<Laptop> > GetLaptops();

    }
}
