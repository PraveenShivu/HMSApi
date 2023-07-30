using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_FacilityDepartmentPatientType")]
public partial class MFacilityDepartmentPatientType
{
    [Key]
    public int FacilityDepartmentPatientTypeId { get; set; }

    public int FacilityDepartmentId { get; set; }

    public int PatientTypeId { get; set; }

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
    [InverseProperty("MFacilityDepartmentPatientTypes")]
    public virtual MFacilityDepartment FacilityDepartment { get; set; } = null!;

    [ForeignKey("PatientTypeId")]
    [InverseProperty("MFacilityDepartmentPatientTypes")]
    public virtual MGeneralLookup PatientType { get; set; } = null!;
}
