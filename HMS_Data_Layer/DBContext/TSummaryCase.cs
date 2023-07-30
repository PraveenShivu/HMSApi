using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryCase")]
public partial class TSummaryCase
{
    [Key]
    public int CaseAttId { get; set; }

    [Column("TimeinCA", TypeName = "datetime")]
    public DateTime? TimeinCa { get; set; }

    [Column("TimeinCATime")]
    [StringLength(20)]
    public string? TimeinCatime { get; set; }

    [Column("TimeoutCA", TypeName = "datetime")]
    public DateTime? TimeoutCa { get; set; }

    [Column("TimeoutCATime")]
    [StringLength(20)]
    public string? TimeoutCatime { get; set; }

    [Column("RoleCAId")]
    public int RoleCaid { get; set; }

    [Column("AttendeeCAId")]
    public int AttendeeCaid { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool ActiveFlag { get; set; }

    [Column("ProcedureID")]
    public int ProcedureId { get; set; }

    public int EncounterId { get; set; }

    public int PatientId { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedOn { get; set; }
}
