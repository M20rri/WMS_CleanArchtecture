using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("TBLDEVICE")]
public partial class TBLDEVICE
{
    [StringLength(50)]
    [Unicode(false)]
    public string DEVICEID { get; set; }
}
