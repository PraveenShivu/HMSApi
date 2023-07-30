using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_FacilityDepartmentServiceLocation")]
public partial class MFacilityDepartmentServiceLocation
{
    [Key]
    public int FacilityDepartmentServiceLocationId { get; set; }

    public int FacilityDepartmentId { get; set; }

    public int ServiceLocationId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("FacilityDepartmentId")]
    [InverseProperty("MFacilityDepartmentServiceLocations")]
    public virtual MFacilityDepartment FacilityDepartment { get; set; } = null!;

    [InverseProperty("FacilityDepartmentServiceLocation")]
    public virtual ICollection<MFacilityDepartmentServiceLocationEquipment> MFacilityDepartmentServiceLocationEquipments { get; set; } = new List<MFacilityDepartmentServiceLocationEquipment>();

    [ForeignKey("ServiceLocationId")]
    [InverseProperty("MFacilityDepartmentServiceLocations")]
    public virtual MServiceLocation ServiceLocation { get; set; } = null!;
}
