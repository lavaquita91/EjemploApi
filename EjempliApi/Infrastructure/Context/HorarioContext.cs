using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class HorarioContext: IEntityTypeConfiguration<Horario>
    {
     
        public void Configure(EntityTypeBuilder<Horario> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Horario__1539229B479942B0");

            builder.ToTable("Horario");

            builder.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.FechaIngreso).HasColumnType("datetime");
            builder.Property(e => e.Horario1)
                    .IsUnicode(false)
                    .HasColumnName("Horario");

        }
    }
}
