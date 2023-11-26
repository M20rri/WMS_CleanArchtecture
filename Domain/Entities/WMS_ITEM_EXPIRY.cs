using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ITEM_EXPIRY")]
public partial class WMS_ITEM_EXPIRY
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
    public string EXPIRYDATE { get; set; }

    public int? USERID { get; set; }

    public string REQUEST { get; set; }

    public string RESPONSE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }
}
