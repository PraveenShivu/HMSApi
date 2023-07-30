using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoresProducts")]
public partial class MMrpStoresProduct
{
    [Key]
    public long StoreProductId { get; set; }

    public long StoreId { get; set; }

    public int FacilityId { get; set; }

    public long ProductId { get; set; }

    public int? MinQty { get; set; }

    public int? MaxQty { get; set; }

    public int? ReorderLevel { get; set; }

    public int? ReorderQty { get; set; }

    public int? MinStock { get; set; }

    public int? LeadTimeDays { get; set; }

    public int? Contigency { get; set; }

    [StringLength(50)]
    public string? IndentBasis { get; set; }

    public int? StockLocator { get; set; }

    public bool? IsConsumptionAllowed { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MMrpStoresProducts")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStoresProducts")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("StockLocator")]
    [InverseProperty("MMrpStoresProducts")]
    public virtual MGeneralLookup? StockLocatorNavigation { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("MMrpStoresProducts")]
    public virtual MMrpStore Store { get; set; } = null!;
}
