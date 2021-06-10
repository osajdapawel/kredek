using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PawelOsajdaZadanieDomowe7.Models;
using PawelOsajdaZadanieDomowe7.Models.Entities;
using PawelOsajdaZadanieDomowe7.Repositories.Interfaces;


namespace PawelOsajdaZadanieDomowe7.Repositories
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
        /// Metoda asynchroniczna zwracająca listę laptopów
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Laptop>> GetLaptops()
        {
            return await _dbContext.Laptops.Include(l => l.GraphicsCard).Include(l => l.Processor).ToListAsync();
        }

        /// <summary>
        /// Metoda asynchroniczna zwracająca laptop o podanym id
        /// </summary>
        /// <param name="id">Id laptopa do pobrania</param>
        /// <returns></returns>
        public async Task<Laptop> Get(int id)
            => await _dbContext.Laptops.FindAsync(id);

        /// <summary>
        /// Metoda asynchroniczna dodająca nowy laptop
        /// </summary>
        /// <param name="laptop"></param>
        /// <returns></returns>
        public async Task AddLaptop(Laptop laptop)
        {
            await _dbContext.Laptops.AddAsync(laptop);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Metoda asynchroniczna usuwająca laptop o konkretnym id
        /// </summary>
        /// <param name="id">Id laptopa do usun ięcia</param>
        /// <returns>True jeśli usunięto laptop, false jeśli nie istnieje dany laptop</returns>
        public async Task<bool> Delete(int id)
        {
            var laptop = await _dbContext.Laptops.FindAsync(id);
            if (laptop == null)
                return false;
            _dbContext.Laptops.Remove(laptop);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Metoda asynchroniczna aktualizująca dany laptop
        /// </summary>
        /// <param name="laptop">Laptop do edycji</param>
        /// <returns>True jeśli edytowano laptop, false jeśli nie istnieje dany laptop</returns>
        public async Task<bool> Update(Laptop laptop)
        {
            _dbContext.Laptops.Update(laptop);
            int numberOfAffectedRows = await _dbContext.SaveChangesAsync();
            if (numberOfAffectedRows != 0)
                return true;
            else
                return false;
        }
    }
}
