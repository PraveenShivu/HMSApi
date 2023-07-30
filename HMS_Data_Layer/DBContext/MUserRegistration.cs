using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_UserRegistration")]
public partial class MUserRegistration
{
    [Key]
    public int UserRegistrationId { get; set; }

    [StringLength(50)]
    public string? UserId { get; set; }

    [StringLength(50)]
    public string? FacilityId { get; set; }

    [StringLength(100)]
    public string? ProviderName { get; set; }

    public int? ProviderId { get; set; }

    [StringLength(200)]
    public string? EmailId { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [StringLength(50)]
    public string? ConfirmPassword { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? AuthPin { get; set; }

    public int? UserRoleId { get; set; }

    [StringLength(50)]
    public string? UserRoleName { get; set; }

    [StringLength(50)]
    public string? UserLoginName { get; set; }

    [StringLength(80)]
    public string? FacilityName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedBy { get; set; }

    public bool? Lock { get; set; }

    public bool IsCashier { get; set; }
}
