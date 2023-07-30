using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PatientAccountAdditionalChargesRule")]
public partial class MPatientAccountAdditionalChargesRule
{
    [Key]
    public int AdditionalChargeRuleId { get; set; }

    public int AdditionalChargeId { get; set; }

    [StringLength(50)]
    public string ComponentName { get; set; } = null!;

    [StringLength(20)]
    public string ChargeType { get; set; } = null!;

    public int ChargeValue { get; set; }

    [StringLength(20)]
    public string AdditionalChargeIndicator { get; set; } = null!;

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
    [InverseProperty("MPatientAccountAdditionalChargesRules")]
    public virtual MPatientAccountAdditionalCharge AdditionalCharge { get; set; } = null!;
}
