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

            CreateMap<Persona, PersonaResponse>()
                .ForMember(x => x.Id_Persona, x => x.MapFrom(y => y.Id))
                .ForMember(x => x.Identificacion, x => x.MapFrom(y => y.Identificacion))
                .ForMember(x => x.NombreCompleto, x => x.MapFrom(y => y.NombresCompletos))
                .ForMember(x => x.Estado, x => x.MapFrom(y => y.Estado))
                .ReverseMap();
        }
    }
}
