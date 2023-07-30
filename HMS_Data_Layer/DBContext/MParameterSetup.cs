using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ParameterSetup")]
public partial class MParameterSetup
{
    [Key]
    public int ParameterId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ParameterName { get; set; } = null!;

    public int FacilityId { get; set; }

    public int ParameterValueId { get; set; }

    [StringLength(50)]
    public string ParameterValueName { get; set; } = null!;

    public int SubMenuChildId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    [Column("ParameterReferID")]
    public int? ParameterReferId { get; set; }

    public bool? ParameterActiveness { get; set; }

    public long? ParameterValue { get; set; }
}
