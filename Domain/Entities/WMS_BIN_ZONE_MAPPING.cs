using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_BIN_ZONE_MAPPING")]
public partial class WMS_BIN_ZONE_MAPPING
{
    [Key]
    public int ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NEWZONEID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZONEID { get; set; }
}
