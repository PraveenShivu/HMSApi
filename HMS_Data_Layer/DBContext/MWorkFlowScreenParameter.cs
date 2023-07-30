using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_WorkFlowScreenParameter")]
public partial class MWorkFlowScreenParameter
{
    [Key]
    public long WorkFlowScreenParameterId { get; set; }

    public long WorkFlowScreenId { get; set; }

    public long ParameterId { get; set; }

    [StringLength(255)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool Activeflag { get; set; }

    [ForeignKey("ParameterId")]
    [InverseProperty("MWorkFlowScreenParameters")]
    public virtual MParameter Parameter { get; set; } = null!;

    [ForeignKey("WorkFlowScreenId")]
    [InverseProperty("MWorkFlowScreenParameters")]
    public virtual MWorkFlowScreen WorkFlowScreen { get; set; } = null!;
}
