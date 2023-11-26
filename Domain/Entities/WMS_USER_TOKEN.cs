using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_USER_TOKEN")]
[Index("USERID", Name = "IX_WMS_USER_TOKEN")]
public partial class WMS_USER_TOKEN
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    public string TOKENID { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERPLATFORM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TDATE { get; set; }

    public int? INTERVAL { get; set; }

    public int? STATUS { get; set; }
}
