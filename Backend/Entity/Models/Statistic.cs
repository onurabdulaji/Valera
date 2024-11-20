using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Statistic
    {
        public int StatisticID { get; set; }
        public string StatisticClientCount { get; set; }
        public string StatisticProjectsCount { get; set; }
        public string StatisticSupportCount { get; set; }
        public string StatisticWorkerCount { get; set; }
    }
}
