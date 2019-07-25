using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileInfoAPI.Models
{
    public class MobileSpecs
    {
        public int Id { get; set; }
        public string ModelNumber { get; set; }
        public string ModelName { get; set; }
        public string Company { get; set; }
        public string Processor { get; set; }
        public int BatteryRating { get; set; }
        public double PhoneLength { get; set; }
        public double PhoneWidth { get; set; }
        public double ScreenLength { get; set; }
        public double ScreenWidth { get; set; }
    }
}
