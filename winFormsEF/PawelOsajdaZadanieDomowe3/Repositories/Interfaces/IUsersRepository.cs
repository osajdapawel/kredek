using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Repositories.Interfaces
{
    /// <summary>
    /// Interfejs definiujący metody związane z komunikacją z bazą danych dla tabeli Users
    /// </summary>
    interface IUsersRepository
    {
        /// <summary>
        /// Metoda zwracająca imię i nazwisko użytkownika o zadanym Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Imię i nazwisko użytkownika</returns>
        string getName(int userId);
        
        /// <summary>
        /// Metoda służąca do obsługi logowania
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>Id usera którego zalogowano lub 0 jeśli nie istnieje user o podanych parametrach</returns>
        int Login(string login, string password);
    }
}
