using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EjempliApi.Infrastructure.Context
{
    public class InstructoreContext : IEntityTypeConfiguration<Instructore>
    {
        public void Configure(EntityTypeBuilder<Instructore> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK__Instruct__10850044F8B89BFC");

            builder.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.FechaIngreso).HasColumnType("datetime");
        }
    }
}
