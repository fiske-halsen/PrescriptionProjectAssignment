using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Patient : BaseApplicationUser
    {
        [ForeignKey("PatientJournalId")]
        public int PatientJournalId { get; set; }
        public PatientJournal PatientJournal { get; set; }
    }
}
