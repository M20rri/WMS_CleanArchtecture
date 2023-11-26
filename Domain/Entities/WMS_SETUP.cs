using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_SETUP")]
public partial class WMS_SETUP
{
    public int ID { get; set; }

    public int? PICKLOADBALANCING { get; set; }

    public int? PICKVALIDATESAMELOT { get; set; }
}
