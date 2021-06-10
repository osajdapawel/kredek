using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawelOsajdaZadanieDomowe3.Models.Entities
{
    public class UserInformations
    {
        [Key] 
        public int Id { get; set; }
        [Required, MaxLength(50)] 
        public string FirstName { get; set; }
        [Required, MaxLength(50)] 
        public string LastName { get; set; }
        [Required, MaxLength(50)] 
        public string PhoneNumber { get; set; }
        [Required, MaxLength(50)] 
        public string Address { get; set; }


        public virtual ICollection<User> User { get; set; }

    }
}
