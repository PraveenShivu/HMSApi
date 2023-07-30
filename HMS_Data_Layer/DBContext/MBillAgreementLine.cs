using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillAgreementLine")]
public partial class MBillAgreementLine
{
    [Key]
    public int AgreementLineId { get; set; }

    public int AgreementId { get; set; }

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

    public int? MaxQty { get; set; }

    [StringLength(3)]
    public string? AmountIndicator { get; set; }

    public int? Value { get; set; }

    [StringLength(3)]
    public string? Priority { get; set; }

    public int? Deductible { get; set; }

    [StringLength(10)]
    public string? CoverageType { get; set; }

    [StringLength(10)]
    public string? CoverageBy { get; set; }

    public int? MaxCoverage { get; set; }

    [StringLength(10)]
    public string? ApplicableTo { get; set; }

    public bool? IsPreauthRequired { get; set; }

    public bool? IsShared { get; set; }

    public int? RevisionNo { get; set; }

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

    [ForeignKey("AgreementId")]
    [InverseProperty("MBillAgreementLines")]
    public virtual MBillAgreement Agreement { get; set; } = null!;

    [ForeignKey("Gender")]
    [InverseProperty("MBillAgreementLineGenderNavigations")]
    public virtual MGeneralLookup? GenderNavigation { get; set; }

    [ForeignKey("Indicator")]
    [InverseProperty("MBillAgreementLineIndicatorNavigations")]
    public virtual MGeneralLookup IndicatorNavigation { get; set; } = null!;

    [ForeignKey("Nationality")]
    [InverseProperty("MBillAgreementLineNationalityNavigations")]
    public virtual MGeneralLookup? NationalityNavigation { get; set; }

    [ForeignKey("PatientTypeId")]
    [InverseProperty("MBillAgreementLinePatientTypes")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("Payer")]
    [InverseProperty("MBillAgreementLines")]
    public virtual MPayerRegistration? PayerNavigation { get; set; }

    [ForeignKey("Provider")]
    [InverseProperty("MBillAgreementLines")]
    public virtual MProvider? ProviderNavigation { get; set; }

    [InverseProperty("AgreementLine")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountCharges { get; set; } = new List<TPatientAccountCharge>();

    [ForeignKey("WardTypeId")]
    [InverseProperty("MBillAgreementLineWardTypes")]
    public virtual MGeneralLookup? WardType { get; set; }
}
