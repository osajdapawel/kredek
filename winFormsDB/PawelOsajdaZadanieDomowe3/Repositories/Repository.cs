using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna posiadająca pola i metody, które są dziedziczone i używane w klasach pochodnych
    /// </summary>
    public abstract class Repository
    {
        /// <summary>
        /// Zmienna przychowująca połączenie z bazą danych
        /// </summary>
        protected readonly SqlConnection Connection;

        public Repository() 
        {
            // inicjalizacja połącznia z bazą danych 
            Connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
    }
}
