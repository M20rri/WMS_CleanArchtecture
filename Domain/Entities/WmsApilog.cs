﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_APILOG")]
public partial class WmsApilog
{
    [Key]
    [Column("LOGID")]
    public int Logid { get; set; }

    [Column("MODULE")]
    [StringLength(150)]
    [Unicode(false)]
    public string Module { get; set; }

    [Column("APIURL")]
    [StringLength(250)]
    public string Apiurl { get; set; }

    [Column("APISTATUS")]
    [StringLength(150)]
    [Unicode(false)]
    public string Apistatus { get; set; }

    [Column("APIREQUEST")]
    public string Apirequest { get; set; }

    [Column("APIRESPONSE")]
    public string Apiresponse { get; set; }

    [Column("ERRPRMSG")]
    public string Errprmsg { get; set; }

    [Column("LOGDATE", TypeName = "datetime")]
    public DateTime? Logdate { get; set; }

    [Column("REMARKS")]
    public string Remarks { get; set; }
}