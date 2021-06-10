using PawelOsajdaZadanieDomowe3.Models.Entities;
using PawelOsajdaZadanieDomowe3.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PawelOsajdaZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Users
    /// </summary>
    class UsersRepository : Repository, IUsersRepository
    {

        /// <summary>
        /// Metoda zwracająca imię i nazwisko użytkownika o zadanym Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Imię i nazwisko użytkownika</returns>
        public string getName(int userId)
        {
            User user = DbContext.Users.Single(u => u.Id == userId);

            return user.UserInformations.FirstName + user.UserInformations.LastName;
        }

        /// <summary>
        /// Metoda służąca do obsługi logowania
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>Id usera którego zalogowano lub 0 jeśli nie istnieje user o podanych parametrach</returns>
        public int Login(string login, string password)
        {
            User user = DbContext.Users.SingleOrDefault(u => u.Login == login && u.Password == password);

            if (user == null)
                return 0;
            else
                return user.Id;
        }
    }
}
