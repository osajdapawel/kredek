using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe2
{
    class Bus 
    {
        
        Random random = new Random();                                               // obiekt typu Random, który posłuży do otrzymania wartości "losowych"
        public List<Passenger> passengersToTransport = new List<Passenger>();       // pole będące listą pasażerów
        public BusStop Destination { get; set; }                                    // właściwość będąca przystankiem docelowym
        public BusStop CurrentBusStop { get; set; }                                 // właściwość będąca przystankiem na którym aktualnie autobus się znajduje
        public Driver driver;                                                       // pole będące obiektem typu Driver

        /// <summary>
        /// Funkcja ładująca pasażerów, którzy mają cel zgodny z celem autobusu do autobusu
        /// </summary>
        public void Load() 
        {
            passengersToTransport = CurrentBusStop.passengers.Where(p => p != null && p.Destination == Destination).ToList();
            CurrentBusStop.passengers.RemoveAll(r => passengersToTransport.Any(a => a==r));
        }

        /// <summary>
        /// Funkcja opróżniająca autobus z pasażeró
        /// </summary>
        public void Empty()
        {
            //Destination.passengers.Concat(passengersToTransport);
            passengersToTransport.Clear();
        }

        /// <summary>
        /// Funkcja odpowiadająca za informacje o transporcie
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destiny"></param>
        /// <returns>Prawda jeśli wystąpił wypadek, fałsz jeśli nie było wypadku</returns>
        public bool Transport()
        {        
            bool isCrash = Crash();
            CurrentBusStop = Destination;
            return isCrash;
        }

        /// <summary>
        /// Funkcja obsługująca wypadek, cało wychodza tylko osoby w wieku 5-60 lat, reszta potrzebuje pomocy medycznej i przestaje być pasażerami autobusu. Im więcej lak doświadczenia ma kierowca tym mniejsze szanse na wypadek
        /// </summary>
        /// <returns>Prawda jeśli wystąpił wypadek, fałsz jeśli nie było wypadku</returns>
        public bool Crash()
        {
            if (driver.YearsOfExperience + random.Next(1, 130) < 50)
            {
                passengersToTransport.RemoveAll(p => p.Age < 5 || p.Age > 60);
                return true;
            }
            else
                return false;
        }

    }
}
