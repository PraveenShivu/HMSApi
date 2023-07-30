using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ScheduleFacilityHoliday")]
public partial class MScheduleFacilityHoliday
{
    [Key]
    public long HolidayId { get; set; }

    public int FacilityId { get; set; }

    [StringLength(80)]
    public string HolidayName { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime EndDate { get; set; }

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
    [InverseProperty("MScheduleFacilityHolidays")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("Holiday")]
    public virtual ICollection<MBillChargeExceptionLine> MBillChargeExceptionLines { get; set; } = new List<MBillChargeExceptionLine>();
}
