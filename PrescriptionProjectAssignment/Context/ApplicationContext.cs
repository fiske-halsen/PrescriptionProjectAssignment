using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrescriptionProjectAssignment.Models;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Threading.Tasks;
using Npgsql;


namespace PrescriptionProjectAssignment.Context
{

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CityInfo> CityInfos { get; set; }
        public DbSet<JournalLog> JournalLogs { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<PatientJournal> PatientJournals { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Pharmaceut> Pharmaceuts { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Role> Role { get; set; }
        //test
        protected override void OnModelCreating(ModelBuilder builder)
        {
            Seed(builder);
            base.OnModelCreating(builder);
        }

        public static void Seed(ModelBuilder builder)
        {

            builder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Doctor" },
                new Role { Id = 2, Name = "Pharmaceut" },
                new Role { Id = 3, Name = "Patient" }
                );


            builder.Entity<CityInfo>().HasData(
                new CityInfo { Id = 1, ZipCode = "2630", City = "Taastrup" },
                new CityInfo { Id = 2, ZipCode = "2100", City = "Nordhavn" }
                );

            builder.Entity<Address>().HasData(
                new Address { Id = 1, Street = "Tornehegnet", CityInfoId = 1 },
                new Address { Id = 2, Street = "Brunellevej", CityInfoId = 1 },
                new Address { Id = 3, Street = "Ringkøbinggade", CityInfoId = 2 }
                );

            builder.Entity<Pharmacy>().HasData(
                new Pharmacy { Id = 1, Name = "Pharmacy Nordhavn", AddressId = 1 },
                new Pharmacy { Id = 2, Name = "Pharmarcy Taastrup", AddressId = 2 }
                );

            builder.Entity<Pharmaceut>().HasData(
                new Pharmaceut { Id = 1, FirstName = "Phillip", LastName = "Andersen", Email = "phil@ergrim.com", Password = GetHashedPassword("PhilTheGod"), PharmacyId = 1, RoleId = 2 },
                new Pharmaceut { Id = 2, FirstName = "Sebastian", LastName = "Hansen", Email = "seb@erflot.com", Password = GetHashedPassword("SebTheBot"), PharmacyId = 2, RoleId = 2 }
                );

            builder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, FirstName = "Lukas", LastName = "Stoltz-Andersen", Email = "lukas@ergrim.com", Password = GetHashedPassword("luketest123"), RoleId = 1 },
                new Doctor { Id = 2, FirstName = "Sumit", LastName = "Sumit", Email = "sumit@ergrim.com", Password = GetHashedPassword("sumittest123") , RoleId = 1  }
                );

            builder.Entity<Patient>().HasData(
                new Patient { Id = 1, FirstName = "Patient1", LastName = "Panda", Email = "Patient1@ergrim.com", Password = GetHashedPassword("Patient1"), RoleId = 3},
                new Patient { Id = 2, FirstName = "Patient2", LastName = "Ko", Email = "Patient2@ergrim.com", Password = GetHashedPassword("Patient2"), RoleId = 3 }
                );

            builder.Entity<PatientJournal>().HasData(
                new PatientJournal { Id = 1, PatientId = 1 },
                new PatientJournal { Id = 2, PatientId = 2 }
                );

            builder.Entity<Medicine>().HasData(
                new Medicine { Id = 1, Name = "Aspirin", Amount = 2, Instructions = "Take one daily", ExpirationDate = DateTime.Now.AddDays(30) },
                new Medicine { Id = 2, Name = "Cialis", Amount = 2, Instructions = "Take one daily", ExpirationDate = DateTime.Now.AddDays(30) }

                );

            builder.Entity<Prescription>().HasData(
                new Prescription { Id = 1, Name = "Test", PatientJournalId = 1, MedicineId = 1, DoctorId = 1 },
                 new Prescription { Id = 2, Name = "Test", PatientJournalId = 2, MedicineId = 2, DoctorId = 2 }
                );
        }

        public static string GetHashedPassword(string password)
        {
            byte[] salt = new byte[128 / 8];

            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

            return hashed;
        }

       

    }
}
