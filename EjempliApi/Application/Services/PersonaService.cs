using AutoMapper;
using Azure;
using EjempliApi.Application.Dto.Persona.Request;
using EjempliApi.Application.Dto.Persona.Response;
using EjempliApi.Application.Interfaces;
using EjempliApi.Entities;
using EjempliApi.Infrastructure.Persistence.Interfaces;
using System.Collections.Generic;

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

        public async Task<IEnumerable<PersonaResponse>> GetPersonas()
        {
            
            var persona = await _unitOfWork.Persona.GetAllAsync();
            var personaResponses = _mapper.Map<IEnumerable<PersonaResponse>>(persona);
            

            return personaResponses;
        }

        public async Task<bool> RegistrarPersona(PersonaRequest request)
        {
            var persona = _mapper.Map<Persona>(request);

            var data= await _unitOfWork.Persona.RegisterAsync(persona);

            return data;

        }
    }
}
