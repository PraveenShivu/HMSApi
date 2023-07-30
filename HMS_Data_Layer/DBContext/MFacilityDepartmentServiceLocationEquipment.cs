using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_FacilityDepartmentServiceLocationEquipment")]
public partial class MFacilityDepartmentServiceLocationEquipment
{
    [Key]
    public int DepartmentServiceLocationEquipmentId { get; set; }

    public int FacilityDepartmentServiceLocationId { get; set; }

    public int EquipmentId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("EquipmentId")]
    [InverseProperty("MFacilityDepartmentServiceLocationEquipments")]
    public virtual MGeneralLookup Equipment { get; set; } = null!;

    [ForeignKey("FacilityDepartmentServiceLocationId")]
    [InverseProperty("MFacilityDepartmentServiceLocationEquipments")]
    public virtual MFacilityDepartmentServiceLocation FacilityDepartmentServiceLocation { get; set; } = null!;
}
