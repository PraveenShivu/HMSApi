using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ClinicalFlowChart")]
public partial class MClinicalFlowChart
{
    [Key]
    public int ClinicalFlowId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ClinicalFlowName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ClinicalFlowDescription { get; set; } = null!;

    public int FacilityId { get; set; }

    public int? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    public bool Activeflag { get; set; }
}
