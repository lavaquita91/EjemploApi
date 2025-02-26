namespace EjempliApi.Application.Dto.Persona.Response
{
    public class PersonaResponse
    {
        public int Id_Persona { get; set; }
        public string? Identificacion { get; set; }
        public string? NombreCompleto { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
    }
}
