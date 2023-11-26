using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_ITEMS")]
public partial class WMS_ITEM
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal SRNO { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string ITEMNO { get; set; }

    [StringLength(250)]
    public string ITEMDESC1 { get; set; }

    [StringLength(250)]
    public string ITEMDESC2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMCATEGORYCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PRODUCTGROUPCODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CATEGORY3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CATEGORY4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BRAND { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MAGENTOSYNCID { get; set; }

    public int? ISFRAGILE { get; set; }

    public int? ISDANGER { get; set; }

    [StringLength(500)]
    public string IMAGEURL { get; set; }

    [StringLength(250)]
    public string ARABICDESC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SORTINGBINSIZE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATEDON { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMEXPIRABLE { get; set; }
}
