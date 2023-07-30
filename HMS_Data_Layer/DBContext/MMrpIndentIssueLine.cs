using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_IndentIssueLine")]
public partial class MMrpIndentIssueLine
{
    [Key]
    public long IndentIssueLineId { get; set; }

    public long IndentIssueId { get; set; }

    public long ProductId { get; set; }

    public int UomId { get; set; }

    public int IssueQuantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueValue { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("IndentIssueId")]
    [InverseProperty("MMrpIndentIssueLines")]
    public virtual MMrpIndentIssue IndentIssue { get; set; } = null!;

    [InverseProperty("IndentIssueLine")]
    public virtual ICollection<MMrpIndentIssuesBatch> MMrpIndentIssuesBatches { get; set; } = new List<MMrpIndentIssuesBatch>();

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpIndentIssueLines")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("UomId")]
    [InverseProperty("MMrpIndentIssueLines")]
    public virtual MUom Uom { get; set; } = null!;
}
