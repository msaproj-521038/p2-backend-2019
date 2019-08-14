using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodicTable.Model
{
    public partial class ElementsBasicInformation
    {
        [Key]
        public int AtomicNumber { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Symbol { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Name { get; set; }
        public float? AtomicMass { get; set; }
        [Column("X_Position")]
        public int XPosition { get; set; }
        [Column("Y_Position")]
        public int YPosition { get; set; }
    }
}
