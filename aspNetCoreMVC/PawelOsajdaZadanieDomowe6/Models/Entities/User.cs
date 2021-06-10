using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe6.Models.Entities
{
    /// <summary>
    /// Klasa modelu użytkownia
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int UserInformationsId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
        
        [Required] 
        [MaxLength(50)]
        public string Password { get; set; }

        [ForeignKey("UserInformationsId")]
        public virtual UserInformations UserInformations { get; set; }
    }
}
