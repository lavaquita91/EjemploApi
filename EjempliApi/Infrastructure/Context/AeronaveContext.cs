using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class AeronaveContext : IEntityTypeConfiguration<Aeronave>
    {
        public void Configure(EntityTypeBuilder<Aeronave> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("Aeronave");

            builder.Property(e => e.Id)
               .HasColumnName("IdAeronave")
               .ValueGeneratedOnAdd();

            builder.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.FechaIngreso).HasColumnType("datetime");
        }
    }
}
