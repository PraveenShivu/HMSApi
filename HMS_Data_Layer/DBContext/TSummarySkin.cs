using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummarySkin")]
public partial class TSummarySkin
{
    [Key]
    public int SkinPrepId { get; set; }

    [Column("PreparationAgentID")]
    public int PreparationAgentId { get; set; }

    public int PreparationSiteId { get; set; }

    public int? PreparedbyId { get; set; }

    [Column("HairRemovalMethodID")]
    public int? HairRemovalMethodId { get; set; }

    public int? RemovalSiteId { get; set; }

    public int? RemovedbyId { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool ActiveFlag { get; set; }

    [Column("ProcedureID")]
    public int ProcedureId { get; set; }

    public int EncounterId { get; set; }

    public int PatientId { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }
}
