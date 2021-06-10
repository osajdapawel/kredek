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
            string querry = $"SELECT UserInformations.FirstName, UserInformations.LastName FROM UserInformations JOIN Users ON Users.UserInformationsId = UserInformations.Id WHERE Users.Id = {userId.ToString()};";

            string name;

            Connection.Open();
            SqlCommand getNameQuerry = new SqlCommand(querry, Connection);
            SqlDataReader dataReader = getNameQuerry.ExecuteReader();

            dataReader.Read();
            name = dataReader.GetString(0) + " " + dataReader.GetString(1);
            
            return name;
        }

        /// <summary>
        /// Metoda służąca do obsługi logowania
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns>Id usera którego zalogowano lub 0 jeśli nie istnieje user o podanych parametrach</returns>
        public int Login(string login, string password)
        {
            string loginQuerry = $"SELECT users.Id from Users WHERE login = '{login}' AND Password = '{password}';";

            Connection.Open();

            SqlCommand loginCommand = new SqlCommand(loginQuerry, Connection);
            int userId = 0;

            var testUserId = loginCommand.ExecuteScalar();

            Connection.Close();

            if(testUserId == null)
                userId = 0;
            else
                userId = (int)testUserId;

            Connection.Close();

            if (userId >= 1)
                return userId;
            else
                return 0;
        }
    }
}
