using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PawelOsajdaZadanieDomowe3.Repositories.Interfaces;

namespace PawelOsajdaZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Laptops
    /// </summary>
    class LaptopsRepository : Repository,  ILaptopsRepository
    {
        /// <summary>
        /// Metoda odpowiadająca za zmniejszenie o podaną liczbę ilość sztuk laptopa o podanym Id
        /// </summary>
        /// <param name="laptopId">Id laptopa którego liczbę sztuk zmniejszamy</param>
        /// <param name="number">Liczba, o którą należy zmniejszyć liczbę sztuk laptopów</param>
        public void DecreaseLaptopNumber(int laptopId, int number)
        {
            string decreaseQuerry = $"UPDATE Laptops SET Quantity = Quantity - {number.ToString()} WHERE Id = {laptopId.ToString()}";
            
            Connection.Open();
            SqlCommand decreaseCommand = new SqlCommand(decreaseQuerry, Connection);
            decreaseCommand.ExecuteNonQuery();
            Connection.Close();
        }

        /// <summary>
        /// Metoda zwracająca ilość sztuk laptopa o danym Id
        /// </summary>
        /// <param name="laptopId"></param>
        /// <returns>-1 jeśli nie ma laptopa lub liczbę sztuk danego laptopa</returns>
        public int getLaptopQuantity(int laptopId)
        {
            string querry = $"SELECT Laptops.Quantity FROM Laptops WHERE Id = {laptopId.ToString()}";
            Connection.Open();

            SqlCommand command = new SqlCommand(querry, Connection);
            var tempQuantity = command.ExecuteScalar();

            Connection.Close();
            
            if(tempQuantity == null)
                return -1;
            else
                return (int)tempQuantity;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie laptopy z tabeli Laptops wraz z danymi karty graficznej i procesora (osobne tabele)
        /// </summary>
        /// <returns>Data table z wynikiem zapytania - laptopy z danymi/returns>
        public DataTable GetLaptops()
        {
            string getLaptopsFromViewQuerry = "SELECT * FROM ViewShowLaptops";
            Connection.Open();
            
            SqlDataAdapter adapter = new SqlDataAdapter(getLaptopsFromViewQuerry, Connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            Connection.Close();

            return table;
        }
    }
}
