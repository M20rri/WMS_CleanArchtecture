using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_TOTEHISTORY")]
public partial class WMS_TOTEHISTORY
{
    [Column(TypeName = "numeric(18, 3)")]
    public decimal? ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOCATIONID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TOTEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string STATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }
}
