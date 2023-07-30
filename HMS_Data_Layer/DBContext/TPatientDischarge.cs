using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientDischarge")]
public partial class TPatientDischarge
{
    [Key]
    public long DischargeId { get; set; }

    public int DepartmentId { get; set; }

    public int ServiceLocationId { get; set; }

    public long? EncounterId { get; set; }

    public long? PatientId { get; set; }

    public long? BedId { get; set; }

    public int? DischargeAdvisedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdvisedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpectedDischargeDate { get; set; }

    public int? DispositionTypeId { get; set; }

    [StringLength(50)]
    public string? DischargeStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeceasedDatetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DischargeDatetime { get; set; }

    public int? AmendReason { get; set; }

    public int? CancelReason { get; set; }

    public int? CancelApprovedBy { get; set; }

    public int FacilityId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    [ForeignKey("BedId")]
    [InverseProperty("TPatientDischarges")]
    public virtual MBed? Bed { get; set; }

    [ForeignKey("CancelApprovedBy")]
    [InverseProperty("TPatientDischargeCancelApprovedByNavigations")]
    public virtual MProvider? CancelApprovedByNavigation { get; set; }

    [ForeignKey("CancelReason")]
    [InverseProperty("TPatientDischargeCancelReasonNavigations")]
    public virtual MGeneralLookup? CancelReasonNavigation { get; set; }

    [ForeignKey("DischargeAdvisedBy")]
    [InverseProperty("TPatientDischargeDischargeAdvisedByNavigations")]
    public virtual MProvider? DischargeAdvisedByNavigation { get; set; }

    [ForeignKey("DispositionTypeId")]
    [InverseProperty("TPatientDischargeDispositionTypes")]
    public virtual MGeneralLookup? DispositionType { get; set; }

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientDischarges")]
    public virtual TEncounter? Encounter { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientDischarges")]
    public virtual MPatientsRegistration? Patient { get; set; }
}
