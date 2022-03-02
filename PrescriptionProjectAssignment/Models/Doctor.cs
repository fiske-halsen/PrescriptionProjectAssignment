using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();
        [ForeignKey("RoleId")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
