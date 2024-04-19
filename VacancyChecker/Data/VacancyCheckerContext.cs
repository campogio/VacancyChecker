using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VacancyChecker.Data;

public partial class VacancyCheckerContext : DbContext
{
    public VacancyCheckerContext()
    {
    }

    public VacancyCheckerContext(DbContextOptions<VacancyCheckerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bed> Beds { get; set; }

    public virtual DbSet<Hospital> Hospitals { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VacancyChecker;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bed__3214EC075FC9CCBD");

            entity.ToTable("Bed");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PatientId).HasColumnName("Patient_Id");
            entity.Property(e => e.WardId).HasColumnName("Ward_Id");

            entity.HasOne(d => d.Ward).WithMany(p => p.Beds)
                .HasForeignKey(d => d.WardId)
                .HasConstraintName("FK_Bed_To_Ward");
        });

        modelBuilder.Entity<Hospital>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hospital__3214EC07ED7B8CD8");

            entity.ToTable("Hospital");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Patient__3214EC07A6879F46");

            entity.ToTable("Patient");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BedId).HasColumnName("Bed_Id");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Bed).WithMany(p => p.Patients)
                .HasForeignKey(d => d.BedId)
                .HasConstraintName("FK_Patient_To_Bed");
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ward__3214EC074CA26B75");

            entity.ToTable("Ward");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.HospitalId).HasColumnName("Hospital_Id");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Hospital).WithMany(p => p.Wards)
                .HasForeignKey(d => d.HospitalId)
                .HasConstraintName("FK_Ward_To_Hospital");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
