using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Role")]
public partial class MRole
{
    [Key]
    public int RoleId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RoleName { get; set; }

    public int UserRoleId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MenuId { get; set; }

    [Unicode(false)]
    public string? SubMenuId { get; set; }

    public int? ActivityId { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    public bool? IsActive { get; set; }

    [Unicode(false)]
    public string? SubMenuChildId { get; set; }
}
