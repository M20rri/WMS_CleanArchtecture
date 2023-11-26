using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ARC_PUTAWAY_SCAN")]
[Index("SRNO", Name = "IX_ARC_PUTAWAY_SCAN", IsUnique = true)]
public partial class ARC_PUTAWAY_SCAN
{
    [Key]
    [Column(TypeName = "numeric(38, 0)")]
    public decimal ARCID { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [StringLength(50)]
    public string DOCNO { get; set; }

    [Required]
    [StringLength(50)]
    public string PUTNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string INVTYPE { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    public string BINNO { get; set; }

    [Required]
    [StringLength(50)]
    public string BARCODE { get; set; }

    [StringLength(250)]
    public string DESCRIPTION { get; set; }

    [StringLength(50)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    public string LOTNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SERIALNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TRACKINGTYPE { get; set; }

    public int? QTY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TRANSDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DONEDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public string ERRMSG { get; set; }

    public int? PUTSTATUS { get; set; }

    public int? INTSTATUS { get; set; }

    public int? USERPLATFORM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ARCHIVE { get; set; }
}
