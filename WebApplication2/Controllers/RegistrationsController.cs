using Microsoft.AspNetCore.Mvc;

using WebApplication2.DTO;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/v1/registrations")]

    public class RegistrationsController : ControllerBase
    {

        private readonly RegistrationDBContext _context;

        public RegistrationsController(RegistrationDBContext context)
        {
            _context = context;
        }

   

        [HttpPost]
        public async Task<IActionResult> Post(RegistrationRequest registration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = new RegistrationModel { Id = "1", Locale =registration.locale, Organisation = new OrganisationModel { address = registaatorganisation.address}, Person = registration.person, RegistrationDate = registration.registrationDate};
            _context.Registrations.Add(entity);
            await _context.SaveChangesAsync();

            return Ok(new RegistrationResponse { registrationId = entity.Id});
        }


        [HttpGet("{registrationid}")]
        public async Task<IActionResult> Get(string registrationid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var registration = await _context.Registrations.FindAsync(registrationid);

            if (registration == null)
            {
                var error = new ErrorResponse { error = new Error { code = "NotFound", message = $"Registration record with {registrationid} id was not found" } };
                return NotFound(error);
            }

            return Ok(new GetRegistrationResponse { id = registration.Id, locale = registration.Locale, organisation = registration.Organisation, person = registration.Person, registrationDate =registration.RegistrationDate });
        }



    }
}