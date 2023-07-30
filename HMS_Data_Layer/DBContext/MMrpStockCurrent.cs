using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StockCurrent")]
public partial class MMrpStockCurrent
{
    [Key]
    public long CurrentStockId { get; set; }

    public long StoreId { get; set; }

    public long ProductId { get; set; }

    [StringLength(20)]
    public string BatchNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    public int UomId { get; set; }

    public int? StockLocator { get; set; }

    public int? ReceiptQty { get; set; }

    public int? IssueQty { get; set; }

    public int? BalanceQty { get; set; }

    public int? AllocatedQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ReceiptRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ReceiptValue { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueValue { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BalanceValue { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? FacilityId { get; set; }

    public int? BatchTaxType1 { get; set; }

    public int? BatchTaxType2 { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BatchTaxAmount1 { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BatchTaxAmount2 { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStockCurrents")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("MMrpStockCurrents")]
    public virtual MMrpStore Store { get; set; } = null!;

    [ForeignKey("UomId")]
    [InverseProperty("MMrpStockCurrents")]
    public virtual MUom Uom { get; set; } = null!;
}
