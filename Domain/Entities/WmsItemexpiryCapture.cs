﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ITEMEXPIRY_CAPTURE")]
public partial class WmsItemexpiryCapture
{
    [Key]
    [Column("SRNO")]
    public int Srno { get; set; }

    [Column("DOCNO")]
    [StringLength(250)]
    [Unicode(false)]
    public string Docno { get; set; }

    [Column("ITEMNO")]
    [StringLength(100)]
    [Unicode(false)]
    public string Itemno { get; set; }

    [Column("LOTNO")]
    [StringLength(100)]
    [Unicode(false)]
    public string Lotno { get; set; }

    [Column("BARCODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Barcode { get; set; }

    [Column("EXPIRYDATE1", TypeName = "date")]
    public DateTime? Expirydate1 { get; set; }

    [Column("EXPIRYDATE2", TypeName = "date")]
    public DateTime? Expirydate2 { get; set; }

    [Column("USERID")]
    public int? Userid { get; set; }

    [Column("ISSYNC")]
    public int? Issync { get; set; }

    [Column("ERRMSG")]
    [StringLength(300)]
    public string Errmsg { get; set; }

    [Column("TRANSDATE", TypeName = "datetime")]
    public DateTime? Transdate { get; set; }

    [Column("UPDATEDON", TypeName = "datetime")]
    public DateTime? Updatedon { get; set; }

    [Column("WAREHOUSENO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Warehouseno { get; set; }

    [Column("USERPLATFORM")]
    public int? Userplatform { get; set; }

    [Column("EXPIRYDATE3", TypeName = "datetime")]
    public DateTime? Expirydate3 { get; set; }
}