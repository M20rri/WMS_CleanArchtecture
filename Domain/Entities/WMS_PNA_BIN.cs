using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_PNA_BIN")]
public partial class WMS_PNA_BIN
{
    [Key]
    [Column(TypeName = "numeric(38, 0)")]
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

    public int? RETRYCOUNT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMDESC { get; set; }

    public int? BINSEQUENCE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }
}
