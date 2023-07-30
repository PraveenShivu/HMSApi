using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PatientAccountAdditionalChargesAssociation")]
public partial class MPatientAccountAdditionalChargesAssociation
{
    [Key]
    public int AssociationId { get; set; }

    public int AdditionalChargeId { get; set; }

    public int IndicatorId { get; set; }

    public int? DescriptionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveTo { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("AdditionalChargeId")]
    [InverseProperty("MPatientAccountAdditionalChargesAssociations")]
    public virtual MPatientAccountAdditionalCharge AdditionalCharge { get; set; } = null!;

    [ForeignKey("IndicatorId")]
    [InverseProperty("MPatientAccountAdditionalChargesAssociations")]
    public virtual MGeneralLookup Indicator { get; set; } = null!;
}
