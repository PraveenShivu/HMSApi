using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StockLedger")]
public partial class MMrpStockLedger
{
    [Key]
    public long StockLedgerId { get; set; }

    public long StoreId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransDate { get; set; }

    [StringLength(15)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(100)]
    public string Narration { get; set; } = null!;

    public long ProductId { get; set; }

    [StringLength(20)]
    public string BatchNo { get; set; } = null!;

    public int? ReceiptQty { get; set; }

    public int? IssueQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ReceiptRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ReceiptValue { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueValue { get; set; }

    public int? BalanceQty { get; set; }

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

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStockLedgers")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("MMrpStockLedgers")]
    public virtual MMrpStore Store { get; set; } = null!;
}
