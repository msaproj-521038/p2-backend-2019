using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeriodicTable.Model
{
    public partial class UserInfo
    {
        [Key]
        [Column("USER_ID")]
        public int UserId { get; set; }
        [Required]
        [Column("USERNAME", TypeName = "text")]
        public string Username { get; set; }
        [Column("ATOMICNUMBER_1")]
        public int? Atomicnumber1 { get; set; }
        [Column("ATOMICNUMBER_2")]
        public int? Atomicnumber2 { get; set; }
        [Column("ATOMICNUMBER_3")]
        public int? Atomicnumber3 { get; set; }
    }
}
