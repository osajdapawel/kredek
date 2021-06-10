using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.ViewModels
{
    /// <summary>
    /// Model podzamówienia ze zmiennymi z innych klas
    /// </summary>
    public class SuborderViewModel
    {
        public string LaptopModel { get; set; }

        public string LaptopPrice { get; set; }

        public int Quantity { get; set; }

        public float Sum { get; set; }

    }
}