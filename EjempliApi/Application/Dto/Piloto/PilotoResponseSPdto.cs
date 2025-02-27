namespace EjempliApi.Application.Dto.Piloto
{
    public class PilotoResponseDto
    {
        public int IdPersona { get; set; }
        public string? Identificacion { get; set; }
        public string? NombresCompletos { get; set; }
        public int IdPiloto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? Estado { get; set; }
    }
}
