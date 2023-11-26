using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_DOC_SERIES")]
public partial class WMS_DOC_Series
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCTYPE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOCDATE { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    public string DEVICEID { get; set; }

    [StringLength(50)]
    public string INSERTEDBY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    public int? STATUS { get; set; }
}
