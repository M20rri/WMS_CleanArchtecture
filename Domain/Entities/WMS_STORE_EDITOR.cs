using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("WMS_STORE_EDITOR")]
public partial class WMS_STORE_EDITOR
{
    public int SRNO { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string STOREID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string COUNTRY { get; set; }

    public int? STATUS { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string BASEURL_NAV { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string BASEURL_OFS { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string BASEURL_MAGENTO { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string PACKAGINGLOCATIONNAME { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string PACKAGINGLOCATIONID { get; set; }

    public int? APPSCANLIMIT { get; set; }

    public int? APPSERVICEINTERVAL { get; set; }
}
