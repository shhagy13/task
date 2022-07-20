using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class RegistrationDBContext : DbContext
    {
        public DbSet<RegistrationModel> Registrations { get; set; }
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<AdressModel> Adresses { get; set; }
        public DbSet<OrganisationModel> Organisations { get; set; }

        public RegistrationDBContext(DbContextOptions<RegistrationDBContext> options)
            : base(options)
        {

        }
    }
}
