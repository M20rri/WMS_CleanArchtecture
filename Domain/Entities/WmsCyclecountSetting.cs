﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_CYCLECOUNT_SETTINGS")]
public partial class WmsCyclecountSetting
{
    [Key]
    [Column("SRNO", TypeName = "numeric(18, 0)")]
    public decimal Srno { get; set; }

    [Column("DEVICEID")]
    [StringLength(50)]
    [Unicode(false)]
    public string Deviceid { get; set; }

    [Column("ALLOWUID")]
    public int? Allowuid { get; set; }

    [Column("ALLOWLOT")]
    public int? Allowlot { get; set; }

    [Column("USERID")]
    public int? Userid { get; set; }

    [Column("RECINSERTED", TypeName = "datetime")]
    public DateTime? Recinserted { get; set; }

    [Column("WAREHOUSENO")]
    [StringLength(50)]
    [Unicode(false)]
    public string Warehouseno { get; set; }
}