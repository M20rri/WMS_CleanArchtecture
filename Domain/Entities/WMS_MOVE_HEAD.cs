using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_MOVE_HEAD")]
[Index("DOCNO", Name = "IX_WMS_MOVE_HEAD_3", IsUnique = true)]
public partial class WMS_MOVE_HEAD
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? PICKUSERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PICKUSER { get; set; }

    public int? QTY1 { get; set; }

    public int? QTY2 { get; set; }

    public int? PUTUSERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PUTUSER { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DONEDATE { get; set; }

    public int? DOCSTATUS { get; set; }

    public int? USERPLATFORM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ARCHIVE { get; set; }
}
