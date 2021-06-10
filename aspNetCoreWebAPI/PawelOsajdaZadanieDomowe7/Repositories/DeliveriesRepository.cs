using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    /// Klasa odpowiadająca za komunikację z bazą danych dla tabeli Deliveries
    /// </summary>
    class DeliveriesRepository : Repository, IDeliveriesRepository
    {
        // Zmienna kontekstu bazy danych
        private readonly DataBaseContext _dbContext;

        /// <summary>
        /// Konstruktor repozytorium dostaw
        /// </summary>
        /// <param name="dbContext"></param>
        public DeliveriesRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Metoda asynchroniczna zwracająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Delivery> GetDeliveryById(int id)
            => await _dbContext.Deliveries.FindAsync(id);

        /// <summary>
        /// Metoda asynchroniczna zwracająca dostawy
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Delivery>> GetDeliveries()
            => await _dbContext.Deliveries.ToListAsync();

        /// <summary>
        /// Metoda asynchroniczna dodająca nową dostawę
        /// </summary>
        /// <param name="delivery"></param>
        /// <returns></returns>
        public async Task AddDelivery(Delivery delivery)
        {
            await _dbContext.Deliveries.AddAsync(delivery);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Metoda asynchroniczna aktualizująca daną dostawę
        /// </summary>
        /// <param name="delivery">Dostawa do update'u</param>
        /// <returns>True - udało się zaktualizować, false - nie zautalizowano - nie ma takiej dostawy</returns>
        public async Task<bool> Update(Delivery delivery)
        {
            _dbContext.Deliveries.Update(delivery);
            int numberOfAffectedRows = await _dbContext.SaveChangesAsync();
            if (numberOfAffectedRows != 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metoda asynchroniczna usuwająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True - udało się usunąć, false - nie usunięto - nie ma takiej dostawy</returns>
        public async Task<bool> DeleteDeliveryById(int id)
        {
            var delivery = await _dbContext.Deliveries.FindAsync(id);
            if (delivery == null)
                return false; 
             _dbContext.Deliveries.Remove(delivery);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
