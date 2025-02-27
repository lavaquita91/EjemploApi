using EjempliApi.Application.Dto.ObtenerPilotosDTO;
using EjempliApi.Application.Dto.Piloto;
using EjempliApi.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjempliApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObtenerPilotoSpController : ControllerBase
    {
        private readonly IObtenerPilotoSp _obtenerPilotoSp;
        public ObtenerPilotoSpController(IObtenerPilotoSp obtenerPilotoSp)
        {
            _obtenerPilotoSp = obtenerPilotoSp;
        }

        [HttpGet("obtener")]
        public async Task<IActionResult> ObtenerPilotosActivos()
        {
            var pilotos = await _obtenerPilotoSp.ObtenerPilotosActivosAsync();
            return Ok(pilotos);
        }


        [HttpPost("Registrar Piloto")]
        public async Task<IActionResult> ObtenerPiloto(InsertarPilotoRequestDto request)
        {
            var piloto = await _obtenerPilotoSp.InsertarPilotoAsync(request);
            return Ok(piloto);
        }


       
    }
}
