using EjempliApi.Application.Dto.Persona.Request;
using EjempliApi.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjempliApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersona _personaService;

        public PersonaController(IPersona personaService)
        {
            _personaService = personaService;
        }


        [HttpPost("Registrar")]
        public async Task<IActionResult> RegisterPelicula([FromBody] PersonaRequest request)
        {
            var response = await _personaService.RegistrarPersona(request);
            return Ok(response);
        }

    }
}
