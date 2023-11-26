using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_SUBROLL_EDITOR")]
public partial class WMS_SUBROLL_EDITOR
{
    [Key]
    public int SUBROLLID { get; set; }

    public int ROLLID { get; set; }

    public int? CLSID { get; set; }

    public int? SUBCLASSID { get; set; }

    public int? SUBCLSSTATUS { get; set; }
}
