using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrescriptionProjectAssignment.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("PatientJournalId")]
        public int PatientJournalId { get; set; }
        public PatientJournal PatientJournal { get; set; }
        [ForeignKey("MedicineId")]
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ForeignKey("DoctorId")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
