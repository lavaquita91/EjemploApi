using EjempliApi.Application.Dto.Persona.Request;
using EjempliApi.Application.Dto.Persona.Response;

namespace EjempliApi.Application.Interfaces
{
    public interface IPersona
    {
        Task<IEnumerable<PersonaResponse>> GetPersonas();
        Task<bool> RegistrarPersona(PersonaRequest request);
    }
}
