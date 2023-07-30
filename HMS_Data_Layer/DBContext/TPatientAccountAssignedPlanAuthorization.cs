using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountAssignedPlanAuthorization")]
public partial class TPatientAccountAssignedPlanAuthorization
{
    [Key]
    public int PlanAuthId { get; set; }

    public int AssignedPlanId { get; set; }

    [StringLength(50)]
    public string AuthReference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime AuthDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AuthValidFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AuthValidTo { get; set; }

    public bool? IsDaysRestricted { get; set; }

    public int? ApprovedDays { get; set; }

    public bool? IsAmtAuthorized { get; set; }

    public int? AuthAmount { get; set; }

    public int? AmtDeductible { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("AssignedPlanId")]
    [InverseProperty("TPatientAccountAssignedPlanAuthorizations")]
    public virtual TPatientAccountAssignedPlan AssignedPlan { get; set; } = null!;

    [InverseProperty("PlanAuth")]
    public virtual ICollection<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLines { get; set; } = new List<TPatientAccountAuthorizationLine>();
}
