using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Models.Entities
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProcessorId { get; set; }

        [Required] 
        public int GraphicsCardId { get; set; }

        [Required] 
        public string Model { get; set; }

        [Required] 
        public string Description { get; set; }

        [Required] 
        public int RamAmount { get; set; }

        [Required] 
        public int Quantity { get; set; }

        [Required] 
        public float Price { get; set; }

        [ForeignKey("ProcessorId")]
        public virtual Processor Processor { get; set; }
        [ForeignKey("GraphicsCardId")]
        public virtual GraphicsCard GraphicsCard { get; set; }

        public virtual ICollection<Suborder> Suborders { get; set; }

    }
}
