using System;
using System.Collections.Generic;
using System.Text;

namespace MyPolicies.Models
{
    public class Policy
    {
        public string PolicyNumber { get; set; }
        public string PolicyType { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string VIN { get; set; }
        public decimal PremiumAmount { get; set; }
    }
}
