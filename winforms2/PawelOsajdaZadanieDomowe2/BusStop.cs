using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe2
{
    class BusStop
    {
        private static int count = 0;                               // prywatne statyczne pole, które służy do numeracji przystanków
        public List<Passenger> passengers = new List<Passenger>();  // pole będące listą pasażerów

        public int Number { get; }                                  // właściwoś opisująca numer przystanku
        public string Name { get;  }                                // właściwość opisująca nazwę przystnku


        /// <summary>
        /// Konstruktor przystanku
        /// </summary>
        /// <param name="name"></param>
        public BusStop(string name)
        {
            Name = name;
            this.Number = count++;
        }

        // ==== override metody ToString
        public override string ToString()
        {
            return this.Name;
        }
    }
}
