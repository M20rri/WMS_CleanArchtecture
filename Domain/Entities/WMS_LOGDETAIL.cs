using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_LOGDETAILS")]
public partial class WMS_LOGDETAIL
{
    [Key]
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string PROCNAME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string UNIQUEID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ENTRYTYPE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string TIMESTAMPS { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string INPUTJSON { get; set; }
}
