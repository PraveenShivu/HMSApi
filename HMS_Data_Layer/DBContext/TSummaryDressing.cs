using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryDressing")]
public partial class TSummaryDressing
{
    [Key]
    public int DressingId { get; set; }

    [Column("DressingTypeID")]
    public int DressingTypeId { get; set; }

    public int DressingSiteId { get; set; }

    public int DoneById { get; set; }

    public int EncounterId { get; set; }

    public int PatientId { get; set; }

    [Column("ProcedureID")]
    public int ProcedureId { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedOn { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool? ActiveFlag { get; set; }
}
