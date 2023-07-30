using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SampleCollectionHeader")]
public partial class TSampleCollectionHeader
{
    [Key]
    public long SmpColHeaderId { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    public int? TestId { get; set; }

    public long? SampleTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SmpColDateAndTime { get; set; }

    public bool? IsSampleCollected { get; set; }

    [StringLength(200)]
    public string? LabNumber { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [Required]
    public bool? IsResultEntryDone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResultEntryDateTime { get; set; }

    [Required]
    public bool? IsVerificationDone { get; set; }

    public int? VerifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerificationDateTime { get; set; }

    public int? UnverifyBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UnverifiedDateTime { get; set; }

    public long ChargeId { get; set; }

    public long LabStatusId { get; set; }
}
