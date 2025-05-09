using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Parcial2.Models;

namespace Parcial2.Context;

public partial class FarmaciaUnabContext : DbContext
{
    public FarmaciaUnabContext()
    {
    }

    public FarmaciaUnabContext(DbContextOptions<FarmaciaUnabContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=RAZER\\SQLEXPRESS;Initial Catalog=Farmacia Unab;User ID=dave;Password =12345; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NombreMedicamento)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.PrecioMedicamento)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
