using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrescriptionProjectAssignment.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public int Amount { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
