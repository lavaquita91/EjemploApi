using EjempliApi.Application.Dto.Persona.Request;

namespace EjempliApi.Application.Interfaces
{
    public interface IPersona
    {
        Task<bool> RegistrarPersona(PersonaRequest request);
    }
}
