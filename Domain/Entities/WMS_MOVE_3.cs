using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_MOVE_3")]
[Index("DOCNO", "BARCODE", Name = "IX_WMS_MOVE_3", IsUnique = true)]
public partial class WMS_MOVE_3
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOTNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SERIALNO { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string ITEMDESC { get; set; }

    public int? QTY1 { get; set; }

    public int? QTY2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string STAGEBINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SYSBINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SYSZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    [StringLength(50)]
    public string BINNO_1 { get; set; }

    [StringLength(50)]
    public string BINNO_2 { get; set; }

    [StringLength(50)]
    public string BINNO_3 { get; set; }

    [StringLength(50)]
    public string BINNO_4 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ITEMTYPE { get; set; }

    public int? MOVSTATUS { get; set; }

    public int? DOCSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DONEDATE { get; set; }

    public int? USERPLATFORM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    public int? ISTOOFFLINE { get; set; }
}
