using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Clinical_MedicalHistory")]
public partial class TClinicalMedicalHistory
{
    [Key]
    [Column("CMHID")]
    public int Cmhid { get; set; }

    [Column("Past_Medical_History")]
    public string? PastMedicalHistory { get; set; }

    [Column("Past_Surgical_History")]
    public string? PastSurgicalHistory { get; set; }

    [Column("Drug_History")]
    public string? DrugHistory { get; set; }

    public string? Allergy { get; set; }

    [Column("Social_History")]
    public string? SocialHistory { get; set; }

    public int? EncounterId { get; set; }

    public int? PatientId { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? ActiveFlag { get; set; }
}
