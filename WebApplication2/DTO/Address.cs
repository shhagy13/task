using System.ComponentModel.DataAnnotations;

namespace WebApplication2.DTO
{
    public class Address
    {
        [Required]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "field must be atleast 1 character")]
        public string addressLine1 { get; set; }
        [MaxLength(150)]
        public string addressLine2 { get; set; }
        [MaxLength(150)]
        public string addressLine3 { get; set; }
        [MaxLength(40)]
        public string city { get; set; }
        [Required]
        [MinLength(1)]
        public string countryIsoCode { get; set; }
        public string locale { get; set; }
        [MaxLength(60)]
        public string postcode { get; set; }
        [MaxLength(60)]
        public string state { get; set; }
    }
}
