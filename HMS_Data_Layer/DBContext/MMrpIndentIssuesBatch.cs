using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_IndentIssuesBatch")]
public partial class MMrpIndentIssuesBatch
{
    [Key]
    public long IssueBatchId { get; set; }

    public long? IndentIssueLineId { get; set; }

    public long? StockId { get; set; }

    [StringLength(50)]
    public string? BatchId { get; set; }

    public int? BatchIssueQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BatchIssueRate { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [Column("exp_date", TypeName = "datetime")]
    public DateTime? ExpDate { get; set; }

    [ForeignKey("IndentIssueLineId")]
    [InverseProperty("MMrpIndentIssuesBatches")]
    public virtual MMrpIndentIssueLine? IndentIssueLine { get; set; }
}
