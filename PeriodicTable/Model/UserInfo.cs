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
        public string Username { get; set; }
        [Column("Atomicnumber_1")]
        public int? Atomicnumber1 { get; set; }
        [Column("Atomicnumber_2")]
        public int? Atomicnumber2 { get; set; }
        [Column("Atomicnumber_3")]
        public int? Atomicnumber3 { get; set; }
    }
}
