using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe7.Models.Entities
{
    /// <summary>
    /// Klasa modelu informacji o użytkowniku
    /// </summary>
    public class UserInformations
    {
        [Key] 
        public int Id { get; set; }
        [Required] 
        [StringLength(50)]
        [Display(Name = "Imie")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nr telefonu")]
        public string PhoneNumber { get; set; }
        [Required] 
        [MaxLength(50)]
        [Display(Name = "Adres")]
        public string Address { get; set; }


        public virtual ICollection<User> User { get; set; }

    }
}
