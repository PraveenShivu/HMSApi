using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_User")]
public partial class MUser
{
    [Key]
    public int UserId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? UserEmail { get; set; }

    [StringLength(50)]
    public string? LoginId { get; set; }

    [StringLength(20)]
    public string? LoginPassword { get; set; }

    public int? EnterpriseId { get; set; }

    public int? FacilityId { get; set; }

    public int? ProviderId { get; set; }

    public int? RoleId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MenuId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SubMenuId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ActivityId { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsActive { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MUsers")]
    public virtual MFacility? Facility { get; set; }
}
