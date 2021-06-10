using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe6.Models.Entities
{
    /// <summary>
    /// Klasa modelu procesora
    /// </summary>
    public class Processor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Procesor")]
        public string  Model { get; set; }
        [Required]
        [Display(Name = "Wątki")]
        public int NumberOfThreds { get; set; }

        public virtual ICollection<Laptop> Laptops { get; set; }
    }
}
