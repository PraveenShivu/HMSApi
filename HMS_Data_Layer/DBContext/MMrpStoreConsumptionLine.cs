using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreConsumptionLine")]
public partial class MMrpStoreConsumptionLine
{
    [Key]
    public long StoreConsumptionLineId { get; set; }

    public long StoreConsumptionId { get; set; }

    public long ProductId { get; set; }

    public int UomId { get; set; }

    public int IssueQuantity { get; set; }

    [StringLength(200)]
    public string? Reason { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? IssueValue { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("StoreConsumptionLine")]
    public virtual ICollection<MMrpStoreConsumptionBatch> MMrpStoreConsumptionBatches { get; set; } = new List<MMrpStoreConsumptionBatch>();

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStoreConsumptionLines")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("StoreConsumptionId")]
    [InverseProperty("MMrpStoreConsumptionLines")]
    public virtual MMrpStoreConsumption StoreConsumption { get; set; } = null!;

    [ForeignKey("UomId")]
    [InverseProperty("MMrpStoreConsumptionLines")]
    public virtual MUom Uom { get; set; } = null!;
}
