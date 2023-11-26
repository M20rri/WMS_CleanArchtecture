using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ARC_SORTING_DETAIL")]
[Index("BATCHID", "ITEMID", Name = "IX_ARC_SORTING_DETAIL_1", IsUnique = true)]
public partial class ARC_SORTING_DETAIL
{
    [Key]
    [Column(TypeName = "numeric(38, 0)")]
    public decimal ARCID { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
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

    [Column(TypeName = "datetime")]
    public DateTime? ARCHIVE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }
}
