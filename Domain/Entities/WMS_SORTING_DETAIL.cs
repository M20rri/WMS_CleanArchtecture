using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_SORTING_DETAIL")]
public partial class WMS_SORTING_DETAIL
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string WEBORDERNO { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string BATCHID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    public int? ORDERQTY { get; set; }

    public int? PUTQTY { get; set; }

    public int? PICKQTY { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SORTEDBY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PKGLOCID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    public int? PUTUSERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PUTDEVICEID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PUTDATE { get; set; }

    public int? PICKUSERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PICKDEVICEID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PICKDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RELBYUSERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RELEASEDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    public int? BINSTATUS { get; set; }

    public int? INTSTATUS { get; set; }

    public string ERRMSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public int? USERPLATFORM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string COUNTRY { get; set; }
}
