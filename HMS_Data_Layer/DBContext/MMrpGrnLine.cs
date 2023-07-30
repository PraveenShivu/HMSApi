using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_GrnLine")]
public partial class MMrpGrnLine
{
    [Key]
    public long GrnLineId { get; set; }

    public long GrnHeaderId { get; set; }

    public long? PoLineId { get; set; }

    public long ProductId { get; set; }

    public int UomId { get; set; }

    public int? PendingQty { get; set; }

    public int ReceivedQty { get; set; }

    public int BonusQty { get; set; }

    public int QuantityTobeIssued { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? PoRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DiscountRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? LineAmount { get; set; }

    public int? RejectedQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalAmount { get; set; }

    public bool? Replaceable { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("GrnLine")]
    public virtual ICollection<MMrpGrnBatch> MMrpGrnBatches { get; set; } = new List<MMrpGrnBatch>();

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpGrnLines")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("UomId")]
    [InverseProperty("MMrpGrnLines")]
    public virtual MUom Uom { get; set; } = null!;
}
