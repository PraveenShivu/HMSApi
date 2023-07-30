using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PatientDischargeClearanceSetUp")]
public partial class MPatientDischargeClearanceSetUp
{
    [Key]
    public long DischargeClearanceSetUpId { get; set; }

    public int FacilityId { get; set; }

    public int PatientTypeId { get; set; }

    [StringLength(50)]
    public string ClearanceShortName { get; set; } = null!;

    [StringLength(50)]
    public string ClearanceLongName { get; set; } = null!;

    public int ClearanceTypeId { get; set; }

    public int? ClearanceSequence { get; set; }

    public int? ApplicableRoleId { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("ClearanceTypeId")]
    [InverseProperty("MPatientDischargeClearanceSetUpClearanceTypes")]
    public virtual MGeneralLookup ClearanceType { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("MPatientDischargeClearanceSetUps")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("PatientTypeId")]
    [InverseProperty("MPatientDischargeClearanceSetUpPatientTypes")]
    public virtual MGeneralLookup PatientType { get; set; } = null!;
}
