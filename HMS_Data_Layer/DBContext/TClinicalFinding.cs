using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Clinical_Findings")]
public partial class TClinicalFinding
{
    [Key]
    [Column("CFID")]
    public int Cfid { get; set; }

    [Column("Presenting_Complains")]
    public string? PresentingComplains { get; set; }

    [Column("Clinical_Findings")]
    public string? ClinicalFindings { get; set; }

    public int? EncounterId { get; set; }

    public int? PatientId { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? ActiveFlag { get; set; }
}
