

using System.ComponentModel.DataAnnotations;

namespace WebApplication2.DTO
{
    public class RegistrationRequest 
    {
        public string locale { get; set; }
        public Organisation organisation { get; set; }
        [Required]
        public Person person { get; set; }
        [Required]
        public DateTime registrationDate { get; set; }
    }
}
