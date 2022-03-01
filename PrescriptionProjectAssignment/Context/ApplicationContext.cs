using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrescriptionProjectAssignment.Models;

namespace PrescriptionProjectAssignment.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Address> Addresses { get; set; } //tjek
        public DbSet<CityInfo> CityInfos { get; set; }  //tjek
        public DbSet<JournalLog> JournalLogs { get; set; }  
        public DbSet<Medicine> Medicines { get; set; }  
        public DbSet<PatientJournal> PatientJournals { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; } //Tjek
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Pharmaceut> Pharmaceuts { get; set; }  //tjek
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public static void Seed(ModelBuilder builder) 
        {
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
                new Pharmacy { Name = "Pharmacy Nordhavn", AddressId = 1},
                new Pharmacy { Name = "Pharmarcy Taastrup", AddressId = 2}
                );

            var pharmaceut1 = new Pharmaceut { FirstName = "Phillip", LastName = "Andersen", Email = "phil@ergrim.com", Password = "philtest123", PharmarcyId = 2 };
            var pharmeceut2 = new Pharmaceut { FirstName = "Sebastian", LastName = "Hansen", Email = "seb@erflot.com", Password = "sebtest123", PharmarcyId = 1 };
            var hasher = new PasswordHasher<Pharmaceut>();
            var pass1 = hasher.HashPassword(pharmaceut1, pharmaceut1.Password);
            var pass2 = hasher.HashPassword(pharmeceut2, pharmeceut2.Password);


            builder.Entity<Pharmaceut>().HasData(
                new Pharmaceut { FirstName = "Phillip", LastName = "Andersen", Email = "phil@ergrim.com", Password = "philtest123", PharmarcyId = 2},
                new Pharmaceut { FirstName = "Sebastian", LastName = "Hansen", Email = "seb@erflot.com", Password = "sebtest123", PharmarcyId = 1 }
                );

            builder.Entity<Doctor>().HasData(
                new Doctor { FirstName = "Lukas", LastName = "Stoltz-Andersen", Email = "lukas@ergrim.com", Password = "luketest123" },
                new Doctor { FirstName = "Lukas", LastName = "Stoltz-Andersen", Email = "lukas@ergrim.com", Password = "luketest123" },
                );

            builder.Entity<Prescription>().HasData(
                new Prescription { }
                );
        }

    }

}
