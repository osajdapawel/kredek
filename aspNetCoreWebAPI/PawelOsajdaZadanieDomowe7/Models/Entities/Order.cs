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
    /// Klasa modelu zamówień
    /// </summary>
    public class Order
    {
        [Key]
        [Display(Name = "Numer")]
        public int Id { get; set; }
        
        [Required]
        public int UserInformationsId { get; set; }

        [Display(Name = "Dostawa")]
        public int? DeliveryId { get; set; }
        
        public string Status { get; set; }

        [ForeignKey("UserInformationsId")]
        [Display(Name = "Dane adresowe")]
        public virtual UserInformations UserInformations { get; set; }

        [ForeignKey("DeliveryId")]
        [Display(Name = "Dostawa")]
        public virtual Delivery Delivery { get; set; }

        public virtual ICollection<Suborder> Suborders { get; set; }


    }
}
