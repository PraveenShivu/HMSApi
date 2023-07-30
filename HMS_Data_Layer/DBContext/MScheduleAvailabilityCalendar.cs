using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ScheduleAvailabilityCalendar")]
public partial class MScheduleAvailabilityCalendar
{
    [Key]
    public long AvailabilityCalendarId { get; set; }

    public int ProviderId { get; set; }

    public int FacilityId { get; set; }

    [Column(TypeName = "date")]
    public DateTime CalendarDate { get; set; }

    public long TemplateId { get; set; }

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
    [InverseProperty("MScheduleAvailabilityCalendars")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("ProviderId")]
    [InverseProperty("MScheduleAvailabilityCalendars")]
    public virtual MProvider Provider { get; set; } = null!;

    [ForeignKey("TemplateId")]
    [InverseProperty("MScheduleAvailabilityCalendars")]
    public virtual MScheduleTemplate Template { get; set; } = null!;
}
