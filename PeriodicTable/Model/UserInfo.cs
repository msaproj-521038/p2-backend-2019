using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodicTable.Model
{
    public partial class UserInfo
    {
        [Key]
        [Column("User_ID")]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string UserName { get; set; }
        [Column("AtomicNumber_1")]
        public int? AtomicNumber1 { get; set; }
        [Column("AtomicNumber_2")]
        public int? AtomicNumber2 { get; set; }
        [Column("AtomicNumber_3")]
        public int? AtomicNumber3 { get; set; }

        [ForeignKey("AtomicNumber1")]
        [InverseProperty("UserInfoAtomicNumber1Navigation")]
        public virtual ElementsBasicInformation AtomicNumber1Navigation { get; set; }
        [ForeignKey("AtomicNumber2")]
        [InverseProperty("UserInfoAtomicNumber2Navigation")]
        public virtual ElementsBasicInformation AtomicNumber2Navigation { get; set; }
        [ForeignKey("AtomicNumber3")]
        [InverseProperty("UserInfoAtomicNumber3Navigation")]
        public virtual ElementsBasicInformation AtomicNumber3Navigation { get; set; }
    }
}
