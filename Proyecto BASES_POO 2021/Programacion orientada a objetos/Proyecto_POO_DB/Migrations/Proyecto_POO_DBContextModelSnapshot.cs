﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_POO_DB;

namespace Proyecto_POO_DB.Migrations
{
    [DbContext(typeof(Proyecto_POO_DBContext))]
    partial class Proyecto_POO_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto_POO_DB.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CabinNumber")
                        .HasColumnType("int")
                        .HasColumnName("Cabin_number");

                    b.Property<DateTime?>("DateHour")
                        .HasColumnType("datetime")
                        .HasColumnName("Date_hour");

                    b.Property<int?>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("Dui_citizen");

                    b.Property<int?>("IdEmployee")
                        .HasColumnType("int")
                        .HasColumnName("Id_employee");

                    b.HasKey("Id");

                    b.HasIndex("CabinNumber");

                    b.HasIndex("DuiCitizen");

                    b.HasIndex("IdEmployee");

                    b.ToTable("APPOINTMENT");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Cabin", b =>
                {
                    b.Property<int>("CabinNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Cabin_number")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdressCabin")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Adress_cabin");

                    b.Property<string>("EmailCabin")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Email_cabin");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.HasKey("CabinNumber")
                        .HasName("PK__CABIN__243A3277D917687E");

                    b.ToTable("CABIN");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Citizen", b =>
                {
                    b.Property<int>("Dui")
                        .HasColumnType("int");

                    b.Property<string>("AddressCitizen")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Address_citizen");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("EmailCitizen")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Email_citizen");

                    b.Property<int?>("IdEmployee")
                        .HasColumnType("int")
                        .HasColumnName("Id_employee");

                    b.Property<int?>("IdPosition")
                        .HasColumnType("int")
                        .HasColumnName("Id_position");

                    b.Property<string>("InstitutionalIdentifier")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Institutional_identifier");

                    b.Property<string>("LastnameCitizen")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastname_citizen");

