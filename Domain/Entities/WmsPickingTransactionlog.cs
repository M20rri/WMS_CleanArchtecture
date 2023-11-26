﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_PICKING_TRANSACTIONLOG")]
public partial class WmsPickingTransactionlog
{
    [Column("ID", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("SRNO", TypeName = "numeric(18, 0)")]
    public decimal? Srno { get; set; }

    [Column("ACTBINNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Actbinno { get; set; }

    [Column("ACTBARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Actbarcode { get; set; }

    [Column("NAVQTY")]
    public int? Navqty { get; set; }

    [Column("PICKCOUNT")]
    public int? Pickcount { get; set; }

    [Column("BALQTY")]
    public int? Balqty { get; set; }

    [Column("PICKSTATUS")]
    public int? Pickstatus { get; set; }

    [Column("INTSTATUS")]
    public int? Intstatus { get; set; }

    [Column("REMARKS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Remarks { get; set; }

    [Column("INSERTEDON", TypeName = "datetime")]
    public DateTime? Insertedon { get; set; }
}