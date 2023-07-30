using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ProductStock")]
public partial class MProductStock
{
    [Key]
    public long StockId { get; set; }

    public long ProductId { get; set; }

    [StringLength(30)]
    public string Serialization { get; set; } = null!;

    public int? MinimumStock { get; set; }

    public int? MaximumStock { get; set; }

    public int? ReorderLevel { get; set; }

    public int? ReorderQuantity { get; set; }

    public int? MinimumStockDays { get; set; }

    [StringLength(30)]
    public string BarcodeApplicability { get; set; } = null!;

    public int? DefaultPrice { get; set; }

    public int? MinimumShelfLifeinDays { get; set; }

    [StringLength(1)]
    public string? IsConsumptionAllowed { get; set; }

    public int? LeadTimeinDays { get; set; }

    public int? DrugForm { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("DrugForm")]
    [InverseProperty("MProductStocks")]
    public virtual MGeneralLookup? DrugFormNavigation { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MProductStocks")]
    public virtual MProductDefinition Product { get; set; } = null!;
}
