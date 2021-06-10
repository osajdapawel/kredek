using AutoMapper;
using PawelOsajdaZadanieDomowe3.Infrastructure;
using PawelOsajdaZadanieDomowe3.Models;
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
        /// Zmienna przychowująca kontekst bazy danych
        /// </summary>
        protected readonly DataBaseContext DbContext = new DataBaseContext();

        // zmienna konfiguracji mappera
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));

        // zmienna mappera
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();



    }
}
