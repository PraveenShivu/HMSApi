using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Encounter")]
[Index("Encounter", Name = "uc_EncounterID", IsUnique = true)]
public partial class TEncounter
{
    [Key]
    public long EncounterId { get; set; }

    [StringLength(50)]
    public string Encounter { get; set; } = null!;

    public int FacilityId { get; set; }

    public long PatientId { get; set; }

    public int? AppointmentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EncounterDate { get; set; }

    public int PatientType { get; set; }

    public int? ReferredBy { get; set; }

    public int ProviderId { get; set; }

    public int FacilityDepartmentServiceLocationId { get; set; }

    public int? EncounterTypeId { get; set; }

    public int? EncounterReasonId { get; set; }

    public int? AttendingProviderId { get; set; }

    public int? SecondaryProviderId { get; set; }

    public int? EncounterEditReasonId { get; set; }

    public int? EncounterCancelReasonId { get; set; }

    public int? WardCategoryId { get; set; }

    public long? WardId { get; set; }

    public long? BedId { get; set; }

    public long? AdtId { get; set; }

    [StringLength(20)]
    public string? PatientStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedDischargeDate { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? FacilityDepartmentId { get; set; }

    public int? KinTitle { get; set; }

    [StringLength(250)]
    public string? KinName { get; set; }

    public string? KinAddress { get; set; }

    [StringLength(30)]
    public string? KinContactNo { get; set; }

    [Column("K_UHID")]
    [StringLength(150)]
    public string? KUhid { get; set; }

    [Column("K_Flag")]
    public int? KFlag { get; set; }

    [Column("K_Status")]
    [StringLength(50)]
    public string? KStatus { get; set; }

    [Column("K_Message")]
    [StringLength(150)]
    public string? KMessage { get; set; }

    [ForeignKey("BedId")]
    [InverseProperty("TEncounters")]
    public virtual MBed? Bed { get; set; }

    [ForeignKey("EncounterCancelReasonId")]
    [InverseProperty("TEncounterEncounterCancelReasons")]
    public virtual MGeneralLookup? EncounterCancelReason { get; set; }

    [ForeignKey("EncounterEditReasonId")]
    [InverseProperty("TEncounterEncounterEditReasons")]
    public virtual MGeneralLookup? EncounterEditReason { get; set; }

    [ForeignKey("EncounterReasonId")]
    [InverseProperty("TEncounterEncounterReasons")]
    public virtual MGeneralLookup? EncounterReason { get; set; }

    [ForeignKey("EncounterTypeId")]
    [InverseProperty("TEncounterEncounterTypes")]
    public virtual MGeneralLookup? EncounterType { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("TEncounters")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("Encounter")]
    public virtual ICollection<MMrpStoreIndent> MMrpStoreIndents { get; set; } = new List<MMrpStoreIndent>();

    [ForeignKey("PatientType")]
    [InverseProperty("TEncounterPatientTypeNavigations")]
    public virtual MGeneralLookup PatientTypeNavigation { get; set; } = null!;

    [ForeignKey("SecondaryProviderId")]
    [InverseProperty("TEncounters")]
    public virtual MProvider? SecondaryProvider { get; set; }

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountAssignedPlan> TPatientAccountAssignedPlans { get; set; } = new List<TPatientAccountAssignedPlan>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountBill> TPatientAccountBills { get; set; } = new List<TPatientAccountBill>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountCharges { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountLedger> TPatientAccountLedgers { get; set; } = new List<TPatientAccountLedger>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrders { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountPackageSubscription> TPatientAccountPackageSubscriptions { get; set; } = new List<TPatientAccountPackageSubscription>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountProcedureCharge> TPatientAccountProcedureCharges { get; set; } = new List<TPatientAccountProcedureCharge>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountReceiptAllocation> TPatientAccountReceiptAllocations { get; set; } = new List<TPatientAccountReceiptAllocation>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientAccountReceiptInstrument> TPatientAccountReceiptInstruments { get; set; } = new List<TPatientAccountReceiptInstrument>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TPatientDischarge> TPatientDischarges { get; set; } = new List<TPatientDischarge>();

    [InverseProperty("Encounter")]
    public virtual ICollection<TQueue> TQueues { get; set; } = new List<TQueue>();

    [ForeignKey("WardId")]
    [InverseProperty("TEncounters")]
    public virtual MWard? Ward { get; set; }

    [ForeignKey("WardCategoryId")]
    [InverseProperty("TEncounterWardCategories")]
    public virtual MGeneralLookup? WardCategory { get; set; }
}
