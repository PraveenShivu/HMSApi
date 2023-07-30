using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillAgreement")]
public partial class MBillAgreement
{
    [Key]
    public int AgreementId { get; set; }

    [StringLength(50)]
    public string AgreementReferenceNumber { get; set; } = null!;

    public int? FacilityId { get; set; }

    [StringLength(100)]
    public string AgreementDescription { get; set; } = null!;

    [StringLength(100)]
    public string? Remarks { get; set; }

    public int? PayerId { get; set; }

    public int? EmployerId { get; set; }

    public int? InsurerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ValidFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ValidTo { get; set; }

    public bool? PreauthRequired { get; set; }

    public bool? IsDaysRestricted { get; set; }

    public int? RestrictedDays { get; set; }

    public bool? IsDeductibleRestricted { get; set; }

    public int? RestrictedDeductible { get; set; }

    public int? RestrictedDeductibleType { get; set; }

    public bool? IsAuthLimitRestricted { get; set; }

    public int? RestrictedAuthLimit { get; set; }

    public int? RestrictedAuthLimitType { get; set; }

    [StringLength(50)]
    public string? DiscountShare { get; set; }

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

    [ForeignKey("EmployerId")]
    [InverseProperty("MBillAgreementEmployers")]
    public virtual MPayerRegistration? Employer { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MBillAgreements")]
    public virtual MFacility? Facility { get; set; }

    [ForeignKey("InsurerId")]
    [InverseProperty("MBillAgreementInsurers")]
    public virtual MPayerRegistration? Insurer { get; set; }

    [InverseProperty("Agreement")]
    public virtual ICollection<MBillAgreementLine> MBillAgreementLines { get; set; } = new List<MBillAgreementLine>();

    [ForeignKey("PayerId")]
    [InverseProperty("MBillAgreementPayers")]
    public virtual MPayerRegistration? Payer { get; set; }

    [ForeignKey("RestrictedAuthLimitType")]
    [InverseProperty("MBillAgreementRestrictedAuthLimitTypeNavigations")]
    public virtual MGeneralLookup? RestrictedAuthLimitTypeNavigation { get; set; }

    [ForeignKey("RestrictedDeductibleType")]
    [InverseProperty("MBillAgreementRestrictedDeductibleTypeNavigations")]
    public virtual MGeneralLookup? RestrictedDeductibleTypeNavigation { get; set; }
}
