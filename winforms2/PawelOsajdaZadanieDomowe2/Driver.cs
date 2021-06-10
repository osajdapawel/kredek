using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe2
{
    class Driver : Person
    {
        public int YearsOfExperience { get; set; }                      // właściwość, która opisuje lata doświadczenia kierowcy

        /// <summary>
        /// Konstruktor kierowcy
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="age"></param>
        /// <param name="exp"></param>
        public Driver(string fname, string lname, int age, int exp = 1)
        {
            FirstName = fname;
            LastName = lname;
            this.Age = age;
            if (exp < 50)
                YearsOfExperience = exp;
            else
                YearsOfExperience = 50;
        }
    }
}
