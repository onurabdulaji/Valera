using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Pricing
    {
        public int PricingID { get; set; }
        public string PricingTitle { get; set; }
        public decimal PricingPrice { get; set; }
        public string PricingExclusive1 { get; set; }
        public string PricingExclusive2 { get; set; }
        public string PricingExclusive3 { get; set; }
        public string PricingExclusive4 { get; set; }
        public string PricingExclusive5 { get; set; }
    }
}
