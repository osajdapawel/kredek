using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe2
{
    class Passenger : Person
    {
        public BusStop Destination { get; set; }
       
        /// <summary>
        /// Konstruktor pasażera
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="age"></param>
        /// <param name="destiny"></param>
        public Passenger(string fname, string lname, int age, BusStop destiny)
        {
            FirstName = fname;
            LastName = lname;
            this.Age = age;
            Destination = destiny; 
        }
    }
}
