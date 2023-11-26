using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_CC_SCAN")]
[Index("DOCNO", Name = "IX_WMS_CC_SCAN")]
[Index("CCNO", Name = "IX_WMS_CC_SCAN_1")]
[Index("T_ZONEID", Name = "IX_WMS_CC_SCAN_2")]
[Index("T_BINNO", Name = "IX_WMS_CC_SCAN_3")]
[Index("BARCODE", Name = "IX_WMS_CC_SCAN_4")]
[Index("WAREHOUSENO", Name = "IX_WMS_CC_SCAN_5")]
public partial class WMS_CC_SCAN
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TRANSDATE { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    public string CCNO { get; set; }

    [StringLength(50)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    public string F_ZONEID { get; set; }

    [StringLength(50)]
    public string F_BINNO { get; set; }

    [StringLength(50)]
    public string T_ZONEID { get; set; }

    [StringLength(50)]
    public string T_BINNO { get; set; }

    public int? USERID { get; set; }

    public int? PNA { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }
}
