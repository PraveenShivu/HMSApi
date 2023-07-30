using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ScheduleTemplateSession")]
public partial class MScheduleTemplateSession
{
    [Key]
    public long TemplateSessionId { get; set; }

    public long TemplateId { get; set; }

    public int FacilityId { get; set; }

    public int? SessionNo { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public int SlotDuration { get; set; }

    public int OverbookingSlots { get; set; }

    public int PatientsInslot { get; set; }

    public int PatientsMaxSlot { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? OverbookingEndSlots { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MScheduleTemplateSessions")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("TemplateId")]
    [InverseProperty("MScheduleTemplateSessions")]
    public virtual MScheduleTemplate Template { get; set; } = null!;
}
