using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_TestResultEntry")]
public partial class TTestResultEntry
{
    [Key]
    public long ResId { get; set; }

    public long TestId { get; set; }

    public long? SubTestId { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    public string? ObservedValues { get; set; }

    [StringLength(100)]
    public string? Units { get; set; }

    [Column("MethodsID")]
    public long? MethodsId { get; set; }

    [StringLength(200)]
    public string? TestRefDescription { get; set; }

    [StringLength(100)]
    public string? TestRefRangeValue { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool IsProfileTest { get; set; }

    public bool IsTemplateTest { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(200)]
    public string? LabNumber { get; set; }

    public bool IsSubTest { get; set; }

    public long MainTestId { get; set; }

    public bool? IsResultNormal { get; set; }

    public long ChargeId { get; set; }

    public long LabStatusId { get; set; }
}
