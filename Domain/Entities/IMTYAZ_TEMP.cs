using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("IMTYAZ_TEMP")]
public partial class IMTYAZ_TEMP
{
    [StringLength(12)]
    [Unicode(false)]
    public string SRNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINNO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BINSEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ITEMDESC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string USERID { get; set; }
}
