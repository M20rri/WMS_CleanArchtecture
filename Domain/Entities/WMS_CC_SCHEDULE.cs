using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_CC_SCHEDULE")]
public partial class WMS_CC_SCHEDULE
{
    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TDATE { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    public string REASON { get; set; }

    [StringLength(255)]
    public string REMARKS { get; set; }

    public int? STATUS { get; set; }
}
