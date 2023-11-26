using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_LOCATIONTYPE")]
public partial class WMS_LOCATIONTYPE
{
    public int ID { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string LOCATIONTYPE { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string PREFIX { get; set; }
}
