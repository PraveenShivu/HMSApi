using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryPosition")]
public partial class TSummaryPosition
{
    [Key]
    public int PositionId { get; set; }

    [Column("BodyPositionID")]
    public int BodyPositionId { get; set; }

    public int? RightArmPositionId { get; set; }

    public int? RightLegPositionId { get; set; }

    public int? FeetUncrossedId { get; set; }

    [Column("LeftArmPositionID")]
    public int? LeftArmPositionId { get; set; }

    public int? LeftLegPositionId { get; set; }

    public int? SafetyDeviceUsedId { get; set; }

    public int? SiteUsedId { get; set; }

    public int? PressurePointsId { get; set; }

    public int? SafetyBeltId { get; set; }

    public int? SafetyBeltRemovedId { get; set; }

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
