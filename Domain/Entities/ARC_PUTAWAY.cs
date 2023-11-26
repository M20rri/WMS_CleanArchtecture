using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ARC_PUTAWAY")]
[Index("SRNO", Name = "IX_ARC_PUTAWAY", IsUnique = true)]
public partial class ARC_PUTAWAY
{
    [Key]
    [Column(TypeName = "numeric(38, 0)")]
    public decimal ARCID { get; set; }

    [Column(TypeName = "numeric(38, 0)")]
    public decimal SRNO { get; set; }

    [Required]
    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [Required]
    [StringLength(50)]
    public string PUTNO { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [Required]
    [StringLength(50)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    public string LOTNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SERIALNO { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }

    [StringLength(250)]
    public string DESCRIPTION { get; set; }

    [StringLength(50)]
    public string UOM { get; set; }

    public int? QTY1 { get; set; }

    public int? QTY2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string INVTYPE { get; set; }

    [StringLength(50)]
    public string ZONEID_1 { get; set; }

    [StringLength(50)]
    public string BINNO_1 { get; set; }

    [StringLength(50)]
    public string ZONEID_2 { get; set; }

    [StringLength(50)]
    public string BINNO_2 { get; set; }

    [StringLength(50)]
    public string ZONEID_3 { get; set; }

    [StringLength(50)]
    public string BINNO_3 { get; set; }

    [StringLength(50)]
    public string ZONEID_4 { get; set; }

    [StringLength(50)]
    public string BINNO_4 { get; set; }

    [StringLength(50)]
    public string ZONEID_5 { get; set; }

    [StringLength(50)]
    public string BINNO_5 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TRACKINGTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERNAME { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? USERASSIGNDATE { get; set; }

    public bool? ASSIGNSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    public int? INTSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ARCHIVE { get; set; }
}
