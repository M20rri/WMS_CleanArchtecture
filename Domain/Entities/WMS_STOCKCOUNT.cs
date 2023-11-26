using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_STOCKCOUNT")]
[Index("DOCNO", "BARCODE", "BINNO_F", "DEVICEID", Name = "IX_WMS_STOCKCOUNT", IsUnique = true)]
public partial class WMS_STOCKCOUNT
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BASEBINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO_F { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO_T { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SERIALNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOTNO { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string ITEMDESC { get; set; }

    public int? SYSQTY { get; set; }

    public int? SCANQTY { get; set; }

    public int? TRNQTY { get; set; }

    public int? QTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MINDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MAXDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERNAME { get; set; }

    public int? DOCSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DONEDATE { get; set; }

    public int? INTSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public string ERRMSG { get; set; }

    public int? USERPLATFORM { get; set; }

    public string BINREQUEST { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ARCHIVE { get; set; }

    public int? CCTYPE { get; set; }

    public int? ISCYCLECOUNTMANUAL { get; set; }
}
