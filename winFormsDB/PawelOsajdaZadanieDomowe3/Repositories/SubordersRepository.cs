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
    /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Suborders
    /// </summary>
    class SubordersRepository : Repository, ISubordersRepository
    {
        /// <summary>
        /// Metoda tworząca podzapytanie. Należy pamiętać aby zmniejszyć liczbę laptopów
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="laptopId"></param>
        /// <param name="quantity"></param>
        public void CreateSuborder(int orderId, int laptopId, int quantity)
        {
            string insetQuerry = $"INSERT INTO Suborders VALUES ({orderId.ToString()},{laptopId.ToString()},{quantity.ToString()});";

            Connection.Open();
            SqlCommand insetCommand = new SqlCommand(insetQuerry, Connection);
            insetCommand.ExecuteNonQuery();
            Connection.Close();
        }

        /// <summary>
        /// Metoda zwracająca podzamówienia dla zamówenia, którego Id jest równe orderId
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>DataTable z wynikami zapytania</returns>
        public DataTable GetSubordersOfParticularOrder(int orderId)
        {
            string getSubordersQuerry =     "SELECT Laptops.Model, Laptops.Price AS 'Cena', Suborders.Quantity AS 'Liczba kupionych', (Laptops.Price * Suborders.Quantity) Suma " +
                                            "FROM Suborders "+
                                            "JOIN Laptops ON Laptops.Id = Suborders.LaptopId "+
                                            $"WHERE OrderId = {orderId.ToString()} "+
                                            "ORDER BY 4 desc; ";
            DataTable subordersTable = new DataTable();

            Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(getSubordersQuerry, Connection);
            adapter.Fill(subordersTable);
            Connection.Close();

            return subordersTable;
        }
    }
}
