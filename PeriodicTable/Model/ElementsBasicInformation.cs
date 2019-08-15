using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodicTable.Model
{
    public partial class ElementsBasicInformation
    {
        public ElementsBasicInformation()
        {
            UserInfoAtomicNumber1Navigation = new HashSet<UserInfo>();
            UserInfoAtomicNumber2Navigation = new HashSet<UserInfo>();
            UserInfoAtomicNumber3Navigation = new HashSet<UserInfo>();
        }
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

        [InverseProperty("AtomicNumberNavigation")]
        public virtual ElementsExtraInformation ElementsExtraInformation { get; set; }
        [InverseProperty("AtomicNumber1Navigation")]
        public virtual ICollection<UserInfo> UserInfoAtomicNumber1Navigation { get; set; }
        [InverseProperty("AtomicNumber2Navigation")]
        public virtual ICollection<UserInfo> UserInfoAtomicNumber2Navigation { get; set; }
        [InverseProperty("AtomicNumber3Navigation")]
        public virtual ICollection<UserInfo> UserInfoAtomicNumber3Navigation { get; set; }
    }
}
