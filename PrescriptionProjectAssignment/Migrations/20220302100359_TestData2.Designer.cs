// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PrescriptionProjectAssignment.Context;

namespace PrescriptionProjectAssignment.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220302100359_TestData2")]
    partial class TestData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CityInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CityInfoId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityInfoId = 1,
                            Street = "Tornehegnet"
                        },
                        new
                        {
                            Id = 2,
                            CityInfoId = 1,
                            Street = "Brunellevej"
                        },
                        new
                        {
                            Id = 3,
                            CityInfoId = 2,
                            Street = "Ringkøbinggade"
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.CityInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CityInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Taastrup",
                            ZipCode = "2630"
                        },
                        new
                        {
                            Id = 2,
                            City = "Nordhavn",
                            ZipCode = "2100"
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "lukas@ergrim.com",
                            FirstName = "Lukas",
                            LastName = "Stoltz-Andersen",
                            Password = "RNrTUetwFrZLMx51Hm6BW5h67udQrhKonQdv464EGjI=",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "sumit@ergrim.com",
                            FirstName = "Sumit",
                            LastName = "Sumit",
                            Password = "igilO4o+YjhTZsNXoSvCP7VxzFSEV8GRVqysWsYyjoo=",
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.JournalLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("LastAccess")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("PatientJournalId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PatientJournalId");

                    b.ToTable("JournalLogs");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Instructions")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Medicines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 2,
                            ExpirationDate = new DateTime(2022, 4, 1, 11, 3, 58, 385, DateTimeKind.Local).AddTicks(3405),
                            Instructions = "Take one daily",
                            Name = "Aspirin"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 2,
                            ExpirationDate = new DateTime(2022, 4, 1, 11, 3, 58, 387, DateTimeKind.Local).AddTicks(7167),
                            Instructions = "Take one daily",
                            Name = "Cialis"
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Patient1@ergrim.com",
                            FirstName = "Patient1",
                            LastName = "Panda",
                            Password = "8bMzVQEBgcuhpLGvRc0Dkm9iTU0dsqMWuVOPJrBj8sk=",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 2,
                            Email = "Patient2@ergrim.com",
                            FirstName = "Patient2",
                            LastName = "Ko",
                            Password = "exA65Jcj/uk66Fork2RONfMfriHx/b4Bep6sH1547aY=",
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.PatientJournal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("PatientId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("PatientJournals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PatientId = 1
                        },
                        new
                        {
                            Id = 2,
                            PatientId = 2
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Pharmaceut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<int>("PharmacyId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PharmacyId");

                    b.HasIndex("RoleId");

                    b.ToTable("Pharmaceuts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "phil@ergrim.com",
                            FirstName = "Phillip",
                            LastName = "Andersen",
                            Password = "MRquQUi6vMwKXikV6V6ypugICs3iTidc6sFYkVWJEfY=",
                            PharmacyId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            Id = 2,
                            Email = "seb@erflot.com",
                            FirstName = "Sebastian",
                            LastName = "Hansen",
                            Password = "a+Fb6sjnEbb0TD3zWFUldu3zaE2bNouFuiTeWaO7xck=",
                            PharmacyId = 2,
                            RoleId = 2
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Pharmacy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Pharmacies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Name = "Pharmacy Nordhavn"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            Name = "Pharmarcy Taastrup"
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<int>("MedicineId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PatientJournalId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PatientJournalId");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 3, 2, 11, 3, 58, 387, DateTimeKind.Local).AddTicks(8170),
                            DoctorId = 1,
                            MedicineId = 1,
                            Name = "Test",
                            PatientJournalId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 3, 2, 11, 3, 58, 387, DateTimeKind.Local).AddTicks(9426),
                            DoctorId = 2,
                            MedicineId = 2,
                            Name = "Test",
                            PatientJournalId = 2
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Doctor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pharmaceut"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Patient"
                        });
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Address", b =>
                {
                    b.HasOne("PrescriptionProjectAssignment.Models.CityInfo", "CityInfo")
                        .WithMany("Addresses")
                        .HasForeignKey("CityInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CityInfo");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Doctor", b =>
                {
                    b.HasOne("PrescriptionProjectAssignment.Models.Role", "Role")
                        .WithMany("Doctors")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.JournalLog", b =>
                {
                    b.HasOne("PrescriptionProjectAssignment.Models.PatientJournal", "PatientJournal")
                        .WithMany("JournaLogs")
                        .HasForeignKey("PatientJournalId");

                    b.Navigation("PatientJournal");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Patient", b =>
                {
                    b.HasOne("PrescriptionProjectAssignment.Models.Role", "Role")
                        .WithMany("Patients")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.PatientJournal", b =>
                {
                    b.HasOne("PrescriptionProjectAssignment.Models.Patient", "Patient")
                        .WithOne("PatientJournal")
                        .HasForeignKey("PrescriptionProjectAssignment.Models.PatientJournal", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Pharmaceut", b =>
                {
                    b.HasOne("PrescriptionProjectAssignment.Models.Pharmacy", "Pharmacy")
                        .WithMany("Pharmaceuts")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrescriptionProjectAssignment.Models.Role", "Role")
                        .WithMany("Pharmaceuts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pharmacy");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Pharmacy", b =>
                {
                    b.HasOne("PrescriptionProjectAssignment.Models.Address", "Address")
                        .WithOne("Pharmacy")
                        .HasForeignKey("PrescriptionProjectAssignment.Models.Pharmacy", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Prescription", b =>
                {
                    b.HasOne("PrescriptionProjectAssignment.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrescriptionProjectAssignment.Models.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrescriptionProjectAssignment.Models.PatientJournal", "PatientJournal")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientJournalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Medicine");

                    b.Navigation("PatientJournal");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Address", b =>
                {
                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.CityInfo", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Patient", b =>
                {
                    b.Navigation("PatientJournal");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.PatientJournal", b =>
                {
                    b.Navigation("JournaLogs");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Pharmacy", b =>
                {
                    b.Navigation("Pharmaceuts");
                });

            modelBuilder.Entity("PrescriptionProjectAssignment.Models.Role", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Patients");

                    b.Navigation("Pharmaceuts");
                });
#pragma warning restore 612, 618
        }
    }
}
