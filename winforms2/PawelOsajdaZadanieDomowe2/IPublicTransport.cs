using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe2
{
    interface IPublicTransport
    {
        List<Passenger> Passengers { get; set; }
    }
}
