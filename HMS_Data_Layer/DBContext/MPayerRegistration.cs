using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PayerRegistration")]
public partial class MPayerRegistration
{
    [Key]
    public int PayerId { get; set; }

    public int PayerTypeId { get; set; }

    [StringLength(100)]
    public string PayerName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveTo { get; set; }

    [StringLength(50)]
    public string? ContactPerson { get; set; }

    public bool Status { get; set; }

    [StringLength(1)]
    public string Tariff { get; set; } = null!;

    [StringLength(100)]
    public string AddressLine { get; set; } = null!;

    [StringLength(50)]
    public string Area { get; set; } = null!;

    [StringLength(50)]
    public string City { get; set; } = null!;

    public int StateId { get; set; }

    public int CountryId { get; set; }

    [StringLength(10)]
    public string? PinCode { get; set; }

    [StringLength(30)]
    public string? MobileNo { get; set; }

    [StringLength(30)]
    public string? LandlineNo { get; set; }

    [StringLength(80)]
    public string? EmailId { get; set; }

    public int? CreditDays { get; set; }

    [StringLength(1)]
    public string IsDunningApplicable { get; set; } = null!;

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("MPayerRegistrationCountries")]
    public virtual MGeneralLookup Country { get; set; } = null!;

    [InverseProperty("Employer")]
    public virtual ICollection<MBillAgreement> MBillAgreementEmployers { get; set; } = new List<MBillAgreement>();

    [InverseProperty("Insurer")]
    public virtual ICollection<MBillAgreement> MBillAgreementInsurers { get; set; } = new List<MBillAgreement>();

    [InverseProperty("PayerNavigation")]
    public virtual ICollection<MBillAgreementLine> MBillAgreementLines { get; set; } = new List<MBillAgreementLine>();

    [InverseProperty("Payer")]
    public virtual ICollection<MBillAgreement> MBillAgreementPayers { get; set; } = new List<MBillAgreement>();

    [InverseProperty("PayerNavigation")]
    public virtual ICollection<MBillPriceTariffLine> MBillPriceTariffLines { get; set; } = new List<MBillPriceTariffLine>();

    [InverseProperty("Payer")]
    public virtual ICollection<MPayerIdentification> MPayerIdentifications { get; set; } = new List<MPayerIdentification>();

    [ForeignKey("PayerTypeId")]
    [InverseProperty("MPayerRegistrationPayerTypes")]
    public virtual MGeneralLookup PayerType { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("MPayerRegistrations")]
    public virtual MState State { get; set; } = null!;

    [InverseProperty("Employer")]
    public virtual ICollection<TPatientAccountAssignedPlan> TPatientAccountAssignedPlanEmployers { get; set; } = new List<TPatientAccountAssignedPlan>();

    [InverseProperty("Insurer")]
    public virtual ICollection<TPatientAccountAssignedPlan> TPatientAccountAssignedPlanInsurers { get; set; } = new List<TPatientAccountAssignedPlan>();

    [InverseProperty("Payer")]
    public virtual ICollection<TPatientAccountAssignedPlan> TPatientAccountAssignedPlanPayers { get; set; } = new List<TPatientAccountAssignedPlan>();

    [InverseProperty("PayerNavigation")]
    public virtual ICollection<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLines { get; set; } = new List<TPatientAccountAuthorizationLine>();

    [InverseProperty("Payer")]
    public virtual ICollection<TPatientAccountDefaultTariff> TPatientAccountDefaultTariffs { get; set; } = new List<TPatientAccountDefaultTariff>();
}
