using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_ScheduleProviderAppointment")]
[Index("AppointmentReferenceNo", Name = "uc_AppointmentReferenceNo", IsUnique = true)]
public partial class TScheduleProviderAppointment
{
    [Key]
    public long AppointmentId { get; set; }

    [StringLength(50)]
    public string AppointmentReferenceNo { get; set; } = null!;

    public int FacilityId { get; set; }

    [Column("FacilityDepartmentID")]
    public int? FacilityDepartmentId { get; set; }

    public int ProviderId { get; set; }

    [Column(TypeName = "date")]
    public DateTime AppointmentDate { get; set; }

    public TimeSpan FromTime { get; set; }

    public TimeSpan ToTime { get; set; }

    [StringLength(10)]
    public string AppointmentStatus { get; set; } = null!;

    public long PatientId { get; set; }

    [StringLength(50)]
    public string? Reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BookedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancelledDate { get; set; }

    [StringLength(50)]
    public string? CancelledRemarks { get; set; }

    public int? AppointmentReasonId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransferedDate { get; set; }

    public int? TransferAppointment { get; set; }

    public int? CancelAppointment { get; set; }

    public int? AppointmentSlotNumber { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("AppointmentReasonId")]
    [InverseProperty("TScheduleProviderAppointmentAppointmentReasons")]
    public virtual MGeneralLookup? AppointmentReason { get; set; }

    [ForeignKey("CancelAppointment")]
    [InverseProperty("TScheduleProviderAppointmentCancelAppointmentNavigations")]
    public virtual MGeneralLookup? CancelAppointmentNavigation { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("TScheduleProviderAppointments")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("TScheduleProviderAppointments")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;

    [ForeignKey("ProviderId")]
    [InverseProperty("TScheduleProviderAppointments")]
    public virtual MProvider Provider { get; set; } = null!;

    [ForeignKey("TransferAppointment")]
    [InverseProperty("TScheduleProviderAppointmentTransferAppointmentNavigations")]
    public virtual MGeneralLookup? TransferAppointmentNavigation { get; set; }
}
