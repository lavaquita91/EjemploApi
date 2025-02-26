namespace EjempliApi.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? Estado { get; set; }
    }
}
