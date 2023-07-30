using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryProcedure")]
public partial class TSummaryProcedure
{
    [Key]
    [Column("ProcedureID")]
    public int ProcedureId { get; set; }

    public int? ProcedureSurgeryId { get; set; }

    public int? ProTerminolgyId { get; set; }

    public int? ProCodeId { get; set; }

    public int? AnesthesiaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProPerformDate { get; set; }

    public bool? ActiveFlag { get; set; }

    public int? EncounterId { get; set; }

    public int? PatientId { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }
}
