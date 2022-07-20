using System.ComponentModel.DataAnnotations;

namespace WebApplication2.DTO
{
    public class Person
    {
        public Address address { get; set; }
        [Required]
        [StringLength(254, MinimumLength = 1, ErrorMessage = "field must be atleast 1 character")]
        public string email { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "field must be atleast 1 character")]
        public string firstName { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "field must be atleast 1 character")]
        public string lastName { get; set; }
    }
}
