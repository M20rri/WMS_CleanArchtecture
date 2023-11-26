using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_CLASS_EDITOR")]
public partial class WMS_CLASS_EDITOR
{
    [Key]
    public int CLASSID { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string CLSNAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CLSACTION { get; set; }

    public int? CLSSTATUS { get; set; }
}
