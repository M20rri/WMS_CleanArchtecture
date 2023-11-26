using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_PICKING_TRANSACTIONLOG")]
public partial class WMS_PICKING_TRANSACTIONLOG
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ACTBINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ACTBARCODE { get; set; }

    public int? NAVQTY { get; set; }

    public int? PICKCOUNT { get; set; }

    public int? BALQTY { get; set; }

    public int? PICKSTATUS { get; set; }

    public int? INTSTATUS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string REMARKS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }
}
