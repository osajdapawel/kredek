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
    /// Klasa modelu laptopa
    /// </summary>
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Procesor")]
        public int ProcessorId { get; set; }

        [Required]
        [Display(Name = "Grafika")]
        public int GraphicsCardId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required] 
        [MaxLength(500)]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "RAM")]
        public int RamAmount { get; set; }

        [Required]
        [Display(Name = "Ilość")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public float Price { get; set; }

        [ForeignKey("ProcessorId")]
        [Display(Name = "Procesor")]
        public virtual Processor Processor { get; set; }
        [ForeignKey("GraphicsCardId")]
        [Display(Name = "Grafika")]
        public virtual GraphicsCard GraphicsCard { get; set; }

        public virtual ICollection<Suborder> Suborders { get; set; }

    }
}
