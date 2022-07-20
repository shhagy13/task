using System.ComponentModel.DataAnnotations;

namespace WebApplication2.DTO
{
    public class Organisation
    {
        [Required]
        public Address address { get; set; }
        [Required]
        [StringLength(120, MinimumLength = 1, ErrorMessage = "field must be atleast 1 character")]
        public string name { get; set; }
    }
}
