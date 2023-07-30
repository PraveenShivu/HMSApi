using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_WorkFlowScreen")]
public partial class MWorkFlowScreen
{
    [Key]
    public long WorkFlowScreenId { get; set; }

    public long WorkFlowId { get; set; }

    public long ScreenId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("WorkFlowScreen")]
    public virtual ICollection<MWorkFlowScreenParameter> MWorkFlowScreenParameters { get; set; } = new List<MWorkFlowScreenParameter>();

    [ForeignKey("ScreenId")]
    [InverseProperty("MWorkFlowScreens")]
    public virtual MScreen Screen { get; set; } = null!;

    [ForeignKey("WorkFlowId")]
    [InverseProperty("MWorkFlowScreens")]
    public virtual MWorkFlow WorkFlow { get; set; } = null!;
}
