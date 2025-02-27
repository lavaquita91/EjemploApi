using EjempliApi.Application.Dto.ObtenerPilotosDTO;
using EjempliApi.Application.Dto.Piloto;

namespace EjempliApi.Application.Interfaces
{
    public interface IObtenerPilotoSp
    {
        Task<IEnumerable<PilotoResponseDto>> ObtenerPilotosActivosAsync();
        Task<InsertarPilotoResponseDto> InsertarPilotoAsync(InsertarPilotoRequestDto request);
    }
}
