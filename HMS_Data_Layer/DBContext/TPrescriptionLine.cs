using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PrescriptionLine")]
public partial class TPrescriptionLine
{
    [Key]
    public int PrescriptionLineId { get; set; }

    public int? DrugId { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? DrugName { get; set; }

    public int? FrequencyId { get; set; }

    public int? UomId { get; set; }

    public int? Dose { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Route { get; set; }

    public int? Interval { get; set; }

    [Unicode(false)]
    public string? Instruction { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    public bool? PrescriptionStatus { get; set; }

    public int? PriscptionHedderId { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Modifieddate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

    public int? FoodRelation { get; set; }

    public long? TotalQty { get; set; }

    public long? Stock { get; set; }

    public long? IndentId { get; set; }
}
