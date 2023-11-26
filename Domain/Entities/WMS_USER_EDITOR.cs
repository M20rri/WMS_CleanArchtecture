using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_USER_EDITOR")]
[Index("USERNAME", Name = "IX_WMS_USER_EDITOR")]
[Index("USERID", Name = "IX_WMS_USER_EDITOR_2", IsUnique = true)]
public partial class WMS_USER_EDITOR
{
    [Key]
    public int SRNO { get; set; }

    public int USERID { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string USERNAME { get; set; }

    [StringLength(100)]
    public string? USERPASSWORD { get; set; }

    public int? ROLLID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? STOREID { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? APIURL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PUTZONE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PICKZONE { get; set; }

    public int? USERSTATUS { get; set; }

    public int? ISBULKSCAN { get; set; }

    public int? LOGINATTEMPTS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LOGINATTEMPTSON { get; set; }
}
