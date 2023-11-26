using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_APILOG")]
public partial class WMS_APILOG
{
    [Key]
    public int LOGID { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string MODULE { get; set; }

    [StringLength(250)]
    public string APIURL { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string APISTATUS { get; set; }

    public string APIREQUEST { get; set; }

    public string APIRESPONSE { get; set; }

    public string ERRPRMSG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LOGDATE { get; set; }

    public string REMARKS { get; set; }
}
