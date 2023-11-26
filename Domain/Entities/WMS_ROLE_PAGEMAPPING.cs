using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ROLE_PAGEMAPPING")]
public partial class WMS_ROLE_PAGEMAPPING
{
    [Key]
    public int ID { get; set; }

    public int? ROLEID { get; set; }

    public int? PAGEID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string AREA { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string UPDATEDBY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }
}
