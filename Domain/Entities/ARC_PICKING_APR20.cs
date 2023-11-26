using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ARC_PICKING_APR20")]
public partial class ARC_PICKING_APR20
{
    [Column(TypeName = "numeric(38, 0)")]
    public decimal ARCID { get; set; }

    [Key]
    [Column(TypeName = "numeric(38, 0)")]
    public decimal SRNO { get; set; }

    [Required]
    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [Required]
    [StringLength(50)]
    public string PICKNO { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    [Required]
    [StringLength(50)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SERIALNO { get; set; }

    [StringLength(50)]
    public string LOTNO { get; set; }

    [StringLength(50)]
    public string EANCODE { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PLACELINENO { get; set; }

    public int? TRACKINGTYPE { get; set; }

    [StringLength(50)]
    public string INVENTORYTYPE { get; set; }

    [StringLength(250)]
    public string DESCRIPTION { get; set; }

    [StringLength(50)]
    public string UOM { get; set; }

    public double? QTY1 { get; set; }

    public double? QTY2 { get; set; }

    public int? PNA { get; set; }

    public int? PICKSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TRANSDATE { get; set; }

    public int? PICKCNT { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERNAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ACTBARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ACTBINNO { get; set; }

    [StringLength(50)]
    public string SORTBINNO { get; set; }

    [StringLength(50)]
    public string MYZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MYDEVICEID { get; set; }

    [StringLength(50)]
    public string MYBINNO { get; set; }

    [StringLength(50)]
    public string ZONEID_1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID_1 { get; set; }

    [StringLength(50)]
    public string BINNO_1 { get; set; }

    [StringLength(50)]
    public string ZONEID_2 { get; set; }

    [StringLength(50)]
    public string BINNO_2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID_2 { get; set; }

    [StringLength(50)]
    public string ZONEID_3 { get; set; }

    [StringLength(50)]
    public string BINNO_3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID_3 { get; set; }

    [StringLength(50)]
    public string ZONEID_4 { get; set; }

    [StringLength(50)]
    public string BINNO_4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID_4 { get; set; }

    [StringLength(50)]
    public string ZONEID_5 { get; set; }

    [StringLength(50)]
    public string BINNO_5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID_5 { get; set; }

    [StringLength(50)]
    public string BINNO_11 { get; set; }

    [StringLength(50)]
    public string BINNO_22 { get; set; }

    [StringLength(50)]
    public string BINNO_33 { get; set; }

    [StringLength(50)]
    public string BINNO_44 { get; set; }

    [StringLength(50)]
    public string BINNO_55 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DONEDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public int? INTSTATUS { get; set; }

    public string ERRMSG { get; set; }

    public int? RETRYCOUNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? USERASSIGNDATE { get; set; }

    public bool? ASSIGNSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    [StringLength(250)]
    public string IMAGEURL { get; set; }

    public int? USERPLATFORM { get; set; }

    public int? FORCECLOSE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FORCECLOSEDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ARCHIVE { get; set; }
}
