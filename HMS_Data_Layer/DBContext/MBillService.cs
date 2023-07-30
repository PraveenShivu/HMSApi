using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillServices")]
public partial class MBillService
{
    [Key]
    public int ServiceId { get; set; }

    public int ServiceClassificationId { get; set; }

    public int FacilityId { get; set; }

    [StringLength(50)]
    public string ShortName { get; set; } = null!;

    [StringLength(100)]
    public string LongName { get; set; } = null!;

    [StringLength(1000)]
    public string? Remarks { get; set; }

    public int? UomId { get; set; }

    public int? CategoryId { get; set; }

    [StringLength(1)]
    public string? IsAtomic { get; set; }

    [StringLength(10)]
    public string Status { get; set; } = null!;

    [StringLength(1)]
    public string? OrderIsOrderable { get; set; }

    [StringLength(1)]
    public string? OrderIsFrequencyApplicable { get; set; }

    [StringLength(1)]
    public string? OrderIsScheduleApplicable { get; set; }

    [StringLength(1)]
    public string? OrderIsQuantityApplicable { get; set; }

    [StringLength(1)]
    public string? OrderPatientTypeEmergency { get; set; }

    [StringLength(1)]
    public string? OrderPatientTypeIp { get; set; }

    [StringLength(1)]
    public string? OrderPatientTypeAmbulatory { get; set; }

    [StringLength(1)]
    public string? OrderPatientTypeShortStay { get; set; }

    [StringLength(1)]
    public string? ExecutionResultApplicable { get; set; }

    [StringLength(1)]
    public string? ExecutionResultComponent { get; set; }

    [StringLength(1)]
    public string? ExecutionRequestAnesthetist { get; set; }

    public int? ExecutionMinimunServiceDuration { get; set; }

    public int? ExecutionStandardServiceDuration { get; set; }

    public int? ExecutionMaximumServiceDuration { get; set; }

    public int? ExecutionUomServiceDuration { get; set; }

    public int? PackageDays { get; set; }

    public int? PackageAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PackageFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PackageToDate { get; set; }

    [StringLength(1)]
    public string? PackageIsHealth { get; set; }

    [StringLength(1)]
    public string? PackageIsMultiEncounter { get; set; }

    public int? PackageNumberEncounter { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public bool? IsProviderRequired { get; set; }

    public bool? IsServiceEditable { get; set; }

    public bool? IsAssociateCharge { get; set; }

    public bool? IsSurgeryCharge { get; set; }

    [Required]
    public bool? IsSubTest { get; set; }

    [Required]
    public bool? IsRadiology { get; set; }

    public long? ResultType { get; set; }

    [StringLength(200)]
    public string? TestValues { get; set; }

    [Column("TemplateID")]
    public long? TemplateId { get; set; }

    public long? SampleTypeId { get; set; }

    [Required]
    public bool? IsFromTestValues { get; set; }

    [StringLength(200)]
    public string? NormalValForTestVal { get; set; }

    [Column("LabUOM")]
    [StringLength(100)]
    public string? LabUom { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("MBillServices")]
    public virtual MGeneralLookup? Category { get; set; }

    [ForeignKey("ExecutionUomServiceDuration")]
    [InverseProperty("MBillServiceExecutionUomServiceDurationNavigations")]
    public virtual MUom? ExecutionUomServiceDurationNavigation { get; set; }

    [InverseProperty("Service")]
    public virtual ICollection<MBillAutoCharge> MBillAutoCharges { get; set; } = new List<MBillAutoCharge>();

    [InverseProperty("Service")]
    public virtual ICollection<MBillBasePriceService> MBillBasePriceServices { get; set; } = new List<MBillBasePriceService>();

    [InverseProperty("ChargeEntryCatalog")]
    public virtual ICollection<MPatientAccountAdditionalChargesSurgery> MPatientAccountAdditionalChargesSurgeryChargeEntryCatalogs { get; set; } = new List<MPatientAccountAdditionalChargesSurgery>();

    [InverseProperty("DependOnService")]
    public virtual ICollection<MPatientAccountAdditionalChargesSurgery> MPatientAccountAdditionalChargesSurgeryDependOnServices { get; set; } = new List<MPatientAccountAdditionalChargesSurgery>();

    [InverseProperty("Service")]
    public virtual ICollection<MServiceLabAttribute> MServiceLabAttributes { get; set; } = new List<MServiceLabAttribute>();

    [InverseProperty("Service")]
    public virtual ICollection<MServiceMedicalCode> MServiceMedicalCodes { get; set; } = new List<MServiceMedicalCode>();

    [InverseProperty("Service")]
    public virtual ICollection<MServiceOrdering> MServiceOrderings { get; set; } = new List<MServiceOrdering>();

    [InverseProperty("Service")]
    public virtual ICollection<MServicePackage> MServicePackages { get; set; } = new List<MServicePackage>();

    [InverseProperty("Service")]
    public virtual ICollection<MServiceTat> MServiceTats { get; set; } = new List<MServiceTat>();

    [ForeignKey("ServiceClassificationId")]
    [InverseProperty("MBillServices")]
    public virtual MBillServiceClasssifcation ServiceClassification { get; set; } = null!;

    [InverseProperty("Service")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrders { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("ServicePackage")]
    public virtual ICollection<TPatientAccountPackageSubscription> TPatientAccountPackageSubscriptions { get; set; } = new List<TPatientAccountPackageSubscription>();

    [InverseProperty("Procedure")]
    public virtual ICollection<TPatientAccountProcedureCharge> TPatientAccountProcedureCharges { get; set; } = new List<TPatientAccountProcedureCharge>();

    [InverseProperty("AssociativeService")]
    public virtual ICollection<TPatientAccountProcedureChargesDetail> TPatientAccountProcedureChargesDetails { get; set; } = new List<TPatientAccountProcedureChargesDetail>();

    [InverseProperty("Service")]
    public virtual ICollection<TPatientAccountRecurringCharge> TPatientAccountRecurringCharges { get; set; } = new List<TPatientAccountRecurringCharge>();

    [ForeignKey("UomId")]
    [InverseProperty("MBillServiceUoms")]
    public virtual MUom? Uom { get; set; }
}
