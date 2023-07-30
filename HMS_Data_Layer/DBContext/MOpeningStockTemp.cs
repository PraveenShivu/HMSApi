using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_OpeningStockTemp")]
public partial class MOpeningStockTemp
{
    [Key]
    [Column(TypeName = "decimal(18, 0)")]
    public decimal SlNo { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal ProductId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ItemName { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal StoreId { get; set; }

    [Column("QTY", TypeName = "decimal(18, 0)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal UomId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("EXPDate", TypeName = "datetime")]
    public DateTime Expdate { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal ReceivedQty { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? BonusQuantity { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal PoRate { get; set; }

    [Column("GRNStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Grnstatus { get; set; }

    [Column("MRP", TypeName = "decimal(18, 0)")]
    public decimal Mrp { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TaxAmount1 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TaxAmount2 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TaxType1 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TaxType2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Status { get; set; } = null!;
}
