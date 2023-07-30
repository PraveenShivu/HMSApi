using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_GrnBatch")]
public partial class MMrpGrnBatch
{
    [Key]
    public long GrnBatchId { get; set; }

    public long GrnLineId { get; set; }

    [StringLength(15)]
    public string? BarCode { get; set; }

    [StringLength(20)]
    public string? BatchNo { get; set; }

    public int BatchQty { get; set; }

    public int BatchBonusQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MfgDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("BatchMRP", TypeName = "decimal(18, 4)")]
    public decimal? BatchMrp { get; set; }

    public int? BatchStockLocator { get; set; }

    public int? QuantityTobeIssued { get; set; }

    public int? PrimaryUomQuantity { get; set; }

    public int? AllocatedQuantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DiscountRate { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? BatchTaxType1 { get; set; }

    public int? BatchTaxType2 { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BatchTaxAmount1 { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BatchTaxAmount2 { get; set; }

    [ForeignKey("GrnLineId")]
    [InverseProperty("MMrpGrnBatches")]
    public virtual MMrpGrnLine GrnLine { get; set; } = null!;
}
