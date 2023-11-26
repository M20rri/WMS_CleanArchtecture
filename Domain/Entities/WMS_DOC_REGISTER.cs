using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_DOC_REGISTER")]
public partial class WMS_DOC_REGISTER
{
    public int SRNO { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCDESC { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string PRESET { get; set; }

    public long? SERIALNO { get; set; }

    [Key]
    [StringLength(50)]
    public string DOCNO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? YEARSTART { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? YEAREND { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DIGITS { get; set; }

    public int? GENERATEDIGIT { get; set; }
}
