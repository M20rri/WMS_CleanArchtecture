﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_SUBCLASS_EDITOR")]
public partial class WmsSubclassEditor
{
    [Key]
    [Column("SUBCLSID")]
    public int Subclsid { get; set; }

    [Column("SUBCLSNAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string Subclsname { get; set; }

    [Column("SUBCLASSACTION")]
    [StringLength(50)]
    [Unicode(false)]
    public string Subclassaction { get; set; }

    [Column("CLASSID")]
    public int? Classid { get; set; }

    [Column("SUBCLSSTATUS")]
    public int? Subclsstatus { get; set; }
}