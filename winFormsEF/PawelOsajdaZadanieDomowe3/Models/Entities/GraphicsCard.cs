using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Models.Entities
{
    public class GraphicsCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int VRamAmount { get; set; }

        public virtual ICollection<Laptop> Laptops { get; set; }

    }
}
