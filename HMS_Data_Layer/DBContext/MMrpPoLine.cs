using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_PoLine")]
public partial class MMrpPoLine
{
    [Key]
    public long PoLineId { get; set; }

    public long PoHeaderId { get; set; }

    public long ProductId { get; set; }

    public int Uom { get; set; }

    public int PoQuantity { get; set; }

    public int? BonusQuantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal PoRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DiscountRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? LineAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? MrpExpected { get; set; }

    public int? PoTotalQty { get; set; }

    public int? PoReceivedQty { get; set; }

    public int? PoReceivedBonusQty { get; set; }

    public int? PoRejectedQty { get; set; }

    public int? PoBalanceQty { get; set; }

    public int? PoBalanceBonusQty { get; set; }

    [StringLength(20)]
    public string? PoStatus { get; set; }

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

    [InverseProperty("PoLine")]
    public virtual ICollection<MMrpPoDelivery> MMrpPoDeliveries { get; set; } = new List<MMrpPoDelivery>();

    [ForeignKey("PoHeaderId")]
    [InverseProperty("MMrpPoLines")]
    public virtual MMrpPoHeader PoHeader { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpPoLines")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("Uom")]
    [InverseProperty("MMrpPoLines")]
    public virtual MUom UomNavigation { get; set; } = null!;
}
