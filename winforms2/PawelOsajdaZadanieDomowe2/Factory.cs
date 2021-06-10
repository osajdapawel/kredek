using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe2
{
    class Factory
    {
        Random random = new Random();           // obiekt typu Random, który posłuży do otrzymania wartości "losowych"

        // 10 elementowe listy imion i nazwisk do tworzenia "losowych" pasażerów
        List<String> firstNames = new List<string> { "Rafał", "Adam", "Mateusz", "Piotr", "Filip", "Kacper", "Marcin", "Krzysztof", "Eryk", "Dawid" };
        List<String>  lastNames = new List<string> { "Kowalski", "Nowak", "Najman", "Lewandowski", "Cegielski", "Kowalczyk", "Nowicki", "Biernat", "Szymański", "Wiśniewski", };


        /// <summary>
        /// Funkcja tworząca nowego pasażera z celem innym niż przystanek, na któym docelowo ma się znajdować
        /// </summary>
        /// <param name="stop">Przystanek, na którym docelowo ma znajdować się pasażer</param>
        /// <param name="stops">Lista przystanków</param>
        /// <returns>Obiekt typu pasażer z "losowymi" parametrami</returns>
        public Passenger CreatePassengerAtBusStop(BusStop stop, List<BusStop> stops)
        {
            int randomAge = random.Next(1, 90);
            BusStop randomBusStop=null;

            do
            {
                randomBusStop = stops[random.Next( 0, stops.Count() )];
            } while (randomBusStop == stop);

            return new Passenger(firstNames[random.Next(0, 9)], lastNames[random.Next(0, 9)], randomAge, randomBusStop);
        }

        /// <summary>
        /// Funkcja tworząca nowego kierowcę z losowymi danymi
        /// </summary>
        /// <returns></returns>
        public Driver CreateDriver()
        {
            int randomAge = random.Next(24, 70);
            int randomExp;
            do
            {
                randomExp = random.Next(1, 40);
            } while (randomExp <= randomAge - 24);

            return new Driver(firstNames[random.Next(0, 9)], lastNames[random.Next(0, 9)], randomAge, randomExp);
        }


    }
}
