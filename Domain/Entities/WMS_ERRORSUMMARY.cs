using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ERRORSUMMARY")]
public partial class WMS_ERRORSUMMARY
{
    [Key]
    public int MODCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MODULES { get; set; }

    public int? COUNTS { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string LOGFILE { get; set; }
}