                    b.Property<string>("NameCitizen")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name_citizen");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Dui")
                        .HasName("PK__CITIZEN__C0317D901DD7CD0F");

                    b.HasIndex("IdEmployee");

                    b.HasIndex("IdPosition");

                    b.ToTable("CITIZEN");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Disease1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Disease");

                    b.Property<int?>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("Dui_citizen");

                    b.HasKey("Id");

                    b.HasIndex("DuiCitizen");

                    b.ToTable("DISEASE");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Employee", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("AddresUser")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Addres_user");

                    b.Property<int?>("IdTypeEmployee")
                        .HasColumnType("int")
                        .HasColumnName("id_type_employee");

                    b.Property<string>("InstitutionalMail")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("institutional_mail");

                    b.Property<string>("LastnameUser")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Lastname_user");

                    b.Property<string>("NameUser")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name_user");

                    b.Property<string>("PasswordUser")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Password_user");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdTypeEmployee");

                    b.ToTable("EMPLOYEE");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Position1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Position");

                    b.HasKey("Id");

                    b.ToTable("POSITION");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Registry", b =>
                {
                    b.Property<int>("CabinNumber")
                        .HasColumnType("int")
                        .HasColumnName("Cabin_number");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int")
                        .HasColumnName("Id_employee");

                    b.Property<DateTime?>("DateHour")
                        .HasColumnType("datetime")
                        .HasColumnName("Date_hour");

                    b.HasKey("CabinNumber", "IdEmployee")
                        .HasName("PK_registry");

                    b.HasIndex("IdEmployee");

                    b.ToTable("REGISTRY");
                });

            modelBuilder.Entity("Proyecto_POO_DB.SecondaryEffect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EffectMinutes")
                        .HasColumnType("int")
                        .HasColumnName("Effect_minutes");

                    b.Property<int?>("IdProcess")
                        .HasColumnType("int")
                        .HasColumnName("Id_process");

                    b.Property<string>("SecondaryEffect1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Secondary_effect");

                    b.HasKey("Id");

                    b.HasIndex("IdProcess");

                    b.ToTable("SECONDARY_EFFECT");
                });

            modelBuilder.Entity("Proyecto_POO_DB.TypeEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeEmployee1")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Type_employee");

                    b.HasKey("Id");

                    b.ToTable("TYPE_EMPLOYEE");
                });

            modelBuilder.Entity("Proyecto_POO_DB.VaccinationProcess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CabinNumber")
                        .HasColumnType("int")
                        .HasColumnName("Cabin_number");

                    b.Property<int?>("DuiCitizen")
                        .HasColumnType("int")
                        .HasColumnName("Dui_citizen");

                    b.Property<int?>("IdEmployee")
                        .HasColumnType("int")
                        .HasColumnName("id_employee");

                    b.Property<DateTime?>("RowDateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Row_date_time");

                    b.Property<int?>("SeconddoseCabin")
                        .HasColumnType("int")
                        .HasColumnName("Seconddose_cabin");

                    b.Property<DateTime?>("SeconddoseDateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Seconddose_date_time");

                    b.Property<DateTime?>("VaccinationDateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Vaccination_date_time");

                    b.HasKey("Id");

                    b.HasIndex("CabinNumber");

                    b.HasIndex("DuiCitizen");

                    b.HasIndex("IdEmployee");

                    b.ToTable("VACCINATION_PROCESS");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Appointment", b =>
                {
                    b.HasOne("Proyecto_POO_DB.Cabin", "CabinNumberNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("CabinNumber")
                        .HasConstraintName("FK_Cabin_number");

                    b.HasOne("Proyecto_POO_DB.Citizen", "DuiCitizenNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_Dui_citizen");

                    b.HasOne("Proyecto_POO_DB.Employee", "IdEmployeeNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("FK_Id_employee");

                    b.Navigation("CabinNumberNavigation");

                    b.Navigation("DuiCitizenNavigation");

                    b.Navigation("IdEmployeeNavigation");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Citizen", b =>
                {
                    b.HasOne("Proyecto_POO_DB.Employee", "IdEmployeeNavigation")
                        .WithMany("Citizens")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("FK_Id_employee_citizen");

                    b.HasOne("Proyecto_POO_DB.Position", "IdPositionNavigation")
                        .WithMany("Citizens")
                        .HasForeignKey("IdPosition")
                        .HasConstraintName("FK_Id_position");

                    b.Navigation("IdEmployeeNavigation");

                    b.Navigation("IdPositionNavigation");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Disease", b =>
                {
                    b.HasOne("Proyecto_POO_DB.Citizen", "DuiCitizenNavigation")
                        .WithMany("Diseases")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_Dui_citizen_disease");

                    b.Navigation("DuiCitizenNavigation");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Employee", b =>
                {
                    b.HasOne("Proyecto_POO_DB.TypeEmployee", "IdTypeEmployeeNavigation")
                        .WithMany("Employees")
                        .HasForeignKey("IdTypeEmployee")
                        .HasConstraintName("FK_Id_type_employee");

                    b.Navigation("IdTypeEmployeeNavigation");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Registry", b =>
                {
                    b.HasOne("Proyecto_POO_DB.Cabin", "CabinNumberNavigation")
                        .WithMany("Registries")
                        .HasForeignKey("CabinNumber")
                        .HasConstraintName("FK_Cabin_number_registry")
                        .IsRequired();

                    b.HasOne("Proyecto_POO_DB.Employee", "IdEmployeeNavigation")
                        .WithMany("Registries")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("FK_Id_employee_registry")
                        .IsRequired();

                    b.Navigation("CabinNumberNavigation");

                    b.Navigation("IdEmployeeNavigation");
                });

            modelBuilder.Entity("Proyecto_POO_DB.SecondaryEffect", b =>
                {
                    b.HasOne("Proyecto_POO_DB.VaccinationProcess", "IdProcessNavigation")
                        .WithMany("SecondaryEffects")
                        .HasForeignKey("IdProcess")
                        .HasConstraintName("FK_Id_process");

                    b.Navigation("IdProcessNavigation");
                });

            modelBuilder.Entity("Proyecto_POO_DB.VaccinationProcess", b =>
                {
                    b.HasOne("Proyecto_POO_DB.Cabin", "CabinNumberNavigation")
                        .WithMany("VaccinationProcesses")
                        .HasForeignKey("CabinNumber")
                        .HasConstraintName("FK_Cabin_number_process");

                    b.HasOne("Proyecto_POO_DB.Citizen", "DuiCitizenNavigation")
                        .WithMany("VaccinationProcesses")
                        .HasForeignKey("DuiCitizen")
                        .HasConstraintName("FK_Dui_citizen_process");

                    b.HasOne("Proyecto_POO_DB.Employee", "IdEmployeeNavigation")
                        .WithMany("VaccinationProcesses")
                        .HasForeignKey("IdEmployee")
                        .HasConstraintName("FK_Id_employee_process");

                    b.Navigation("CabinNumberNavigation");

                    b.Navigation("DuiCitizenNavigation");

                    b.Navigation("IdEmployeeNavigation");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Cabin", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Registries");

                    b.Navigation("VaccinationProcesses");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Citizen", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Diseases");

                    b.Navigation("VaccinationProcesses");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Employee", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Citizens");

                    b.Navigation("Registries");

                    b.Navigation("VaccinationProcesses");
                });

            modelBuilder.Entity("Proyecto_POO_DB.Position", b =>
                {
                    b.Navigation("Citizens");
                });

            modelBuilder.Entity("Proyecto_POO_DB.TypeEmployee", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Proyecto_POO_DB.VaccinationProcess", b =>
                {
                    b.Navigation("SecondaryEffects");
                });
#pragma warning restore 612, 618
        }
    }
}
