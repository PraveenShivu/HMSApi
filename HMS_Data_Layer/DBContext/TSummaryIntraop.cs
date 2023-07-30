using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryIntraop")]
public partial class TSummaryIntraop
{
    [Key]
    public int IntraopId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CaseTimeIn { get; set; }

    [Column("CaseTimeInTS")]
    [StringLength(20)]
    public string? CaseTimeInTs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CaseTimeOut { get; set; }

    [Column("CaseTimeOutTS")]
    [StringLength(20)]
    public string? CaseTimeOutTs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ProcedureStartTime { get; set; }

    [Column("ProcedureStartTimeTS")]
    [StringLength(20)]
    public string? ProcedureStartTimeTs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ProcedureEndTime { get; set; }

    [Column("ProcedureEndTimeTS")]
    [StringLength(20)]
    public string? ProcedureEndTimeTs { get; set; }

    public int? ProcedureLocationId { get; set; }

    [Unicode(false)]
    public string? DelayReasonId { get; set; }

    public int ProceedureId { get; set; }

    public int? ModifierId { get; set; }

    public int ClinicianId { get; set; }

    public int? SpecialtyId { get; set; }

    public int? IndicationId { get; set; }

    public int? WoundClassId { get; set; }

    public int AnesthesiaId { get; set; }

    [Column("ASAClassId")]
    public int? AsaclassId { get; set; }

    [Unicode(false)]
    public string? DelayRemarks { get; set; }

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

    [StringLength(20)]
    public string? ProcedureDuration { get; set; }

    public bool PrimaryProcedure { get; set; }
}
