using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_STATUSMASTER")]
public partial class WMS_STATUSMASTER
{
    [Key]
    public int STATUSID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NAME { get; set; }

    public int? CYCLECOUNT { get; set; }

    public int? PICKING { get; set; }
}
