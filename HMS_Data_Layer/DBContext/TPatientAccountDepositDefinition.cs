using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountDepositDefinition")]
public partial class TPatientAccountDepositDefinition
{
    [Key]
    public long DepositId { get; set; }

    public int FacilityId { get; set; }

    public int PatientTypeId { get; set; }

    public int AccommodationType { get; set; }

    public int DepositAmount { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? ActiveFlag { get; set; }

    [ForeignKey("AccommodationType")]
    [InverseProperty("TPatientAccountDepositDefinitionAccommodationTypeNavigations")]
    public virtual MGeneralLookup AccommodationTypeNavigation { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("TPatientAccountDepositDefinitions")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("PatientTypeId")]
    [InverseProperty("TPatientAccountDepositDefinitionPatientTypes")]
    public virtual MGeneralLookup PatientType { get; set; } = null!;
}
