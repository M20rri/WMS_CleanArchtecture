using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_PICKING_RETURNCANCEL")]
public partial class WMS_PICKING_RETURNCANCEL
{
    [Key]
    public int SRNO { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    public int? QTY1 { get; set; }

    public int? QTY2 { get; set; }

    public int? PNA { get; set; }

    public int? PICKSTATUS { get; set; }

    public int? PICKCNT { get; set; }

    public int? ITEMSRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SUGGESTEDBINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    public int? DOCSTATUS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

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

    [StringLength(250)]
    [Unicode(false)]
    public string ERRMSG { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string IMAGEURL { get; set; }
}
