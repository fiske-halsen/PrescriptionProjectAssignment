using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Patient : BaseApplicationUser
    {
        public PatientJournal PatientJournal { get; set; }
    }
}
