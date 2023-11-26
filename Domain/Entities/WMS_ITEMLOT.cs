using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ITEMLOTS")]
public partial class WMS_ITEMLOT
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string BARCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string ITEMDESC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TRACKINGTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SERIALNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOTNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EANCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UOM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string QUALITYSTATUS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EXPIRYDATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CREATEDDATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CONTRACTTYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string INVENTORYTYPE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RECINSERTED { get; set; }

    public int? ISGRNPOSTED { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }
}
