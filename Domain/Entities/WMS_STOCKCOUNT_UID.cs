using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_STOCKCOUNT_UID")]
public partial class WMS_STOCKCOUNT_UID
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOTNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMUID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string ITEMDESC { get; set; }

    public int? SCANQTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TRANSDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERID { get; set; }
}
