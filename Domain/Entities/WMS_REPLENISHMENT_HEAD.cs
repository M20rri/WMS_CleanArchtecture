using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_REPLENISHMENT_HEAD")]
public partial class WMS_REPLENISHMENT_HEAD
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMDESC { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    public int? AVAILABLEQTY { get; set; }

    public int? MINQTY { get; set; }

    public int? MAXQTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FROMZONE { get; set; }

    public int? QTYTOMOVE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }
}
