using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PatientAccountAdditionalChargesSurgery")]
public partial class MPatientAccountAdditionalChargesSurgery
{
    [Key]
    public int SurgeryRuleId { get; set; }

    public int AdditionalChargeId { get; set; }

    public int AnesthesiaTypeId { get; set; }

    public int AnesthesiaChargeTypeId { get; set; }

    public int ChargeEntryCatalogId { get; set; }

    [StringLength(20)]
    public string ChargeType { get; set; } = null!;

    public int ChargeValue { get; set; }

    public int? DependOnServiceId { get; set; }

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
    [InverseProperty("MPatientAccountAdditionalChargesSurgeries")]
    public virtual MPatientAccountAdditionalCharge AdditionalCharge { get; set; } = null!;

    [ForeignKey("AnesthesiaChargeTypeId")]
    [InverseProperty("MPatientAccountAdditionalChargesSurgeryAnesthesiaChargeTypes")]
    public virtual MGeneralLookup AnesthesiaChargeType { get; set; } = null!;

    [ForeignKey("AnesthesiaTypeId")]
    [InverseProperty("MPatientAccountAdditionalChargesSurgeryAnesthesiaTypes")]
    public virtual MGeneralLookup AnesthesiaType { get; set; } = null!;

    [ForeignKey("ChargeEntryCatalogId")]
    [InverseProperty("MPatientAccountAdditionalChargesSurgeryChargeEntryCatalogs")]
    public virtual MBillService ChargeEntryCatalog { get; set; } = null!;

    [ForeignKey("DependOnServiceId")]
    [InverseProperty("MPatientAccountAdditionalChargesSurgeryDependOnServices")]
    public virtual MBillService? DependOnService { get; set; }
}
