using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class VueloContext : IEntityTypeConfiguration<Vuelo>
    {
        public void Configure(EntityTypeBuilder<Vuelo> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("Vuelo");

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
