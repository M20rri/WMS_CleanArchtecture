using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_TOTEITEMS")]
public partial class WMS_TOTEITEM
{
    [Column(TypeName = "numeric(18, 3)")]
    public decimal? ID { get; set; }

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
    public string ITEMNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMTYPE { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string SORTINGZONE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WEBORDERNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PICKNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PICKEDBINNO { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UPDATEDBY { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string STATUS { get; set; }
}
