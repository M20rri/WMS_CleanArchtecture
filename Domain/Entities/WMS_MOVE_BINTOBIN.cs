using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_MOVE_BINTOBIN")]
[Index("DOCNO", "BINNO_F", Name = "IX_WMS_MOVE_BINTOBIN", IsUnique = true)]
public partial class WMS_MOVE_BINTOBIN
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO_F { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO_T { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TRANSDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERNAME { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DONEDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INTEGRATE { get; set; }

    public string ERRMSG { get; set; }

    public int? DOCSTATUS { get; set; }

    public int? INTSTATUS { get; set; }

    public int? USERPLATFORM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SYNCID { get; set; }
}
