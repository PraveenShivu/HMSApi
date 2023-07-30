using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountAuthorizationLine")]
public partial class TPatientAccountAuthorizationLine
{
    [Key]
    public int AuthLineId { get; set; }

    public int PlanAuthId { get; set; }

    public int? WardTypeId { get; set; }

    public int? PatientTypeId { get; set; }

    public int? Gender { get; set; }

    public int? Nationality { get; set; }

    public int? Payer { get; set; }

    public int? Provider { get; set; }

    public int? IncomeLimit { get; set; }

    public int Indicator { get; set; }

    public int? IndicatorDescriptionId { get; set; }

    public bool? IsExcluded { get; set; }

    [StringLength(20)]
    public string? DenialCode { get; set; }

    public int? Qty { get; set; }

    [StringLength(3)]
    public string? AmtIndicator { get; set; }

    public int? Value { get; set; }

    [StringLength(3)]
    public string? Priority { get; set; }

    public int? AmtRequested { get; set; }

    public int? AmtDeductible { get; set; }

    [StringLength(10)]
    public string? CoverageType { get; set; }

    [StringLength(10)]
    public string? CoverageBy { get; set; }

    public int? MaxCoverageAmt { get; set; }

    [StringLength(10)]
    public string? ApprovalCode { get; set; }

    [StringLength(100)]
    public string? Remarks { get; set; }

    [StringLength(10)]
    public string? Status { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("Gender")]
    [InverseProperty("TPatientAccountAuthorizationLineGenderNavigations")]
    public virtual MGeneralLookup? GenderNavigation { get; set; }

    [ForeignKey("Indicator")]
    [InverseProperty("TPatientAccountAuthorizationLineIndicatorNavigations")]
    public virtual MGeneralLookup IndicatorNavigation { get; set; } = null!;

    [ForeignKey("Nationality")]
    [InverseProperty("TPatientAccountAuthorizationLineNationalityNavigations")]
    public virtual MGeneralLookup? NationalityNavigation { get; set; }

    [ForeignKey("PatientTypeId")]
    [InverseProperty("TPatientAccountAuthorizationLinePatientTypes")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("Payer")]
    [InverseProperty("TPatientAccountAuthorizationLines")]
    public virtual MPayerRegistration? PayerNavigation { get; set; }

    [ForeignKey("PlanAuthId")]
    [InverseProperty("TPatientAccountAuthorizationLines")]
    public virtual TPatientAccountAssignedPlanAuthorization PlanAuth { get; set; } = null!;

    [ForeignKey("Provider")]
    [InverseProperty("TPatientAccountAuthorizationLines")]
    public virtual MProvider? ProviderNavigation { get; set; }

    [ForeignKey("WardTypeId")]
    [InverseProperty("TPatientAccountAuthorizationLineWardTypes")]
    public virtual MGeneralLookup? WardType { get; set; }
}
