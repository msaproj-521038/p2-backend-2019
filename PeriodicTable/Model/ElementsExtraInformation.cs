using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodicTable.Model
{
    public partial class ElementsExtraInformation
    {
        [Key]
        public int AtomicNumber { get; set; }
        [Column(TypeName = "text")]
        public string ElectronConfiguration { get; set; }
        [Column(TypeName = "text")]
        public string BondingType { get; set; }
        [Column(TypeName = "text")]
        public string GroupBlock { get; set; }
        public int? AtomicRadius { get; set; }
        public int? FirstIonisationEnergy { get; set; }
        public int? MeltingPoint { get; set; }
        public int? BoilingPoint { get; set; }

        [ForeignKey("AtomicNumber")]
        [InverseProperty("ElementsExtraInformation")]
        public virtual ElementsBasicInformation AtomicNumberNavigation { get; set; }
    }
}
