using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("WMS_USER_EDITOR")]
[Index("Username", Name = "IX_WMS_USER_EDITOR")]
[Index("Userid", Name = "IX_WMS_USER_EDITOR_2", IsUnique = true)]
public partial class WmsUserEditor
{
    [Key]
    [Column("SRNO")]
    public int Srno { get; set; }

    [Column("USERID")]
    public int Userid { get; set; }

    [Required]
    [Column("USERNAME")]
    [StringLength(50)]    
    public string Username { get; set; }

    [Column("USERPASSWORD")]
    [StringLength(100)]
    public string Userpassword { get; set; }

    [Column("ROLLID")]
    public int? Rollid { get; set; }

    [Column("STOREID")]
    [StringLength(50)]    
    public string Storeid { get; set; }

    [Column("APIURL")]
    [StringLength(250)]    
    public string Apiurl { get; set; }

    [Column("PUTZONE")]
    [StringLength(50)]    
    public string Putzone { get; set; }

    [Column("PICKZONE")]
    [StringLength(50)]    
    public string Pickzone { get; set; }

    [Column("USERSTATUS")]
    public int? Userstatus { get; set; }

    [Column("ISBULKSCAN")]
    public int? Isbulkscan { get; set; }

    [Column("LOGINATTEMPTS")]
    public int? Loginattempts { get; set; }

    [Column("LOGINATTEMPTSON", TypeName = "datetime")]
    public DateTime? Loginattemptson { get; set; }
}