using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class PilotoVueloContext : IEntityTypeConfiguration<PilotoVuelo>
    {
        public void Configure(EntityTypeBuilder<PilotoVuelo> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__PilotoVu__2A5292FAE71B5324");

            builder.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.FechaIngreso).HasColumnType("datetime");
        }
    }
}
