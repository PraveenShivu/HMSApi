using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Parameter")]
public partial class MParameter
{
    [Key]
    public long ParameterId { get; set; }

    [StringLength(255)]
    public string? ParameterName { get; set; }

    [StringLength(255)]
    public string? ParameterDescription { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "date")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("Parameter")]
    public virtual ICollection<MWorkFlowScreenParameter> MWorkFlowScreenParameters { get; set; } = new List<MWorkFlowScreenParameter>();
}
