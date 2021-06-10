using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Models.Entities
{
    /// <summary>
    /// Klasa modelu kart graficznych
    /// </summary>
    public class GraphicsCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Grafika")]
        public string Model { get; set; }
        [Required]
        [Display(Name = "VRAM")]
        public int VRamAmount { get; set; }

        public virtual ICollection<Laptop> Laptops { get; set; }

    }
}
