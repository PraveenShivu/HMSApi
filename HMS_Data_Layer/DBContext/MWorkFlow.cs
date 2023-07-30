using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_WorkFlow")]
public partial class MWorkFlow
{
    [Key]
    public long WorkFlowId { get; set; }

    [StringLength(255)]
    public string? WorkFlowName { get; set; }

    [StringLength(255)]
    public string? WorkFlowDescription { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("WorkFlow")]
    public virtual ICollection<MFacilityWorkFlow> MFacilityWorkFlows { get; set; } = new List<MFacilityWorkFlow>();

    [InverseProperty("WorkFlow")]
    public virtual ICollection<MWorkFlowScreen> MWorkFlowScreens { get; set; } = new List<MWorkFlowScreen>();
}
