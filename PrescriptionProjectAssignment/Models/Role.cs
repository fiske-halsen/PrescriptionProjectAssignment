using System.Collections.Generic;

namespace PrescriptionProjectAssignment.Models
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Patient> Patients { get; set; } = new List<Patient>();

        public List<Doctor> Doctors { get; set; } = new List<Doctor>();

        public List<Pharmaceut> Pharmaceuts { get; set; } = new List<Pharmaceut>();

    }
}
