using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ClinicalSetup")]
public partial class MClinicalSetup
{
    [Key]
    public int ParameterId { get; set; }

    [StringLength(50)]
    public string ParameterName { get; set; } = null!;

    [StringLength(50)]
    public string? ScannedFilePath { get; set; }

    public int FacilityId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? FromList { get; set; }
}
