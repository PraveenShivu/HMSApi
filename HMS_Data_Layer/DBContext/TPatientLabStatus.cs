using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientLabStatus")]
public partial class TPatientLabStatus
{
    [Key]
    [Column("PatientLabStatusID")]
    public long PatientLabStatusId { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    [StringLength(100)]
    public string? PatientAge { get; set; }

    [StringLength(100)]
    public string LabNumber { get; set; } = null!;

    public bool IsbillCancelled { get; set; }

    public bool IsAllSampleCollected { get; set; }

    public bool IsSmpPartiallyCollected { get; set; }

    public bool IsAllResEntryDone { get; set; }

    public bool IsResEntryPartiallyDone { get; set; }

    public bool IsAllVerificationDone { get; set; }

    public bool IsVerificationPartiallyDone { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }
}
