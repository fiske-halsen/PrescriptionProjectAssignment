using Microsoft.AspNetCore.Identity;

namespace PrescriptionProjectAssignment.Models
{
    public class BaseApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
