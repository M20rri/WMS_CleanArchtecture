using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_CYCLECOUNT_DISCREPANCY_REQUEST")]
public partial class WMS_CYCLECOUNT_DISCREPANCY_REQUEST
{
    public int SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCUMENTNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [StringLength(50)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOTNO { get; set; }

    [StringLength(250)]
    public string ITEMDESC { get; set; }

    public int? QTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDDATE { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? NAVSYNCID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LASTCYCLECOUNTDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    public int? ISPENDING { get; set; }

    public int? ISDISCREPANCY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CCSUBDOCNO { get; set; }
}
