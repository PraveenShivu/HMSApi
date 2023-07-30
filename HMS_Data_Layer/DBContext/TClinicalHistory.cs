using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Clinical_History")]
public partial class TClinicalHistory
{
    [Key]
    [Column("CHID")]
    public int Chid { get; set; }

    [Column("Family_history")]
    public string? FamilyHistory { get; set; }

    [Column("Occupation_History")]
    public string? OccupationHistory { get; set; }

    [Column("GYN_history")]
    public string? GynHistory { get; set; }

    [Column("Pre_Hospitalisation")]
    public string? PreHospitalisation { get; set; }

    public int? EncounterId { get; set; }

    public int? PatientId { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? ActiveFlag { get; set; }
}
