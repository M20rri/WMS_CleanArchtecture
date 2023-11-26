using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_COMMON_DEVICELEDGER")]
public partial class WMS_COMMON_DEVICELEDGER
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PROCESSNAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? QTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }
}
