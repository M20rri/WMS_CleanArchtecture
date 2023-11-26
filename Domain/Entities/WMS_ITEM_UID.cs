using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ITEM_UID")]
public partial class WMS_ITEM_UID
{
    [Key]
    public int SRNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string LOTNO { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string UID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }
}
