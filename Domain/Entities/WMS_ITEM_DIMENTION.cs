using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_ITEM_DIMENTION")]
public partial class WMS_ITEM_DIMENTION
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [StringLength(50)]
    public string BARCODE { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? HEIGHT { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? WIDTH { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? LENGTH { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    public int? INSERTEDBY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    public int? UPDATEBY { get; set; }

    [StringLength(50)]
    public string ITEMNO { get; set; }

    public int? INTSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public int? RETRYCOUNT { get; set; }

    public string ERRMSG { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    public int? USERPLATFORM { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string VOLUME { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string WEIGHT { get; set; }
}
