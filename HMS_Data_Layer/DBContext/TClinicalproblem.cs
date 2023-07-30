using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Clinicalproblems")]
public partial class TClinicalproblem
{
    [Key]
    public int ProdlieId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Scheme { get; set; }

    public int Schemetype { get; set; }

    public int Problems { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Confirmation { get; set; }

    public bool? Issignificant { get; set; }

    public bool? Isprimary { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? Severity { get; set; }

    public int? Sourceofinfo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Laterality { get; set; }

    public int? Site { get; set; }

    public int? Stage { get; set; }

    public int Patientid { get; set; }

    public int CreatedBy { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Modifieddate { get; set; }

    public int? Encounterid { get; set; }

    public bool? Problemstatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dateofclosure { get; set; }

    [Column("PDType")]
    public int? Pdtype { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Course { get; set; } = null!;

    [Unicode(false)]
    public string? Remearks { get; set; }

    public int? Relievingfactor { get; set; }

    public int? ExistingProblemstatus { get; set; }
}
