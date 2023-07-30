using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillAutoCharge")]
public partial class MBillAutoCharge
{
    [Key]
    public int AutoChargeId { get; set; }

    public int? FacilityId { get; set; }

    public int? DepartmentId { get; set; }

    public int? EncounterTypeId { get; set; }

    public int? ProviderId { get; set; }

    public int? PatientTypeId { get; set; }

    public int ServiceId { get; set; }

    public bool? IsOneTime { get; set; }

    public int? ChargeProviderId { get; set; }

    public bool? ChargeEncounterProvider { get; set; }

    public bool? FollowUpService { get; set; }

    public int? ValidForDays { get; set; }

    [StringLength(20)]
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

    [ForeignKey("DepartmentId")]
    [InverseProperty("MBillAutoCharges")]
    public virtual MFacilityDepartment? Department { get; set; }

    [ForeignKey("EncounterTypeId")]
    [InverseProperty("MBillAutoChargeEncounterTypes")]
    public virtual MGeneralLookup? EncounterType { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MBillAutoCharges")]
    public virtual MFacility? Facility { get; set; }

    [ForeignKey("PatientTypeId")]
    [InverseProperty("MBillAutoChargePatientTypes")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("ProviderId")]
    [InverseProperty("MBillAutoCharges")]
    public virtual MProvider? Provider { get; set; }

    [ForeignKey("ServiceId")]
    [InverseProperty("MBillAutoCharges")]
    public virtual MBillService Service { get; set; } = null!;
}
