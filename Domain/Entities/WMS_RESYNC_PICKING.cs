using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_RESYNC_PICKING")]
public partial class WMS_RESYNC_PICKING
{
    public int SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PICKNO { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? WMSSRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }

    public int? QTY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    public int? PNA { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PICKEDDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    public int? RETRYCOUNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SYNCDATE { get; set; }

    public int? INTSTATUS { get; set; }

    public string ERRMSG { get; set; }
}
