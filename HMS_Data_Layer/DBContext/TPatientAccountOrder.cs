using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountOrders")]
public partial class TPatientAccountOrder
{
    [Key]
    [Column("OrderID")]
    public long OrderId { get; set; }

    [Column("OrderingFacilityID")]
    public int OrderingFacilityId { get; set; }

    [Column("PatientID")]
    public long PatientId { get; set; }

    [Column("EncounterID")]
    public long EncounterId { get; set; }

    [StringLength(100)]
    public string OrderNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime OrderDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderEndTime { get; set; }

    [Column("ServiceGroupID")]
    public int? ServiceGroupId { get; set; }

    [Column("ServiceClassificationID")]
    public int? ServiceClassificationId { get; set; }

    [Column("ServiceID")]
    public int? ServiceId { get; set; }

    public int? OrderQuantity { get; set; }

    public int? OrderStatus { get; set; }

    [StringLength(20)]
    public string Priority { get; set; } = null!;

    public int? AcknowledgedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AcknowledgedDate { get; set; }

    [Column("PatientTypeID")]
    public int? PatientTypeId { get; set; }

    [Column("PerformingFacilityID")]
    public int? PerformingFacilityId { get; set; }

    [Column("PerformingLocationID")]
    public int? PerformingLocationId { get; set; }

    [Column("DepartmentID")]
    public int? DepartmentId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? ProcedureChargeId { get; set; }

    [Column("UomID")]
    public int? UomId { get; set; }

    [ForeignKey("AcknowledgedBy")]
    [InverseProperty("TPatientAccountOrders")]
    public virtual MProvider? AcknowledgedByNavigation { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("TPatientAccountOrders")]
    public virtual MFacilityDepartment? Department { get; set; }

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientAccountOrders")]
    public virtual TEncounter Encounter { get; set; } = null!;

    [ForeignKey("OrderStatus")]
    [InverseProperty("TPatientAccountOrderOrderStatusNavigations")]
    public virtual MGeneralLookup? OrderStatusNavigation { get; set; }

    [ForeignKey("OrderingFacilityId")]
    [InverseProperty("TPatientAccountOrderOrderingFacilities")]
    public virtual MFacility OrderingFacility { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientAccountOrders")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;

    [ForeignKey("PatientTypeId")]
    [InverseProperty("TPatientAccountOrderPatientTypes")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("PerformingFacilityId")]
    [InverseProperty("TPatientAccountOrderPerformingFacilities")]
    public virtual MFacility? PerformingFacility { get; set; }

    [ForeignKey("ServiceId")]
    [InverseProperty("TPatientAccountOrders")]
    public virtual MBillService? Service { get; set; }

    [ForeignKey("ServiceClassificationId")]
    [InverseProperty("TPatientAccountOrders")]
    public virtual MBillServiceClasssifcation? ServiceClassification { get; set; }

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("TPatientAccountOrderServiceGroups")]
    public virtual MGeneralLookup? ServiceGroup { get; set; }
}
