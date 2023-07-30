using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreOpeningStockBatch")]
public partial class MMrpStoreOpeningStockBatch
{
    [Key]
    public long OpeningStockBatchId { get; set; }

    public long OpeningStockLineId { get; set; }

    public long ProductId { get; set; }

    [StringLength(15)]
    public string? Barcode { get; set; }

    [StringLength(20)]
    public string? BatchNo { get; set; }

    public int BatchQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal BatchRate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Mrp { get; set; }

    public int? StockLocator { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? TaxType1 { get; set; }

    public int? TaxType2 { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? TaxAmount1 { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? TaxAmount2 { get; set; }

    [ForeignKey("OpeningStockLineId")]
    [InverseProperty("MMrpStoreOpeningStockBatches")]
    public virtual MMrpStoreOpeningStockLine OpeningStockLine { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStoreOpeningStockBatches")]
    public virtual MProductDefinition Product { get; set; } = null!;
}
