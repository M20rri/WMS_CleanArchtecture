using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_CYCLECOUNT")]
[Index("USERID", Name = "IX_WMS_CYCLECOUNT")]
[Index("USERID", "CCNO", "WAREHOUSENO", Name = "IX_WMS_CYCLECOUNT_2")]
[Index("WAREHOUSENO", "DOCNO", "CCNO", Name = "IX_WMS_CYCLECOUNT_5")]
public partial class WMS_CYCLECOUNT
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [Required]
    [StringLength(50)]
    public string DOCNO { get; set; }

    [Required]
    [StringLength(50)]
    public string CCNO { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    public string BINNO { get; set; }

    [Required]
    [StringLength(50)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    public string LOTNO { get; set; }

    [StringLength(250)]
    public string DESCRIPTION { get; set; }

    [StringLength(50)]
    public string UOM { get; set; }

    [StringLength(50)]
    public string QTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    public int? USERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? USERASSIGNDATE { get; set; }

    public bool? ASSIGNSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TRANSDATE { get; set; }

    [StringLength(50)]
    public string F_BINNO { get; set; }

    [StringLength(50)]
    public string F_ZONEID { get; set; }

    [StringLength(50)]
    public string T_BINNO { get; set; }

    [StringLength(50)]
    public string T_ZONEID { get; set; }

    public int? SEDSTATUS { get; set; }

    public int? CCSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public string ERRMSG { get; set; }

    public int? ARCHIVE { get; set; }
}
