using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
        /// Metoda asynchroniczna usuwająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteDeliveryById(int id)
        {
            var delivery = await _dbContext.Deliveries.FindAsync(id);
             _dbContext.Deliveries.Remove(delivery);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Metoda asynchroniczna zwracająca dostawę o konkretnym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Delivery> GetDeliveryById(int id)
            => await _dbContext.Deliveries.FindAsync(id);

        /// <summary>
        /// Metoda asynchroniczna aktualizująca daną dostawę
        /// </summary>
        /// <param name="delivery">Dostawa do update'u</param>
        /// <returns></returns>
        public async Task Update(Delivery delivery)
        {
            _dbContext.Deliveries.Update(delivery);
            await _dbContext.SaveChangesAsync();
        }
    }
}
