using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_CC_REQUEST")]
[Index("BINNO", Name = "IX_WMS_CC_REQUEST")]
[Index("DOCNO", Name = "IX_WMS_CC_REQUEST_1")]
[Index("ZONEID", Name = "IX_WMS_CC_REQUEST_2")]
[Index("WAREHOUSENO", Name = "IX_WMS_CC_REQUEST_3")]
public partial class WMS_CC_REQUEST
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    public string DOCNO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOCDATE { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    public string BINNO { get; set; }

    public int? USERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TDATE { get; set; }

    [StringLength(250)]
    public string REMARKS { get; set; }

    public int? CLOSEDBY { get; set; }

    public int? STATUS { get; set; }

    public int? ACHIVE { get; set; }
}
