using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeriodicTable.Models
{
    public class Element
    {
        [Key]
        public int AtomicNumber { get; set; }

        [Required]
        public string Symbol { get; set; }
        [Required]
        public string Name { get; set; }

        public string ElectronConfiguration { get; set; }
        public string BondingType { get; set; }
        public string GroupBlock { get; set; }
        public string AtomicMass { get; set; }
        public string AtomicRadius { get; set; }
        public string FirstIonisationEnergy { get; set; }
        public int X_Position {get; set; }
        public int Y_Position { get; set; }
        public string MeltingPoint { get; set; }
        public string BoilingPoint { get; set; }
    }
}
