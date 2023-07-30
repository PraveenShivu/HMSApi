using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_ClinicalAllergies")]
public partial class TClinicalAllergy
{
    [Key]
    public int AllergyId { get; set; }

    public int Typesid { get; set; }

    public int AllergyNameId { get; set; }

    public int AllergytypeId { get; set; }

    public int ReactionId { get; set; }

    public bool? Issignificant { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Confirmation { get; set; }

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

    [Unicode(false)]
    public string? Remearks { get; set; }

    public int? SiteofReaction { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Laterality { get; set; }

    public int? Onbehalfof { get; set; }

    public int Patientid { get; set; }

    public int CreatedBy { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Modifieddate { get; set; }

    public int? Encounterid { get; set; }

    public bool? Allergystatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dateofclosure { get; set; }

    public int? ExistingAllerginstatus { get; set; }

    public int? Relievingfactor { get; set; }
}
