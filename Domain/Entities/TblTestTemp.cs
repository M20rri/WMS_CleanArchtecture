﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("TBL_TEST_TEMP")]
public partial class TblTestTemp
{
    [Column("SRNO", TypeName = "numeric(18, 0)")]
    public decimal Srno { get; set; }

    [Column("DOCNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Docno { get; set; }

    [Column("WAREHOUSENO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Warehouseno { get; set; }

    [Column("BASEBINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Basebinno { get; set; }

    [Column("BINNO_F")]
    [StringLength(50)]
    [Unicode(false)]
    public string BinnoF { get; set; }

    [Column("BINNO_T")]
    [StringLength(50)]
    [Unicode(false)]
    public string BinnoT { get; set; }

    [Column("ZONEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Zoneid { get; set; }

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

    [Column("SYSQTY")]
    public int? Sysqty { get; set; }

    [Column("SCANQTY")]
    public int? Scanqty { get; set; }

    [Column("TRNQTY")]
    public int? Trnqty { get; set; }

    [Column("QTY")]
    public int? Qty { get; set; }

    [Column("MINDATE", TypeName = "datetime")]
    public DateTime? Mindate { get; set; }

    [Column("MAXDATE", TypeName = "datetime")]
    public DateTime? Maxdate { get; set; }

    [Column("DEVICEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid { get; set; }

    [Column("USERID")]
    public int? Userid { get; set; }

    [Column("USERNAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; }

    [Column("DOCSTATUS")]
    public int? Docstatus { get; set; }

    [Column("RECINSERTED", TypeName = "datetime")]
    public DateTime? Recinserted { get; set; }

    [Column("DONEDATE", TypeName = "datetime")]
    public DateTime? Donedate { get; set; }

    [Column("INTSTATUS")]
    public int? Intstatus { get; set; }

    [Column("INTEGRATE", TypeName = "datetime")]
    public DateTime? Integrate { get; set; }

    [Column("ERRMSG")]
    public string Errmsg { get; set; }

    [Column("USERPLATFORM")]
    public int? Userplatform { get; set; }

    [Column("BINREQUEST")]
    public string Binrequest { get; set; }

    [Column("ARCHIVE", TypeName = "datetime")]
    public DateTime? Archive { get; set; }
}