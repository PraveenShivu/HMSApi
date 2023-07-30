using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Keyless]
[Table("DummyProvider")]
public partial class DummyProvider
{
    public int Title { get; set; }

    [Column("First Name")]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Column("Last Name")]
    [StringLength(50)]
    public string LastName { get; set; } = null!;

    public int Gender { get; set; }

    [Column(TypeName = "date")]
    public DateTime Dob { get; set; }

    [Column("Role ID")]
    public int RoleId { get; set; }

    [Column("C Type ID")]
    public int CTypeId { get; set; }

    [Column("Pre AD")]
    [StringLength(150)]
    public string PreAd { get; set; } = null!;

    [Column("P A ID")]
    public long PAId { get; set; }

    [Column("Perma AD")]
    [StringLength(150)]
    public string PermaAd { get; set; } = null!;

    [Column("Perm Area")]
    public long PermArea { get; set; }

    [Column("Act F")]
    public bool ActF { get; set; }
}
