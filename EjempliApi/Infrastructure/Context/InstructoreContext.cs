using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class InstructoreContext : IEntityTypeConfiguration<Instructore>
    {
        public void Configure(EntityTypeBuilder<Instructore> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("Instructores");

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
