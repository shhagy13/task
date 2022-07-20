using WebApplication2.DTO;

namespace WebApplication2.Models
{
    public class RegistrationModel
    {
        public string Id { get; set; }
        public string Locale { get; set; }

        public OrganisationModel Organisation { get; set; }
       
        public PersonModel Person { get; set; }
       
        public DateTime RegistrationDate { get; set; }

    }
}
