using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe6.Models.Entities
{   
    /// <summary>
    /// Klasa modelu dostaw
    /// </summary>
    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        
        [Required, MaxLength(50)]
        //[DisplayFormat(NullDisplayText = "Nie podano typu")]
        [Display(Name = "Typ")]
        public string Type { get; set; }
        
        [Required]
        //[DisplayFormat(NullDisplayText = "Nie podano czasu dostawy")]
        [Display(Name = "Czas")]
        public int DeliveryTime { get; set; }
        
        [Required]
        //[DisplayFormat(NullDisplayText = "Nie podano ceny")]
        [Display(Name = "Cena")]
        public int Price { get; set; }
    }
}
