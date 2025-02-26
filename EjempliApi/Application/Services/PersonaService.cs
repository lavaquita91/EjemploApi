using AutoMapper;
using Azure;
using EjempliApi.Application.Dto.Persona.Request;
using EjempliApi.Application.Interfaces;
using EjempliApi.Entities;
using EjempliApi.Infrastructure.Persistence.Interfaces;

namespace EjempliApi.Application.Services
{
    public class PersonaService : IPersona
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PersonaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> RegistrarPersona(PersonaRequest request)
        {
            var persona = _mapper.Map<Persona>(request);

            var data= await _unitOfWork.Persona.RegisterAsync(persona);

            return data;

        }
    }
}
