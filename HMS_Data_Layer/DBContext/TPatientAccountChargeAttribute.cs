using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountChargeAttribute")]
public partial class TPatientAccountChargeAttribute
{
    [Key]
    public long ChargeAttributeId { get; set; }

    public int FacilityId { get; set; }

    public int WardType { get; set; }

    public int LevelOfService { get; set; }

    public int MinimumChargeHour { get; set; }

    public int DischargeGraceHour { get; set; }

    public int DischargeBedBlockHour { get; set; }

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
    [InverseProperty("TPatientAccountChargeAttributes")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("WardType")]
    [InverseProperty("TPatientAccountChargeAttributes")]
    public virtual MGeneralLookup WardTypeNavigation { get; set; } = null!;
}
