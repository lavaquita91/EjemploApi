using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class PilotoContext : IEntityTypeConfiguration<Piloto>
    {
        public void Configure(EntityTypeBuilder<Piloto> builder)
        {
            builder.HasKey(e => e.Id);
            //.HasName("PK__Pilotos__DB35379F8EC48DDF")

            builder.Property(e => e.Id)
                .HasColumnName("IdPiloto")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.FechaIngreso).HasColumnType("datetime");
        }
    }
}
