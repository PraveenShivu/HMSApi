using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_ClinicalRisks")]
public partial class TClinicalRisk
{
    [Key]
    public int RiskId { get; set; }

    [Column("RisktypeID")]
    public int RisktypeId { get; set; }

    [Column("RisknameID")]
    public int RisknameId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Closuretype { get; set; } = null!;

    public bool? Issignificant { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Riskto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Since { get; set; }

    public int? D1 { get; set; }

    public int? M1 { get; set; }

    public int? Y1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dateofonset { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Closedat { get; set; }

    public int? D2 { get; set; }

    public int? M2 { get; set; }

    public int? Y2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dateofclosure { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Severity { get; set; }

    public int? Sourceofinfo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Preventivemeasure { get; set; }

    [Unicode(false)]
    public string? Remearks { get; set; }

    public int Patientid { get; set; }

    public int CreatedBy { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Modifieddate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Conformation { get; set; }

    public int? Encounterid { get; set; }

    public bool? Riskstatus { get; set; }

    public int? ExistingRiskstatus { get; set; }
}
