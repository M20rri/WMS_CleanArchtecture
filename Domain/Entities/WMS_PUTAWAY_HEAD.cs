using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_PUTAWAY_HEAD")]
public partial class WMS_PUTAWAY_HEAD
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SUBDOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string INVTYPE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DOCSUB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERNAME { get; set; }

    public int? QTY1 { get; set; }

    public int? QTY2 { get; set; }

    public int? SETTLEDQTY { get; set; }

    [StringLength(255)]
    public string REMARKS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    public int? SUBDOCSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? USERASSIGNDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DONEDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public int? USERPLATFORM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ARCHIVE { get; set; }
}
