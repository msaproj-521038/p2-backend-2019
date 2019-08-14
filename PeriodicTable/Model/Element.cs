using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodicTable.Model
{
    public partial class Element
    {
        [Key]
        public int AtomicNumber { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Symbol { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string ElectronConfiguration { get; set; }
        [Column(TypeName = "text")]
        public string BondingType { get; set; }
        [Column(TypeName = "text")]
        public string GroupBlock { get; set; }
        [Column(TypeName = "text")]
        public string AtomicMass { get; set; }
        [Column(TypeName = "text")]
        public string AtomicRadius { get; set; }
        [Column(TypeName = "text")]
        public string FirstIonisationEnergy { get; set; }
        [Column("X_Position")]
        public int XPosition { get; set; }
        [Column("Y_Position")]
        public int YPosition { get; set; }
        [Column(TypeName = "text")]
        public string MeltingPoint { get; set; }
        [Column(TypeName = "text")]
        public string BoilingPoint { get; set; }
    }
}
