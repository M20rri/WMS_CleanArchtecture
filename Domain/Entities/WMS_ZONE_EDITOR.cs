using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ZONE_EDITOR")]
public partial class WMS_ZONE_EDITOR
{
    public int SRNO { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string ZONETYPE { get; set; }

    public int? ZONESTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }
}
