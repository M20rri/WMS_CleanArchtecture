﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("ARC_SORTING_DETAIL2019")]
public partial class ArcSortingDetail2019
{
    [Column("ARCID", TypeName = "numeric(38, 0)")]
    public decimal Arcid { get; set; }

    [Column("SRNO", TypeName = "numeric(38, 0)")]
    public decimal Srno { get; set; }

    [Required]
    [Column("WEBORDERNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Weborderno { get; set; }

    [Required]
    [Column("BINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Binno { get; set; }

    [Required]
    [Column("BATCHID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Batchid { get; set; }

    [Column("ITEMID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Itemid { get; set; }

    [Column("ORDERQTY")]
    public int? Orderqty { get; set; }

    [Column("PUTQTY")]
    public int? Putqty { get; set; }

    [Column("PICKQTY")]
    public int? Pickqty { get; set; }

    [Required]
    [Column("SYNCID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Syncid { get; set; }

    [Column("SORTEDBY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Sortedby { get; set; }

    [Column("PKGLOCID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Pkglocid { get; set; }

    [Column("RECINSERTED", TypeName = "datetime")]
    public DateTime? Recinserted { get; set; }

    [Column("PUTUSERID")]
    public int? Putuserid { get; set; }

    [Column("PUTDEVICEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Putdeviceid { get; set; }

    [Column("PUTDATE", TypeName = "datetime")]
    public DateTime? Putdate { get; set; }

    [Column("PICKUSERID")]
    public int? Pickuserid { get; set; }

    [Column("PICKDEVICEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Pickdeviceid { get; set; }

    [Column("PICKDATE", TypeName = "datetime")]
    public DateTime? Pickdate { get; set; }

    [Column("RELBYUSERID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Relbyuserid { get; set; }

    [Column("RELEASEDATE", TypeName = "datetime")]
    public DateTime? Releasedate { get; set; }

    [Column("WAREHOUSENO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Warehouseno { get; set; }

    [Column("BINSTATUS")]
    public int? Binstatus { get; set; }

    [Column("INTSTATUS")]
    public int? Intstatus { get; set; }

    [Column("ERRMSG")]
    public string Errmsg { get; set; }

    [Column("INTEGRATE", TypeName = "datetime")]
    public DateTime? Integrate { get; set; }

    [Column("USERPLATFORM")]
    public int? Userplatform { get; set; }

    [Column("ARCHIVE", TypeName = "datetime")]
    public DateTime? Archive { get; set; }
}