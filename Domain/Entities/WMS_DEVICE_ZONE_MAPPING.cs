using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_DEVICE_ZONE_MAPPING")]
[Index("ZONEID", "DEVICEID", Name = "IX_WMS_DEVICE_ZONE_MAPPING_1", IsUnique = true)]
public partial class WMS_DEVICE_ZONE_MAPPING
{
    public int ID { get; set; }

    [StringLength(100)]
    public string ZONEID { get; set; }

    [StringLength(100)]
    public string DEVICEID { get; set; }

    public int? DEVICEPRIORITY { get; set; }

    public int? ISACTIVE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ACTIVEDATETIME { get; set; }

    [StringLength(100)]
    public string ACTIVEBY { get; set; }

    public int? THRESHOLDLIMIT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PROCESSNAME { get; set; }
}
