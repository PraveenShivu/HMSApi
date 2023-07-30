using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_User")]
public partial class TUser
{
    [Key]
    [Column("PKID")]
    public long Pkid { get; set; }

    [StringLength(100)]
    public string Email { get; set; } = null!;

    [Column("CompanyID")]
    public long? CompanyId { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    public bool? IsActive { get; set; }
}
