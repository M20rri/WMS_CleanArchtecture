using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_BIN")]
public partial class WMS_BIN
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    public int? QTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FLAG { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AISLENO { get; set; }

    public int? ISACTIVE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    public int? ISMOVEMENT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINSIZE { get; set; }

    public int? BINPRIORITY { get; set; }

    public int? ISTOOFFLINE { get; set; }
}
