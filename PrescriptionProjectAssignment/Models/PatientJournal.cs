using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrescriptionProjectAssignment.Models
{
    public class PatientJournal
    {
        public int Id { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
        public List<JournalLog> JournaLogs { get; set; } = new List<JournalLog>();
    }
}
