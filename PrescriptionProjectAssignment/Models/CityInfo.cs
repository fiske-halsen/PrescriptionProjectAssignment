using System.Collections.Generic;

namespace PrescriptionProjectAssignment.Models
{
    public class CityInfo
    {
        public int Id { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}