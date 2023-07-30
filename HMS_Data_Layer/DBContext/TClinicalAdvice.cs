using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Clinical_Advice")]
public partial class TClinicalAdvice
{
    [Key]
    [Column("ADID")]
    public int Adid { get; set; }

    [Column("Diagnosis_Datetime", TypeName = "datetime")]
    public DateTime? DiagnosisDatetime { get; set; }

    [Column("Diagnosis_Desc")]
    public string? DiagnosisDesc { get; set; }

    public string? Advice { get; set; }

    [Column("Follow_Up")]
    [StringLength(500)]
    public string? FollowUp { get; set; }

    public int? EncounterId { get; set; }

    public int? PatientId { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? ActiveFlag { get; set; }

    [Column("Diagnosis_time")]
    [StringLength(500)]
    public string? DiagnosisTime { get; set; }
}
