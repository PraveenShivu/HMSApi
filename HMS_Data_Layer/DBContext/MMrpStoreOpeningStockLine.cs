using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreOpeningStockLine")]
public partial class MMrpStoreOpeningStockLine
{
    [Key]
    public long OpeningStockLineId { get; set; }

    public long OpeningStockId { get; set; }

    public long ProductId { get; set; }

    public int UomId { get; set; }

    public int OpeningStockQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal OpeningStockRate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? OpeningStockValue { get; set; }

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

    [InverseProperty("OpeningStockLine")]
    public virtual ICollection<MMrpStoreOpeningStockBatch> MMrpStoreOpeningStockBatches { get; set; } = new List<MMrpStoreOpeningStockBatch>();

    [ForeignKey("OpeningStockId")]
    [InverseProperty("MMrpStoreOpeningStockLines")]
    public virtual MMrpStoreOpeningStock OpeningStock { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStoreOpeningStockLines")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("UomId")]
    [InverseProperty("MMrpStoreOpeningStockLines")]
    public virtual MUom Uom { get; set; } = null!;
}
