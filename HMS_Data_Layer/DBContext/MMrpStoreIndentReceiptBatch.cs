using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreIndentReceiptBatch")]
public partial class MMrpStoreIndentReceiptBatch
{
    [Key]
    public long IndentReceiptBatchId { get; set; }

    public long IndentReceiptLineId { get; set; }

    public long ProductId { get; set; }

    [StringLength(50)]
    public string BatchId { get; set; } = null!;

    public int BatchIssueQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BatchReceiptRate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("IndentReceiptLineId")]
    [InverseProperty("MMrpStoreIndentReceiptBatches")]
    public virtual MMrpStoreIndentReceiptLine IndentReceiptLine { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStoreIndentReceiptBatches")]
    public virtual MProductDefinition Product { get; set; } = null!;
}
