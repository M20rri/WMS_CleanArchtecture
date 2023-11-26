﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_TOTEHISTORY")]
public partial class WmsTotehistory
{
    [Column("ID", TypeName = "numeric(18, 3)")]
    public decimal? Id { get; set; }

    [Column("WAREHOUSENO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Warehouseno { get; set; }

    [Column("LOCATIONID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Locationid { get; set; }

    [Column("TOTEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Toteid { get; set; }

    [Column("BARCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Barcode { get; set; }

    [Column("ITEMID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Itemid { get; set; }

    [Column("DEVICEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid { get; set; }

    [Column("USERID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Userid { get; set; }

    [Column("STATUS")]
    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; }

    [Column("INSERTEDON", TypeName = "datetime")]
    public DateTime? Insertedon { get; set; }
}