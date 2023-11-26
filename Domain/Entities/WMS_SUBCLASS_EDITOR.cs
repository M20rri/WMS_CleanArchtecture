using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_SUBCLASS_EDITOR")]
public partial class WMS_SUBCLASS_EDITOR
{
    [Key]
    public int SUBCLSID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SUBCLSNAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SUBCLASSACTION { get; set; }

    public int? CLASSID { get; set; }

    public int? SUBCLSSTATUS { get; set; }
}
