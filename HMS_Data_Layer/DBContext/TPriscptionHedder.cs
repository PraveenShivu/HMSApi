using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PriscptionHedder")]
public partial class TPriscptionHedder
{
    [Key]
    public int PriscptionHedderId { get; set; }

    public int FacilityId { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Modifieddate { get; set; }

    public bool? Activestatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrescriptionId { get; set; }

    public long? IndentId { get; set; }

    [StringLength(50)]
    public string? IndentNumber { get; set; }
}
