using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ITEMEXPIRY_CAPTURE")]
public partial class WMS_ITEMEXPIRY_CAPTURE
{
    [Key]
    public int SRNO { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string LOTNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [Column(TypeName = "date")]
    public DateTime? EXPIRYDATE1 { get; set; }

    [Column(TypeName = "date")]
    public DateTime? EXPIRYDATE2 { get; set; }

    public int? USERID { get; set; }

    public int? ISSYNC { get; set; }

    [StringLength(300)]
    public string ERRMSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TRANSDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    public int? USERPLATFORM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EXPIRYDATE3 { get; set; }
}
