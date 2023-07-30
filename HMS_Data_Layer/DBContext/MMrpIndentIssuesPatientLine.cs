using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_IndentIssuesPatientLine")]
public partial class MMrpIndentIssuesPatientLine
{
    [Key]
    public long PatientIssueLineId { get; set; }

    public long PatientIssueId { get; set; }

    public long ProductId { get; set; }

    public int? UomId { get; set; }

    public int IssueQuantity { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal IssueRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueValue { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Servicetype { get; set; }

    [Column("ChargeID")]
    public long? ChargeId { get; set; }

    [InverseProperty("PatientIssue")]
    public virtual ICollection<MMrpIndentIssuesPatientBatch> MMrpIndentIssuesPatientBatches { get; set; } = new List<MMrpIndentIssuesPatientBatch>();

    [ForeignKey("PatientIssueId")]
    [InverseProperty("MMrpIndentIssuesPatientLines")]
    public virtual MMrpIndentIssuesPatient PatientIssue { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpIndentIssuesPatientLines")]
    public virtual MProductDefinition Product { get; set; } = null!;
}
