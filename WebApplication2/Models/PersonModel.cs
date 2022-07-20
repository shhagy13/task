using WebApplication2.DTO;

namespace WebApplication2.Models
{
    public class PersonModel
    {
        public AdressModel address { get; set; }
       
        public string email { get; set; }
     
        public string firstName { get; set; }
    
        public string lastName { get; set; }
    }
}
