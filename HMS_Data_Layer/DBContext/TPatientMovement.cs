using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientMovement")]
public partial class TPatientMovement
{
    [Key]
    public long MovementId { get; set; }

    public long PatientId { get; set; }

    public long? BedId { get; set; }

    public int DepartmentId { get; set; }

    public int ServiceLocationId { get; set; }

    public int? MovementReason { get; set; }

    public TimeSpan? ExpectedReturnTime { get; set; }

    public TimeSpan? ActualReturnTime { get; set; }

    public int? DelayReason { get; set; }

    [Column("Facility_id")]
    public int FacilityId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("BedId")]
    [InverseProperty("TPatientMovements")]
    public virtual MBed? Bed { get; set; }

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientMovements")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;
}
