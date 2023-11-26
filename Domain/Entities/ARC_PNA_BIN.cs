using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("ARC_PNA_BIN")]
[Index("ID", Name = "IX_ARC_PNA_BIN", IsUnique = true)]
public partial class ARC_PNA_BIN
{
    [Key]
    [Column(TypeName = "numeric(38, 0)")]
    public decimal ARCID { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PNATYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PICKNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PNADATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ERRMSG { get; set; }

    public int? USERPLATFORM { get; set; }

    public int? STATUS { get; set; }
}
