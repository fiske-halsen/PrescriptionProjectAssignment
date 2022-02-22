using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class PatientJournal
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
        public List<JournalLog> JournaLogs {  get; set; } = new List<JournalLog>();
    }
}
