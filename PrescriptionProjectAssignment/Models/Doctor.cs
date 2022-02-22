using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Doctor : BaseApplicationUser
    {
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}
