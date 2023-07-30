using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryPreop")]
public partial class TSummaryPreop
{
    [Key]
    public int PreopId { get; set; }

    [Column("PatientRFH", TypeName = "datetime")]
    public DateTime PatientRfh { get; set; }

    [Column("PreOIT", TypeName = "datetime")]
    public DateTime PreOit { get; set; }

    [Column("PatientIH")]
    [StringLength(20)]
    public string? PatientIh { get; set; }

    [Column("PatientRFP", TypeName = "datetime")]
    public DateTime PatientRfp { get; set; }

    [Column("PreOOT", TypeName = "datetime")]
    public DateTime PreOot { get; set; }

    public int RoleId { get; set; }

    public int AttendeeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Timein { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Timeout { get; set; }

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

    [Column("PreOITTime")]
    [StringLength(20)]
    public string? PreOittime { get; set; }

    [Column("PreOOTTime")]
    [StringLength(20)]
    public string? PreOottime { get; set; }

    [Column("PatientRFPTime")]
    [StringLength(20)]
    public string? PatientRfptime { get; set; }

    [Column("PatientRFHTime")]
    [StringLength(20)]
    public string? PatientRfhtime { get; set; }

    [Column("PreCATimeIn")]
    [StringLength(20)]
    public string? PreCatimeIn { get; set; }

    [Column("PreCATimeOut")]
    [StringLength(20)]
    public string? PreCatimeOut { get; set; }
}
