using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Departments")]
[Index("DepartmentName", "DepartmentCode", "CreatedDateTime", "ActiveFlag", Name = "uc_Department", IsUnique = true)]
public partial class MDepartment
{
    [Key]
    public int DepartmentId { get; set; }

    [StringLength(50)]
    public string DepartmentName { get; set; } = null!;

    [StringLength(10)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<MFacilityDepartment> MFacilityDepartments { get; set; } = new List<MFacilityDepartment>();
}
