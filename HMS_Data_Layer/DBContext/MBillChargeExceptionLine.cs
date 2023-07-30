using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillChargeExceptionLine")]
public partial class MBillChargeExceptionLine
{
    [Key]
    public int ExceptionLineId { get; set; }

    public int ExceptionHeaderId { get; set; }

    [StringLength(100)]
    public string? ChargeFactor { get; set; }

    [StringLength(10)]
    public string? ChargeIndicator { get; set; }

    public int? Value1 { get; set; }

    public int? Value2 { get; set; }

    public int? Interval { get; set; }

    public int? Indicator { get; set; }

    public int? IndicatorDescriptionId { get; set; }

    public long? HolidayId { get; set; }

    public int? ServiceLocationId { get; set; }

    public TimeSpan? TimeFrom { get; set; }

    public TimeSpan? TimeTo { get; set; }

    public int? ProviderId { get; set; }

    public int? PatientTypeId { get; set; }

    [StringLength(30)]
    public string? Applicability { get; set; }

    [StringLength(30)]
    public string? ChargeException { get; set; }

    public int? FactorAmount { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("ExceptionHeaderId")]
    [InverseProperty("MBillChargeExceptionLines")]
    public virtual MBillChargeExceptionHeader ExceptionHeader { get; set; } = null!;

    [ForeignKey("HolidayId")]
    [InverseProperty("MBillChargeExceptionLines")]
    public virtual MScheduleFacilityHoliday? Holiday { get; set; }

    [ForeignKey("Indicator")]
    [InverseProperty("MBillChargeExceptionLineIndicatorNavigations")]
    public virtual MGeneralLookup? IndicatorNavigation { get; set; }

    [ForeignKey("PatientTypeId")]
    [InverseProperty("MBillChargeExceptionLinePatientTypes")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("ProviderId")]
    [InverseProperty("MBillChargeExceptionLines")]
    public virtual MProvider? Provider { get; set; }

    [ForeignKey("ServiceLocationId")]
    [InverseProperty("MBillChargeExceptionLines")]
    public virtual MServiceLocation? ServiceLocation { get; set; }
}
