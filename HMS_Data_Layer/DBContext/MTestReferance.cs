using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_TestReferances")]
public partial class MTestReferance
{
    [Key]
    public long TestRefId { get; set; }

    public long TestId { get; set; }

    public long? TestMethodId { get; set; }

    public long? Gender { get; set; }

    [Column("PeriodsID")]
    public long? PeriodsId { get; set; }

    public int? FromAge { get; set; }

    public int? ToAge { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Low { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? High { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(50)]
    public string? OperatorType { get; set; }
}
