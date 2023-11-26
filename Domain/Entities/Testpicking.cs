﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("TESTPICKING")]
public partial class Testpicking
{
    [Column("SRNO", TypeName = "numeric(38, 0)")]
    public decimal Srno { get; set; }

    [Required]
    [Column("DOCNO")]
    [StringLength(50)]
    public string Docno { get; set; }

    [Column("DOCTYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Doctype { get; set; }

    [Required]
    [Column("PICKNO")]
    [StringLength(50)]
    public string Pickno { get; set; }

    [Column("WAREHOUSENO")]
    [StringLength(50)]
    public string Warehouseno { get; set; }

    [Column("ITEMID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Itemid { get; set; }

    [Required]
    [Column("BARCODE")]
    [StringLength(50)]
    public string Barcode { get; set; }

    [Column("ITEMNO")]
    [StringLength(50)]
    public string Itemno { get; set; }

    [Column("SERIALNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Serialno { get; set; }

    [Column("LOTNO")]
    [StringLength(50)]
    public string Lotno { get; set; }

    [Column("EANCODE")]
    [StringLength(50)]
    public string Eancode { get; set; }

    [Required]
    [Column("SYNCID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Syncid { get; set; }

    [Column("PLACELINENO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Placelineno { get; set; }

    [Column("TRACKINGTYPE")]
    public int? Trackingtype { get; set; }

    [Column("INVENTORYTYPE")]
    [StringLength(50)]
    public string Inventorytype { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(250)]
    public string Description { get; set; }

    [Column("UOM")]
    [StringLength(50)]
    public string Uom { get; set; }

    [Column("QTY1")]
    public double? Qty1 { get; set; }

    [Column("QTY2")]
    public double? Qty2 { get; set; }

    [Column("PNA")]
    public int? Pna { get; set; }

    [Column("PICKSTATUS")]
    public int? Pickstatus { get; set; }

    [Column("TRANSDATE", TypeName = "datetime")]
    public DateTime? Transdate { get; set; }

    [Column("PICKCNT")]
    public int? Pickcnt { get; set; }

    [Column("USERID")]
    public int? Userid { get; set; }

    [Column("USERNAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; }

    [Column("ACTBARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Actbarcode { get; set; }

    [Column("ACTBINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Actbinno { get; set; }

    [Column("SORTBINNO")]
    [StringLength(50)]
    public string Sortbinno { get; set; }

    [Column("MYZONEID")]
    [StringLength(50)]
    public string Myzoneid { get; set; }

    [Column("MYDEVICEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Mydeviceid { get; set; }

    [Column("MYBINNO")]
    [StringLength(50)]
    public string Mybinno { get; set; }

    [Column("ZONEID_1")]
    [StringLength(50)]
    public string Zoneid1 { get; set; }

    [Column("DEVICEID_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid1 { get; set; }

    [Column("BINNO_1")]
    [StringLength(50)]
    public string Binno1 { get; set; }

    [Column("ZONEID_2")]
    [StringLength(50)]
    public string Zoneid2 { get; set; }

    [Column("BINNO_2")]
    [StringLength(50)]
    public string Binno2 { get; set; }

    [Column("DEVICEID_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid2 { get; set; }

    [Column("ZONEID_3")]
    [StringLength(50)]
    public string Zoneid3 { get; set; }

    [Column("BINNO_3")]
    [StringLength(50)]
    public string Binno3 { get; set; }

    [Column("DEVICEID_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid3 { get; set; }

    [Column("ZONEID_4")]
    [StringLength(50)]
    public string Zoneid4 { get; set; }

    [Column("BINNO_4")]
    [StringLength(50)]
    public string Binno4 { get; set; }

    [Column("DEVICEID_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid4 { get; set; }

    [Column("ZONEID_5")]
    [StringLength(50)]
    public string Zoneid5 { get; set; }

    [Column("BINNO_5")]
    [StringLength(50)]
    public string Binno5 { get; set; }

    [Column("DEVICEID_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid5 { get; set; }

    [Column("BINNO_11")]
    [StringLength(50)]
    public string Binno11 { get; set; }

    [Column("BINNO_22")]
    [StringLength(50)]
    public string Binno22 { get; set; }

    [Column("BINNO_33")]
    [StringLength(50)]
    public string Binno33 { get; set; }

    [Column("BINNO_44")]
    [StringLength(50)]
    public string Binno44 { get; set; }

    [Column("BINNO_55")]
    [StringLength(50)]
    public string Binno55 { get; set; }

    [Column("DONEDATE", TypeName = "datetime")]
    public DateTime? Donedate { get; set; }

    [Column("INTEGRATE", TypeName = "datetime")]
    public DateTime? Integrate { get; set; }

    [Column("INTSTATUS")]
    public int? Intstatus { get; set; }

    [Column("ERRMSG")]
    public string Errmsg { get; set; }

    [Column("RETRYCOUNT")]
    public int? Retrycount { get; set; }

    [Column("USERASSIGNDATE", TypeName = "datetime")]
    public DateTime? Userassigndate { get; set; }

    [Column("ASSIGNSTATUS")]
    public bool? Assignstatus { get; set; }

    [Column("RECINSERTED", TypeName = "datetime")]
    public DateTime? Recinserted { get; set; }

    [Column("IMAGEURL")]
    [StringLength(250)]
    public string Imageurl { get; set; }

    [Column("USERPLATFORM")]
    public int? Userplatform { get; set; }

    [Column("FORCECLOSE")]
    public int? Forceclose { get; set; }

    [Column("FORCECLOSEDATE", TypeName = "datetime")]
    public DateTime? Forceclosedate { get; set; }

    [Column("ARCHIVE", TypeName = "datetime")]
    public DateTime? Archive { get; set; }
}