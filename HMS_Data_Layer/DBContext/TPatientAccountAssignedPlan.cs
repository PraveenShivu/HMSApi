using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountAssignedPlan")]
public partial class TPatientAccountAssignedPlan
{
    [Key]
    public int AssignedPlanId { get; set; }

    public int FacilityId { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    public int? PayerId { get; set; }

    public int? EmployerId { get; set; }

    public int? InsurerId { get; set; }

    public int TariffPlanId { get; set; }

    [StringLength(50)]
    public string? AgreementReference { get; set; }

    [StringLength(50)]
    public string? DocumentReference { get; set; }

    [StringLength(20)]
    public string? EmployeeNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MembershipValidFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MembershipValidTo { get; set; }

    [StringLength(50)]
    public string? VerificationRemarks { get; set; }

    public bool? IsParentPriceApplicable { get; set; }

    public int? EligibleWardTypeId { get; set; }

    public int? Priority { get; set; }

    public bool IsActive { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("EligibleWardTypeId")]
    [InverseProperty("TPatientAccountAssignedPlans")]
    public virtual MGeneralLookup? EligibleWardType { get; set; }

    [ForeignKey("EmployerId")]
    [InverseProperty("TPatientAccountAssignedPlanEmployers")]
    public virtual MPayerRegistration? Employer { get; set; }

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientAccountAssignedPlans")]
    public virtual TEncounter Encounter { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("TPatientAccountAssignedPlans")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("InsurerId")]
    [InverseProperty("TPatientAccountAssignedPlanInsurers")]
    public virtual MPayerRegistration? Insurer { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientAccountAssignedPlans")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;

    [ForeignKey("PayerId")]
    [InverseProperty("TPatientAccountAssignedPlanPayers")]
    public virtual MPayerRegistration? Payer { get; set; }

    [InverseProperty("AssignedPlan")]
    public virtual ICollection<TPatientAccountAssignedPlanAuthorization> TPatientAccountAssignedPlanAuthorizations { get; set; } = new List<TPatientAccountAssignedPlanAuthorization>();

    [ForeignKey("TariffPlanId")]
    [InverseProperty("TPatientAccountAssignedPlans")]
    public virtual MBillPriceTariff TariffPlan { get; set; } = null!;
}
