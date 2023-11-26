using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_PAGEMASTER")]
public partial class WMS_PAGEMASTER
{
    [Key]
    public int ID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string PAGENAME { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string CONTROLLER { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string ACTION { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string STOREID { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string MENULINK { get; set; }

    public int? AREA { get; set; }
}
