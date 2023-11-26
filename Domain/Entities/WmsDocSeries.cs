﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_DOC_SERIES")]
public partial class WmsDocSeries
{
    [Key]
    [Column("SRNO", TypeName = "numeric(18, 0)")]
    public decimal Srno { get; set; }

    [Column("DOCNO")]
    [StringLength(50)]
    public string Docno { get; set; }

    [Column("DOCTYPE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Doctype { get; set; }

    [Column("DOCDATE", TypeName = "datetime")]
    public DateTime? Docdate { get; set; }

    [Column("WAREHOUSENO")]
    [StringLength(50)]
    public string Warehouseno { get; set; }

    [Column("DEVICEID")]
    [StringLength(50)]
    public string Deviceid { get; set; }

    [Column("INSERTEDBY")]
    [StringLength(50)]
    public string Insertedby { get; set; }

    [Column("INSERTEDON", TypeName = "datetime")]
    public DateTime? Insertedon { get; set; }

    [Column("STATUS")]
    public int? Status { get; set; }
}