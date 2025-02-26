using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class PersonaContext : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("Personas");

            builder.Property(e => e.Id).HasColumnName("IdPersona");

            builder.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            builder.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.FechaIngreso).HasColumnType("datetime");
            builder.Property(e => e.Identificacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            builder.Property(e => e.Nombres)
                .HasMaxLength(200)
                .IsUnicode(false);
            builder.Property(e => e.NombresCompletos)
                .HasMaxLength(400)
                .IsUnicode(false);
        }
    }
}
