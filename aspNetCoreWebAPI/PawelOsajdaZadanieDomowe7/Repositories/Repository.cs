using AutoMapper;
using PawelOsajdaZadanieDomowe7.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Repositories
{
    /// <summary>
    /// Klasa abstrakcyjna posiadająca pola i metody, które są dziedziczone i używane w klasach pochodnych
    /// </summary>
    public abstract class Repository
    {
        // konfig mappera tutaj nie używany w taki sposób
        // ale można by tak było 

/*        // zmienna konfiguracji mappera
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));

        // zmienna mappera
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
*/
    }
}
