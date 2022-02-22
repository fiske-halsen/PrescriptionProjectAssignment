using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public CityInfo CityInfo { get; set; }
        public Pharmacy Pharmacy { get; set; }
    }
}
