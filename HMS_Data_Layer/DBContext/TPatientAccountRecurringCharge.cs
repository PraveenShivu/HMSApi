using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountRecurringCharge")]
public partial class TPatientAccountRecurringCharge
{
    [Key]
    public long RecurringChargeId { get; set; }

    public int? FacilityId { get; set; }

    public int? PatientTypeId { get; set; }

    public int? AccommodationType { get; set; }

    public int? ServiceId { get; set; }

    public bool? IsProviderMandatory { get; set; }

    public bool? IsRuleApplicable { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveTo { get; set; }

    public int? ServiceQuantity { get; set; }

    public int? ServiceRate { get; set; }

    [StringLength(50)]
    public string? ChargeFrequency { get; set; }

    public int? FrequencyValue { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? ActiveFlag { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("TPatientAccountRecurringCharges")]
    public virtual MFacility? Facility { get; set; }

    [ForeignKey("PatientTypeId")]
    [InverseProperty("TPatientAccountRecurringCharges")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("ServiceId")]
    [InverseProperty("TPatientAccountRecurringCharges")]
    public virtual MBillService? Service { get; set; }
}
