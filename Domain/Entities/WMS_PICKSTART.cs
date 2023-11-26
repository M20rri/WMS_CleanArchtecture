using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_PICKSTART")]
public partial class WMS_PICKSTART
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PICKNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }
}
