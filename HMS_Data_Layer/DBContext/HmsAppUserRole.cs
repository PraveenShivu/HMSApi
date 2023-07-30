using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("HMS_AppUser_Roles")]
public partial class HmsAppUserRole
{
    [Key]
    [Column("AppUserRole_Id")]
    public int AppUserRoleId { get; set; }

    [Column("Role_Id")]
    public int RoleId { get; set; }

    [Column("AppUserID")]
    public int AppUserId { get; set; }

    public byte IsActive { get; set; }

    [Column("Created_Date", TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [Column("Created_By")]
    public int CreatedBy { get; set; }

    [Column("Updated_Date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("Updated_By")]
    public int? UpdatedBy { get; set; }

    [ForeignKey("AppUserId")]
    [InverseProperty("HmsAppUserRoleAppUsers")]
    public virtual HmsAppUser AppUser { get; set; } = null!;

    [ForeignKey("CreatedBy")]
    [InverseProperty("HmsAppUserRoleCreatedByNavigations")]
    public virtual HmsAppUser CreatedByNavigation { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("HmsAppUserRoles")]
    public virtual HmsRole Role { get; set; } = null!;

    [ForeignKey("UpdatedBy")]
    [InverseProperty("HmsAppUserRoleUpdatedByNavigations")]
    public virtual HmsAppUser? UpdatedByNavigation { get; set; }
}
