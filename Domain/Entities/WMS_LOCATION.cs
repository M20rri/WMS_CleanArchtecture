using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_LOCATION")]
public partial class WMS_LOCATION
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string WAREHOUSEID { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string LOCATIONCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOCATIONTYPE { get; set; }

    public int? ISUSED { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TOTEID { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    public int? INSERTEDBY { get; set; }
}
