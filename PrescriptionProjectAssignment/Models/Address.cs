using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        [ForeignKey("CityInfoId")]
        public int CityInfoId { get; set; }
        public CityInfo CityInfo { get; set; }
        public Pharmacy Pharmacy { get; set; }
    }
}
