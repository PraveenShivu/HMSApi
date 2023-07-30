using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ScheduleProviderAbsence")]
public partial class MScheduleProviderAbsence
{
    [Key]
    public long AbsenceId { get; set; }

    public int FacilityId { get; set; }

    public int ProviderId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [StringLength(100)]
    public string? AbsenceReason { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MScheduleProviderAbsences")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("ProviderId")]
    [InverseProperty("MScheduleProviderAbsences")]
    public virtual MProvider Provider { get; set; } = null!;
}
