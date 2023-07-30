using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ServiceLocations")]
public partial class MServiceLocation
{
    [Key]
    public int ServiceLocationId { get; set; }

    public int ServiceLocationTypeId { get; set; }

    [StringLength(50)]
    public string ServiceLocationName { get; set; } = null!;

    [StringLength(10)]
    public string ServiceLocationCode { get; set; } = null!;

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("ServiceLocation")]
    public virtual ICollection<MBillChargeExceptionLine> MBillChargeExceptionLines { get; set; } = new List<MBillChargeExceptionLine>();

    [InverseProperty("ServiceLocation")]
    public virtual ICollection<MFacilityDepartmentServiceLocation> MFacilityDepartmentServiceLocations { get; set; } = new List<MFacilityDepartmentServiceLocation>();

    [ForeignKey("ServiceLocationTypeId")]
    [InverseProperty("MServiceLocations")]
    public virtual MGeneralLookup ServiceLocationType { get; set; } = null!;
}
