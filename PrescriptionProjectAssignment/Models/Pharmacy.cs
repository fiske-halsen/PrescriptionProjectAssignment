using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Pharmacy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pharmaceut> Pharmaceuts { get; set; } = new List<Pharmaceut>();
        [ForeignKey("AddressId")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
