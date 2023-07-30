using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountCharge")]
public partial class TPatientAccountCharge
{
    [Key]
    [Column("ChargeID")]
    public long ChargeId { get; set; }

    [StringLength(50)]
    public string? SourceTransactionCode { get; set; }

    [Column("OrderID")]
    public long? OrderId { get; set; }

    [Column("FacillityID")]
    public int FacillityId { get; set; }

    [Column("PatientID")]
    public long PatientId { get; set; }

    [Column("EncounterID")]
    public long EncounterId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ServiceDate { get; set; }

    [Column("ServiceID")]
    public int? ServiceId { get; set; }

    [Column("ServiceClassificationID")]
    public int? ServiceClassificationId { get; set; }

    [Column("ServiceGroupID")]
    public int? ServiceGroupId { get; set; }

    [Column("DepartmentID")]
    public int? DepartmentId { get; set; }

    [Column("ProviderID")]
    public int ProviderId { get; set; }

    public int? ServiceQuantity { get; set; }

    [Column("ServiceUOM")]
    public int? ServiceUom { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Rate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ChargeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? DiscountRate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TaxRate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? NetAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientChargeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientDiscountRate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientDiscountAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientTaxRate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientTaxAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientNetAmount { get; set; }

    public bool? PackageCovered { get; set; }

    [Column("PackageID")]
    public int? PackageId { get; set; }

    public int? PackageQuantity { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PackageRate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PackageAmount { get; set; }

    [Column("PatientTypeID")]
    public int? PatientTypeId { get; set; }

    public int? WardType { get; set; }

    public int? ChargeableWardType { get; set; }

    [Column("PerformingFacilityID")]
    public int? PerformingFacilityId { get; set; }

    [Column("PerformingLocationID")]
    public int? PerformingLocationId { get; set; }

    public bool? IsBilled { get; set; }

    [Column("PatientBillID")]
    public long? PatientBillId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public bool? OneTime { get; set; }

    public bool? BaseCharge { get; set; }

    [Column("AgreementLineID")]
    public int? AgreementLineId { get; set; }

    public bool? IsEncounterCharge { get; set; }

    public int? ProcedureChargeId { get; set; }

    [StringLength(10)]
    public string? ServiceType { get; set; }

    [StringLength(50)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    public bool? IsBillCancelled { get; set; }

    [StringLength(50)]
    public string? AuthorizationGivenBy { get; set; }

    [StringLength(10)]
    public string? BillType { get; set; }

    public int? StockId { get; set; }

    public int? StoreId { get; set; }

    public bool? IsChargeApplicable { get; set; }

    public bool? PackageActive { get; set; }

    public bool? IncludeInPackage { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ServiceStatus { get; set; }

    [Column("K_Status")]
    [StringLength(50)]
    public string? KStatus { get; set; }

    [Column("K_Message")]
    [StringLength(150)]
    public string? KMessage { get; set; }

    [Column("K_OpBillNum")]
    [StringLength(150)]
    public string? KOpBillNum { get; set; }

    [Column("K_LabNum")]
    [StringLength(150)]
    public string? KLabNum { get; set; }

    [Column("K_InvId")]
    public long? KInvId { get; set; }

    [Column("PayerID")]
    public long? PayerId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PayerTotal { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? AdjustedAmt { get; set; }

    [ForeignKey("AgreementLineId")]
    [InverseProperty("TPatientAccountCharges")]
    public virtual MBillAgreementLine? AgreementLine { get; set; }

    [ForeignKey("ChargeableWardType")]
    [InverseProperty("TPatientAccountChargeChargeableWardTypeNavigations")]
    public virtual MGeneralLookup? ChargeableWardTypeNavigation { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("TPatientAccountCharges")]
    public virtual MFacilityDepartment? Department { get; set; }

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientAccountCharges")]
    public virtual TEncounter Encounter { get; set; } = null!;

    [ForeignKey("FacillityId")]
    [InverseProperty("TPatientAccountChargeFacillities")]
    public virtual MFacility Facillity { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientAccountCharges")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;

    [ForeignKey("PatientBillId")]
    [InverseProperty("TPatientAccountCharges")]
    public virtual TPatientAccountBill? PatientBill { get; set; }

    [ForeignKey("PatientTypeId")]
    [InverseProperty("TPatientAccountChargePatientTypes")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("PerformingFacilityId")]
    [InverseProperty("TPatientAccountChargePerformingFacilities")]
    public virtual MFacility? PerformingFacility { get; set; }

    [ForeignKey("ProviderId")]
    [InverseProperty("TPatientAccountCharges")]
    public virtual MProvider Provider { get; set; } = null!;

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("TPatientAccountChargeServiceGroups")]
    public virtual MGeneralLookup? ServiceGroup { get; set; }

    [ForeignKey("ServiceUom")]
    [InverseProperty("TPatientAccountCharges")]
    public virtual MUom? ServiceUomNavigation { get; set; }

    [ForeignKey("WardType")]
    [InverseProperty("TPatientAccountChargeWardTypeNavigations")]
    public virtual MGeneralLookup? WardTypeNavigation { get; set; }
}
