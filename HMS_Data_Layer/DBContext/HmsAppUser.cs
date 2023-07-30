using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("HMS_AppUser")]
public partial class HmsAppUser
{
    [Key]
    [Column("AppUser_Id")]
    public int AppUserId { get; set; }

    [Column("UserID")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("Email_Id")]
    [StringLength(100)]
    [Unicode(false)]
    public string EmailId { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public byte IsActive { get; set; }

    [Column("Created_Date", TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [Column("Created_By")]
    public int? CreatedBy { get; set; }

    [Column("Updated_Date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("Updated_By")]
    public int? UpdatedBy { get; set; }

    [InverseProperty("AppUser")]
    public virtual ICollection<HmsAppUserRole> HmsAppUserRoleAppUsers { get; set; } = new List<HmsAppUserRole>();

    [InverseProperty("CreatedByNavigation")]
    public virtual ICollection<HmsAppUserRole> HmsAppUserRoleCreatedByNavigations { get; set; } = new List<HmsAppUserRole>();

    [InverseProperty("UpdatedByNavigation")]
    public virtual ICollection<HmsAppUserRole> HmsAppUserRoleUpdatedByNavigations { get; set; } = new List<HmsAppUserRole>();

    [InverseProperty("CreatedByNavigation")]
    public virtual ICollection<HmsFacility> HmsFacilityCreatedByNavigations { get; set; } = new List<HmsFacility>();

    [InverseProperty("UpdatedByNavigation")]
    public virtual ICollection<HmsFacility> HmsFacilityUpdatedByNavigations { get; set; } = new List<HmsFacility>();

    [InverseProperty("CreatedByNavigation")]
    public virtual ICollection<HmsRole> HmsRoleCreatedByNavigations { get; set; } = new List<HmsRole>();

    [InverseProperty("UpdatedByNavigation")]
    public virtual ICollection<HmsRole> HmsRoleUpdatedByNavigations { get; set; } = new List<HmsRole>();
}
