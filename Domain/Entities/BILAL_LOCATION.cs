using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("BILAL_LOCATION")]
[Index("LOCATIONCODE", Name = "UC_LOCATIONCODE", IsUnique = true)]
public partial class BILAL_LOCATION
{
    [Key]
    public int ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string WAREHOUSEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOCATIONCODE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string LOCATIONTYPE { get; set; }

    public int? ISUSED { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TOTEID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    public int? INSERTEDBY { get; set; }
}
