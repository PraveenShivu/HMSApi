using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ScheduleTemplate")]
public partial class MScheduleTemplate
{
    [Key]
    public long TemplateId { get; set; }

    [StringLength(80)]
    public string TemplateName { get; set; } = null!;

    public int FacilityId { get; set; }

    [StringLength(1)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MScheduleTemplates")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("Template")]
    public virtual ICollection<MScheduleAvailabilityCalendar> MScheduleAvailabilityCalendars { get; set; } = new List<MScheduleAvailabilityCalendar>();

    [InverseProperty("Template")]
    public virtual ICollection<MScheduleProvider> MScheduleProviders { get; set; } = new List<MScheduleProvider>();

    [InverseProperty("Template")]
    public virtual ICollection<MScheduleTemplateSession> MScheduleTemplateSessions { get; set; } = new List<MScheduleTemplateSession>();
}
