using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PawelOsajdaZadanieDomowe6.Models;
using PawelOsajdaZadanieDomowe6.Models.Entities;
using PawelOsajdaZadanieDomowe6.Repositories.Interfaces;


namespace PawelOsajdaZadanieDomowe6.Repositories
{
    /// <summary>
    /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Laptops - częściowa komunikacja
    /// </summary>
    class LaptopsRepository : Repository,  ILaptopsRepository
    {
        // Zmienna kontekstu bazy danych
        private readonly DataBaseContext _dbContext;

        /// <summary>
        /// Konstruktor repozytorium laptopów
        /// </summary>
        /// <param name="dbContext"></param>
        public LaptopsRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }     

        /// <summary>
        /// Metoda asynchroniczna zwracająca liste laptopów
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Laptop>> GetLaptops()
        {
            return await _dbContext.Laptops.Include(l => l.GraphicsCard).Include(l => l.Processor).ToListAsync();
        }
    }
}
