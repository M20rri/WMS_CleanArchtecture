using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_APICONFIG")]
public partial class WMS_APICONFIG
{
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PROCESSNAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string WAREHOUSENO { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string APIURL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TOKENKEY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TOKENVALUE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LOGPATH { get; set; }

    public int? ISACTIVE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? INSERTEDON { get; set; }
}
