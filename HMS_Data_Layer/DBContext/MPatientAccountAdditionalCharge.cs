using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PatientAccountAdditionalCharges")]
public partial class MPatientAccountAdditionalCharge
{
    [Key]
    public int AdditionalChargeId { get; set; }

    public int FacilityId { get; set; }

    [StringLength(20)]
    public string ShortName { get; set; } = null!;

    [StringLength(50)]
    public string LongName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveTo { get; set; }

    [StringLength(30)]
    public string? AdditionalChargeType { get; set; }

    public bool? CoveredByPayer { get; set; }

    public bool? IncludeBonusQuantity { get; set; }

    [StringLength(30)]
    public string? TaxType { get; set; }

    [StringLength(100)]
    public string? Remarks { get; set; }

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

    public bool? ChargeFromPatientAmt { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MPatientAccountAdditionalCharges")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("AdditionalCharge")]
    public virtual ICollection<MPatientAccountAdditionalChargesAssociation> MPatientAccountAdditionalChargesAssociations { get; set; } = new List<MPatientAccountAdditionalChargesAssociation>();

    [InverseProperty("AdditionalCharge")]
    public virtual ICollection<MPatientAccountAdditionalChargesRule> MPatientAccountAdditionalChargesRules { get; set; } = new List<MPatientAccountAdditionalChargesRule>();

    [InverseProperty("AdditionalCharge")]
    public virtual ICollection<MPatientAccountAdditionalChargesSurgery> MPatientAccountAdditionalChargesSurgeries { get; set; } = new List<MPatientAccountAdditionalChargesSurgery>();
}
