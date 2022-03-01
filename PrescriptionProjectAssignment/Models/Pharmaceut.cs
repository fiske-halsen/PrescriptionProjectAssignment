using System.ComponentModel.DataAnnotations.Schema;

namespace PrescriptionProjectAssignment.Models
{
    public class Pharmaceut
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("PharmacyId")]
        public int PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }
    }
}
