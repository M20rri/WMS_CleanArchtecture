﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("BILAL_LOCATION")]
[Index("Locationcode", Name = "UC_LOCATIONCODE", IsUnique = true)]
public partial class BilalLocation
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WAREHOUSEID")]
    [StringLength(20)]
    [Unicode(false)]
    public string Warehouseid { get; set; }

    [Column("LOCATIONCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Locationcode { get; set; }

    [Column("LOCATIONTYPE")]
    [StringLength(20)]
    [Unicode(false)]
    public string Locationtype { get; set; }

    [Column("ISUSED")]
    public int? Isused { get; set; }

    [Column("TOTEID")]
    [StringLength(20)]
    [Unicode(false)]
    public string Toteid { get; set; }

    [Column("INSERTEDON", TypeName = "datetime")]
    public DateTime? Insertedon { get; set; }

    [Column("INSERTEDBY")]
    public int? Insertedby { get; set; }
}