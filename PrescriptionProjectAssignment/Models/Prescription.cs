using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PatientJournal PatientJournal { get; set; }
        public Medicine Medicine { get; set; }
        public DateTime CreatedAt { get; set; }
        public Doctor Doctor { get; set; }
    }
}
