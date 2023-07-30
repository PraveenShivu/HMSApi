using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryRecovery")]
public partial class TSummaryRecovery
{
    [Key]
    public int RecoveryId { get; set; }

    [Column("LevelofConsciousnessID")]
    public int LevelofConsciousnessId { get; set; }

    public int OxygenusedId { get; set; }

    public int? TransferredViaId { get; set; }

    [Column("TransferredtoID")]
    public int? TransferredtoId { get; set; }

    public int? DrainPatientId { get; set; }

    public int? PackingOnPlaceId { get; set; }

    public int? DressingDryId { get; set; }

    public int? SkinDryId { get; set; }

    [Column("IDinPlaceId")]
    public int? IdinPlaceId { get; set; }

    public int? ReceivingNurseId { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool ActiveFlag { get; set; }

    public int EncounterId { get; set; }

    public int PatientId { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedOn { get; set; }

    [Column("ProcedureID")]
    public int ProcedureId { get; set; }
}
