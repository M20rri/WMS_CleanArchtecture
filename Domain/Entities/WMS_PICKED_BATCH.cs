using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_PICKED_BATCHES")]
public partial class WMS_PICKED_BATCH
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    public string DEVICEID { get; set; }

    public int? QTY1 { get; set; }

    public int? QTY2 { get; set; }

    public int? PNA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    public int? DONEBYUSERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DONEDATE { get; set; }

    public int? CLOSEBYUSERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CLOSEDATE { get; set; }

    public int? STATUS { get; set; }
}
