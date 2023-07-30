using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummarySpeciman")]
public partial class TSummarySpeciman
{
    [Key]
    public int SpeId { get; set; }

    [Column("SpecimenID")]
    public int SpecimenId { get; set; }

    public int InvestigationId { get; set; }

    public int SiteId { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool ActiveFlag { get; set; }

    [Column("ProcedureID")]
    public int ProcedureId { get; set; }

    public int EncounterId { get; set; }

    public int PatientId { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedOn { get; set; }
}
