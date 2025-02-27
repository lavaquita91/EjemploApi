using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class PilotoVueloContext : IEntityTypeConfiguration<PilotoVuelo>
    {
        public void Configure(EntityTypeBuilder<PilotoVuelo> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("PilotoVuelo");

            builder.Property(e => e.Id)
               .HasColumnName("IdPilotoVuelo")
               .ValueGeneratedOnAdd();

            builder.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.FechaIngreso).HasColumnType("datetime");
        }
    }
}
