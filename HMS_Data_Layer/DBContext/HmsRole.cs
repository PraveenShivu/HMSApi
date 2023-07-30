using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("HMS_Roles")]
public partial class HmsRole
{
    [Key]
    [Column("Role_Id")]
    public int RoleId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string RoleName { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string RoleDescription { get; set; } = null!;

    public byte IsActive { get; set; }

    [Column("Created_Date", TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [Column("Created_By")]
    public int CreatedBy { get; set; }

    [Column("Updated_Date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("Updated_By")]
    public int? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy")]
    [InverseProperty("HmsRoleCreatedByNavigations")]
    public virtual HmsAppUser CreatedByNavigation { get; set; } = null!;

    [InverseProperty("Role")]
    public virtual ICollection<HmsAppUserRole> HmsAppUserRoles { get; set; } = new List<HmsAppUserRole>();

    [InverseProperty("Role")]
    public virtual ICollection<HmsRolesMenu> HmsRolesMenus { get; set; } = new List<HmsRolesMenu>();

    [ForeignKey("UpdatedBy")]
    [InverseProperty("HmsRoleUpdatedByNavigations")]
    public virtual HmsAppUser? UpdatedByNavigation { get; set; }
}
