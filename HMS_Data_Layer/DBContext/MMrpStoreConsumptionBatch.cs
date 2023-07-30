using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreConsumptionBatch")]
public partial class MMrpStoreConsumptionBatch
{
    [Key]
    public long StoreConsumptionBatchId { get; set; }

    public long StoreConsumptionLineId { get; set; }

    public long StockId { get; set; }

    [StringLength(50)]
    public string BatchId { get; set; } = null!;

    public int BatchIssueQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal BatchIssueRate { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("StoreConsumptionLineId")]
    [InverseProperty("MMrpStoreConsumptionBatches")]
    public virtual MMrpStoreConsumptionLine StoreConsumptionLine { get; set; } = null!;
}
