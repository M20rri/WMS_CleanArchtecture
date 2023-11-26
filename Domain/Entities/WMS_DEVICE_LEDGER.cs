using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_DEVICE_LEDGER")]
public partial class WMS_DEVICE_LEDGER
{
    public int ID { get; set; }

    public long? SYNCID { get; set; }

    public long? ITEMID { get; set; }

    [StringLength(100)]
    public string DEVICEID { get; set; }

    [StringLength(100)]
    public string ZONEID { get; set; }

    public int? QUANTITY { get; set; }

    [StringLength(100)]
    public string ITEMNO { get; set; }
}
