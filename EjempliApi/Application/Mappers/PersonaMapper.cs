using AutoMapper;
using EjempliApi.Application.Dto.Persona.Request;
using EjempliApi.Application.Dto.Persona.Response;
using EjempliApi.Entities;

namespace EjempliApi.Application.Mappers
{
    public class PersonaMapper : Profile
    {

        public PersonaMapper()
        {
            CreateMap<PersonaRequest, Persona>();
        }
    }
}
