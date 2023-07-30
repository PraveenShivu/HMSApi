using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_FacilityWorkFlow")]
public partial class MFacilityWorkFlow
{
    [Key]
    public long FacilityWorkFlowId { get; set; }

    public int FacilityId { get; set; }

    public long WorkFlowId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "date")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MFacilityWorkFlows")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("WorkFlowId")]
    [InverseProperty("MFacilityWorkFlows")]
    public virtual MWorkFlow WorkFlow { get; set; } = null!;
}
