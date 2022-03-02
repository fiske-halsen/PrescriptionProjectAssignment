using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class JournalLog
    {
        public int Id { get; set; }
        public DateTime LastAccess { get; set; }
        public PatientJournal PatientJournal { get; set; }
    }
}
