using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ROLL_EDITOR")]
public partial class WMS_ROLL_EDITOR
{
    [Key]
    public int ROLLID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ROLLDESC { get; set; }

    public int? ROLLSTATUS { get; set; }
}
