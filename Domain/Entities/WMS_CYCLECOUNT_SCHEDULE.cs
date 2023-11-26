using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_CYCLECOUNT_SCHEDULE")]
public partial class WMS_CYCLECOUNT_SCHEDULE
{
    [Key]
    public int SRNO { get; set; }

    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    public string SUBDOCNO { get; set; }

    public int? DOCTYPE { get; set; }

    [StringLength(50)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    public int? SYSTEMQTY { get; set; }

    public int? SCANQTY { get; set; }

    public int? TRANSQTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CLOSEDATE { get; set; }

    public int? CLOSEBY { get; set; }

    [StringLength(50)]
    public string STATUS { get; set; }

    public int? STATUSID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? APPROVEDON { get; set; }

    public int? APPROVEDBY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    public int? INSERTEDBY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    public int? UPDATEDBY { get; set; }

    [StringLength(250)]
    public string COMMENTS { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string REFERENCENO { get; set; }

    public int? ISSYNC { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SYNCDATE { get; set; }

    public string ERRMSG { get; set; }
}
