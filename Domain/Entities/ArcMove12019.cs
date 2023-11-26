using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ARC_MOVE_1_2019")]
public partial class ArcMove12019
{
    [Column("ARCID", TypeName = "numeric(18, 0)")]
    public decimal Arcid { get; set; }

    [Key]
    [Column("SRNO", TypeName = "numeric(18, 0)")]
    public decimal Srno { get; set; }

    [Column("DOCTYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Doctype { get; set; }

    [Column("DOCNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Docno { get; set; }

    [Column("WAREHOUSENO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Warehouseno { get; set; }

    [Column("BINNO_F")]
    [StringLength(50)]
    [Unicode(false)]
    public string BinnoF { get; set; }

    [Column("BINNO_T")]
    [StringLength(50)]
    [Unicode(false)]
    public string BinnoT { get; set; }

    [Column("BARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Barcode { get; set; }

    [Column("ITEMNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Itemno { get; set; }

    [Column("SERIALNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Serialno { get; set; }

    [Column("LOTNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Lotno { get; set; }

    [Column("ITEMDESC")]
    [StringLength(250)]
    [Unicode(false)]
    public string Itemdesc { get; set; }

    [Column("QTY")]
    public int? Qty { get; set; }

    [Column("SYSBINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Sysbinno { get; set; }

    [Column("SYSZONEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Syszoneid { get; set; }

    [Column("DEVICEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid { get; set; }

    [Column("USERID")]
    public int? Userid { get; set; }

    [Column("TRANSDATE", TypeName = "datetime")]
    public DateTime? Transdate { get; set; }

    [Column("ITEMTYPE")]
    [StringLength(10)]
    [Unicode(false)]
    public string Itemtype { get; set; }

    [Column("BINNO_1")]
    [StringLength(50)]
    public string Binno1 { get; set; }

    [Column("BINNO_2")]
    [StringLength(50)]
    public string Binno2 { get; set; }

    [Column("BINNO_3")]
    [StringLength(50)]
    public string Binno3 { get; set; }

    [Column("BINNO_4")]
    [StringLength(50)]
    public string Binno4 { get; set; }

    [Column("DOCSTATUS")]
    public int? Docstatus { get; set; }

    [Column("DONEDATE", TypeName = "datetime")]
    public DateTime? Donedate { get; set; }

    [Column("INTSTATUS")]
    public int? Intstatus { get; set; }

    [Column("INTEGRATE", TypeName = "datetime")]
    public DateTime? Integrate { get; set; }

    [Column("INTATTEMPTS")]
    public int? Intattempts { get; set; }

    [Column("ERRMSG")]
    public string Errmsg { get; set; }

    [Column("USERPLATFORM")]
    public int? Userplatform { get; set; }

    [Column("BINREQUEST")]
    public string Binrequest { get; set; }

    [Column("ARCHIVE", TypeName = "datetime")]
    public DateTime? Archive { get; set; }
}