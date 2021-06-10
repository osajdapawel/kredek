using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Models.Entities
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        
        [Required, MaxLength(50)]
        public string Type { get; set; }
        
        [Required]
        public int DeliveryTime { get; set; }
        
        [Required]
        public int Price { get; set; }
    }
}
