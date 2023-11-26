using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_RETURNCANCEL")]
[Index("ITEMID", "DOCNO", Name = "UC_ITEM", IsUnique = true)]
public partial class WMS_RETURNCANCEL
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [StringLength(50)]
    public string DOCNO { get; set; }

    [StringLength(50)]
    public string ORDERNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ORDERDATE { get; set; }

    [StringLength(50)]
    public string BATCHID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(50)]
    public string BARCODE { get; set; }

    public int? QTY { get; set; }

    public int? ITEMCNT { get; set; }

    public int? ITEMSRNO { get; set; }

    [StringLength(50)]
    public string DEVICEID { get; set; }

    public string DESCRIPTION { get; set; }

    [StringLength(50)]
    public string PICKFROM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CANCEL_RETURNDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    public string DOCTYPE { get; set; }

    [StringLength(350)]
    public string IMAGEURL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PICKEDDATE { get; set; }

    [StringLength(50)]
    public string PICKEDBINNO { get; set; }

    [StringLength(50)]
    public string PICKEDZONE { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? INSERTEDBY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }
}
