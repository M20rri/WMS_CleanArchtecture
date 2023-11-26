using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ARC_PUTAWAY_RETURNCANCEL")]
public partial class ARC_PUTAWAY_RETURNCANCEL
{
    [Key]
    public int ID { get; set; }

    public int? SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(250)]
    public string DESCRIPTION { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FROMBINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SUGGESTEDBINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ACTBINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    public int? QTY1 { get; set; }

    public int? QTY2 { get; set; }

    public int? DOCSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TRANSDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    public int? USERPLATFORM { get; set; }

    public int? INTSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public string ERRMSG { get; set; }

    public int? RETRYCOUNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ARCDATE { get; set; }
}
