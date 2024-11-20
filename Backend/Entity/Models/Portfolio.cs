using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Portfolio
    {
        public int PortfolioID { get; set; }
        public string PortfolioTitle { get; set; }
        public string PortfolioShortTitle { get; set; }
        public string PortfolioLinkUrl { get; set; }
    }
}
