using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientDischargeClearance")]
public partial class TPatientDischargeClearance
{
    [Key]
    public long DischargeClearanceId { get; set; }

    public long? DischargeClearanceSetUpId { get; set; }

    public int? FacilityId { get; set; }

    public long? PatientId { get; set; }

    public long? EncounterId { get; set; }

    public int? ClearanceTypeId { get; set; }

    public int? ClearanceSequence { get; set; }

    public int? ClearanceStatus { get; set; }

    public long? ProviderId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClearanceDate { get; set; }

    [StringLength(100)]
    public string? Remarks { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? ActiveFlag { get; set; }

    [ForeignKey("ClearanceTypeId")]
    [InverseProperty("TPatientDischargeClearances")]
    public virtual MGeneralLookup? ClearanceType { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("TPatientDischargeClearances")]
    public virtual MFacility? Facility { get; set; }
}
