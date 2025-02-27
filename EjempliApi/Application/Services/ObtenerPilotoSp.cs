using EjempliApi.Application.Dto.ObtenerPilotosDTO;
using EjempliApi.Application.Dto.Piloto;
using EjempliApi.Application.Interfaces;
using EjempliApi.Entities;
using EjempliApi.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EjempliApi.Application.Services
{
    public class ObtenerPilotoSp : IObtenerPilotoSp
    {
        private readonly DbaeroClubContext _context;
        public ObtenerPilotoSp(DbaeroClubContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PilotoResponseDto>> ObtenerPilotosActivosAsync()
        {
            var query = from p in _context.Personas
                        join pi in _context.Pilotos on p.Id equals pi.IdPersona
                        where pi.Estado == "Activo"
                        orderby p.NombresCompletos
                        select new PilotoResponseDto
                        {
                            IdPersona = p.Id,
                            Identificacion = p.Identificacion,
                            NombresCompletos = p.NombresCompletos,
                            IdPiloto = pi.Id,
                            FechaIngreso = pi.FechaIngreso,
                            Estado = pi.Estado
                        };

            return await query.ToListAsync();
        }
        public async Task<InsertarPilotoResponseDto> InsertarPilotoAsync(InsertarPilotoRequestDto request)
        {
            var nombresCompletos = $"{request.Nombres} {request.Apellidos}";

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {

                // Insertar en tabla Personas
                var persona = new Persona
                {
                    Identificacion = request.Identificacion,
                    Nombres = request.Nombres,
                    Apellidos = request.Apellidos,
                    NombresCompletos = nombresCompletos,
                    FechaIngreso = DateTime.Now,
                    Estado = request.Estado
                };

                _context.Personas.Add(persona);
                await _context.SaveChangesAsync();

                // Obtener el ID generado
                var idPersona = persona.Id;

                // Insertar en tabla Pilotos
                var piloto = new Piloto
                {
                    IdPersona = idPersona,
                    FechaIngreso = DateTime.Now,
                    Estado = request.Estado
                };

                _context.Pilotos.Add(piloto);
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();

                return new InsertarPilotoResponseDto
                {
                    IdMensaje = 1,
                    Mensaje = "Piloto registrado exitosamente",
                    IdPersona = persona.Id
                };
            }
        }

        
    }
    
}
