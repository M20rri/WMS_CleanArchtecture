using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_USER_TASKS")]
[Index("DOCNO", "SUBDOCNO", "DOCTYPE", Name = "IX_WMS_USER_TASKS")]
public partial class WMS_USER_TASK
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SUBDOCNO { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERNAME { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ASSIGNDATE { get; set; }
}
