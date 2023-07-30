using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillChargeExceptionHeader")]
public partial class MBillChargeExceptionHeader
{
    [Key]
    public int ExceptionHeaderId { get; set; }

    public int? FacilityId { get; set; }

    [StringLength(20)]
    public string ShortName { get; set; } = null!;

    [StringLength(100)]
    public string LongName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    public int? Priority { get; set; }

    [StringLength(1)]
    public string? Status { get; set; }

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
    [InverseProperty("MBillChargeExceptionHeaders")]
    public virtual MFacility? Facility { get; set; }

    [InverseProperty("ExceptionHeader")]
    public virtual ICollection<MBillChargeExceptionLine> MBillChargeExceptionLines { get; set; } = new List<MBillChargeExceptionLine>();
}
