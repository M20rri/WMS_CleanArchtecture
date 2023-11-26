using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_CANCELLED_ITEMS")]
public partial class WMS_CANCELLED_ITEM
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ITEMID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WEBORDERNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string REFORDERNO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CANCELDATE { get; set; }

    public int? CANCELLEDBY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }
}
