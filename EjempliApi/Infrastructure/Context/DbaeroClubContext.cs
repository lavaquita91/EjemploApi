using System;
using System.Collections.Generic;
using System.Reflection;
using EjempliApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EjempliApi.Infrastructure.Context;

public partial class DbaeroClubContext : DbContext
{
    public DbaeroClubContext()
    {
    }

    public DbaeroClubContext(DbContextOptions<DbaeroClubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aeronave> Aeronaves { get; set; } =null!;

    public virtual DbSet<Horario> Horarios { get; set; } = null!;

    public virtual DbSet<Instructore> Instructores { get; set; } = null!;

    public virtual DbSet<Persona> Personas { get; set; } = null!;

    public virtual DbSet<Piloto> Pilotos { get; set; } = null!;

    public virtual DbSet<PilotoVuelo> PilotoVuelos { get; set; } = null!;

    public virtual DbSet<Vuelo> Vuelos { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SIPECOM114\\MSSQLSERVER2019;Database=DBAeroClub;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational.Collection", "ModerN_Spanish_CI_AS");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
