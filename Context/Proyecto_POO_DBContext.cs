using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_POO_DB
{
    public partial class Proyecto_POO_DBContext : DbContext
    {
        public Proyecto_POO_DBContext()
        {
        }

        public Proyecto_POO_DBContext(DbContextOptions<Proyecto_POO_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Registry> Registries { get; set; }
        public virtual DbSet<SecondaryEffect> SecondaryEffects { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }
        public virtual DbSet<VaccinationProcess> VaccinationProcesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=PROYECTO_BD_POO;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.CabinNumber).HasColumnName("Cabin_number");

                entity.Property(e => e.DateHour)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_hour");

                entity.Property(e => e.DuiCitizen).HasColumnName("Dui_citizen");

                entity.Property(e => e.IdEmployee).HasColumnName("Id_employee");

                entity.HasOne(d => d.CabinNumberNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.CabinNumber)
                    .HasConstraintName("FK_Cabin_number");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DuiCitizen)
                    .HasConstraintName("FK_Dui_citizen");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK_Id_employee");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.HasKey(e => e.CabinNumber)
                    .HasName("PK__CABIN__243A3277D917687E");

                entity.ToTable("CABIN");

                entity.Property(e => e.CabinNumber).HasColumnName("Cabin_number");

                entity.Property(e => e.AdressCabin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Adress_cabin");

                entity.Property(e => e.EmailCabin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email_cabin");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__C0317D901DD7CD0F");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui).ValueGeneratedNever();

                entity.Property(e => e.AddressCitizen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Address_citizen");

                entity.Property(e => e.EmailCitizen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email_citizen");

                entity.Property(e => e.IdEmployee).HasColumnName("Id_employee");

                entity.Property(e => e.IdPosition).HasColumnName("Id_position");

                entity.Property(e => e.InstitutionalIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Institutional_identifier");

                entity.Property(e => e.LastnameCitizen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastname_citizen");

                entity.Property(e => e.NameCitizen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_citizen");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK_Id_employee_citizen");

                entity.HasOne(d => d.IdPositionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdPosition)
                    .HasConstraintName("FK_Id_position");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("DISEASE");

                entity.Property(e => e.Disease1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Disease");

                entity.Property(e => e.DuiCitizen).HasColumnName("Dui_citizen");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Diseases)
                    .HasForeignKey(d => d.DuiCitizen)
                    .HasConstraintName("FK_Dui_citizen_disease");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddresUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Addres_user");

                entity.Property(e => e.IdTypeEmployee).HasColumnName("id_type_employee");

                entity.Property(e => e.InstitutionalMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institutional_mail");

                entity.Property(e => e.LastnameUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Lastname_user");

                entity.Property(e => e.NameUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Name_user");

                entity.Property(e => e.PasswordUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Password_user");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTypeEmployeeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdTypeEmployee)
                    .HasConstraintName("FK_Id_type_employee");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("POSITION");

                entity.Property(e => e.Position1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Position");
            });

            modelBuilder.Entity<Registry>(entity =>
            {
                entity.HasKey(e => new { e.CabinNumber, e.IdEmployee })
                    .HasName("PK_registry");

                entity.ToTable("REGISTRY");

                entity.Property(e => e.CabinNumber).HasColumnName("Cabin_number");

                entity.Property(e => e.IdEmployee).HasColumnName("Id_employee");

                entity.Property(e => e.DateHour)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_hour");

                entity.HasOne(d => d.CabinNumberNavigation)
                    .WithMany(p => p.Registries)
                    .HasForeignKey(d => d.CabinNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cabin_number_registry");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Registries)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Id_employee_registry");
            });

            modelBuilder.Entity<SecondaryEffect>(entity =>
            {
                entity.ToTable("SECONDARY_EFFECT");

                entity.Property(e => e.EffectMinutes).HasColumnName("Effect_minutes");

                entity.Property(e => e.IdProcess).HasColumnName("Id_process");

                entity.Property(e => e.SecondaryEffect1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Secondary_effect");

                entity.HasOne(d => d.IdProcessNavigation)
                    .WithMany(p => p.SecondaryEffects)
                    .HasForeignKey(d => d.IdProcess)
                    .HasConstraintName("FK_Id_process");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.ToTable("TYPE_EMPLOYEE");

                entity.Property(e => e.TypeEmployee1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Type_employee");
            });

            modelBuilder.Entity<VaccinationProcess>(entity =>
            {
                entity.ToTable("VACCINATION_PROCESS");

                entity.Property(e => e.CabinNumber).HasColumnName("Cabin_number");

                entity.Property(e => e.DuiCitizen).HasColumnName("Dui_citizen");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.RowDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Row_date_time");

                entity.Property(e => e.SeconddoseCabin).HasColumnName("Seconddose_cabin");

                entity.Property(e => e.SeconddoseDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Seconddose_date_time");

                entity.Property(e => e.VaccinationDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Vaccination_date_time");

                entity.HasOne(d => d.CabinNumberNavigation)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.CabinNumber)
                    .HasConstraintName("FK_Cabin_number_process");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.DuiCitizen)
                    .HasConstraintName("FK_Dui_citizen_process");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK_Id_employee_process");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
