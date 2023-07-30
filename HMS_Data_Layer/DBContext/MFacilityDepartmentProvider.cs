using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_FacilityDepartmentProvider")]
public partial class MFacilityDepartmentProvider
{
    [Key]
    public int FacilityDepartmentProviderId { get; set; }

    public int FacilityDepartmentId { get; set; }

    public int ProviderId { get; set; }

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
    [InverseProperty("MFacilityDepartmentProviders")]
    public virtual MFacilityDepartment FacilityDepartment { get; set; } = null!;

    [ForeignKey("ProviderId")]
    [InverseProperty("MFacilityDepartmentProviders")]
    public virtual MProvider Provider { get; set; } = null!;
}
