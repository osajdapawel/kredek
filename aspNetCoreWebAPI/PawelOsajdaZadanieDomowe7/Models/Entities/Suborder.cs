using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Models.Entities
{
    /// <summary>
    /// Klasa modelu podzamówienia
    /// </summary>
    public class Suborder
    {
        [Key]
        public int Id { get; set; }
        
        public int? OrderId { get; set; }
        
        [Required]
        public int LaptopId { get; set; }
        
        [Required]
        [Display(Name = "Ilość")]
        public int Quantity { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("LaptopId")]
        public virtual Laptop Laptop { get; set; }
    }
}
