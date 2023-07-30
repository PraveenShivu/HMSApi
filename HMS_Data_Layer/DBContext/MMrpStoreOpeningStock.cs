using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreOpeningStock")]
public partial class MMrpStoreOpeningStock
{
    [Key]
    public long OpeningStockId { get; set; }

    [StringLength(50)]
    public string? OpeningStockRefNo { get; set; }

    public int Year { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OpeningStockDate { get; set; }

    public long ReceivingStoreId { get; set; }

    [StringLength(20)]
    public string? OpeningStockStatus { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

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

    [InverseProperty("OpeningStock")]
    public virtual ICollection<MMrpStoreOpeningStockLine> MMrpStoreOpeningStockLines { get; set; } = new List<MMrpStoreOpeningStockLine>();

    [ForeignKey("ReceivingStoreId")]
    [InverseProperty("MMrpStoreOpeningStocks")]
    public virtual MMrpStore ReceivingStore { get; set; } = null!;
}
