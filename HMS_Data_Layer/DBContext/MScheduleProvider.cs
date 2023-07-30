using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ScheduleProvider")]
public partial class MScheduleProvider
{
    [Key]
    public long ProviderScheduleId { get; set; }

    public int ProviderId { get; set; }

    public int FacilityId { get; set; }

    [StringLength(10)]
    public string ScheduleType { get; set; } = null!;

    public int? WeekdayId { get; set; }

    public int? DayNo { get; set; }

    public int? WeekDay { get; set; }

    public int? WeekDayFrequency { get; set; }

    public long? TemplateId { get; set; }

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
    [InverseProperty("MScheduleProviders")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("ProviderId")]
    [InverseProperty("MScheduleProviders")]
    public virtual MProvider Provider { get; set; } = null!;

    [ForeignKey("TemplateId")]
    [InverseProperty("MScheduleProviders")]
    public virtual MScheduleTemplate? Template { get; set; }

    [ForeignKey("WeekDayFrequency")]
    [InverseProperty("MScheduleProviderWeekDayFrequencyNavigations")]
    public virtual MGeneralLookup? WeekDayFrequencyNavigation { get; set; }

    [ForeignKey("WeekDay")]
    [InverseProperty("MScheduleProviderWeekDayNavigations")]
    public virtual MGeneralLookup? WeekDayNavigation { get; set; }

    [ForeignKey("WeekdayId")]
    [InverseProperty("MScheduleProviderWeekdays")]
    public virtual MGeneralLookup? Weekday { get; set; }
}
