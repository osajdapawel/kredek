using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Models.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int UserInformationsId { get; set; }
        
        public int? DeliveryId { get; set; }
        
        public string Status { get; set; }

        [ForeignKey("UserInformationsId")]
        public virtual UserInformations UserInformations { get; set; }

        [ForeignKey("DeliveryId")]
        public virtual Delivery Delivery { get; set; }

        public virtual ICollection<Suborder> Suborders { get; set; }


    }
}
