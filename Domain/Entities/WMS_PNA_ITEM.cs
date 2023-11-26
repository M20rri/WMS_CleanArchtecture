using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_PNA_ITEMS")]
public partial class WMS_PNA_ITEM
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BATCHID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ORDERNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string REFORDERNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ENTRYNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string PNACOUNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PNASTATUS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }
}
