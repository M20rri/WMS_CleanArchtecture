using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_CYCLECOUNT_PENDINGITEMAPPROVAL")]
public partial class WMS_CYCLECOUNT_PENDINGITEMAPPROVAL
{
    [Key]
    public int SRNO { get; set; }

    public int? DOCTYPE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string SUBDOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ITEMDESC { get; set; }

    public int? ISDISCREPANCYFROMNAV { get; set; }

    public int? SYSQTY { get; set; }

    public int? SCANQTY { get; set; }

    public int? TRANSQTY { get; set; }

    public int? DIFFQTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CREATEDON { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    public int? INSERTEDBY { get; set; }
}
