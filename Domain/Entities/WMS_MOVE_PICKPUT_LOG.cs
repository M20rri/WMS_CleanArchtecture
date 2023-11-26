using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_MOVE_PICKPUT_LOG")]
public partial class WMS_MOVE_PICKPUT_LOG
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PROCESSNAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    public int? QTY1 { get; set; }

    public int? QTY2 { get; set; }

    public int? MOV1DOCQTY { get; set; }

    public int? MOV3DOCQTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    public int? INSERTEDBY { get; set; }
}
