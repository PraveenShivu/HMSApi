using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_PoHeader")]
public partial class MMrpPoHeader
{
    [Key]
    public long PoHeaderId { get; set; }

    public int FacilityId { get; set; }

    public long ProcurementStoreId { get; set; }

    public int DocumentType { get; set; }

    public long SupplierId { get; set; }

    [Column("PONumber")]
    [StringLength(50)]
    public string? Ponumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PoDate { get; set; }

    [StringLength(50)]
    public string? PoStatus { get; set; }

    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? PoPurchaseValue { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? PoTaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? PoTotalAmount { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("DocumentType")]
    [InverseProperty("MMrpPoHeaders")]
    public virtual MGeneralLookup DocumentTypeNavigation { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("MMrpPoHeaders")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("PoHeader")]
    public virtual ICollection<MMrpPoLine> MMrpPoLines { get; set; } = new List<MMrpPoLine>();

    [ForeignKey("ProcurementStoreId")]
    [InverseProperty("MMrpPoHeaders")]
    public virtual MMrpStore ProcurementStore { get; set; } = null!;

    [ForeignKey("SupplierId")]
    [InverseProperty("MMrpPoHeaders")]
    public virtual MVendor Supplier { get; set; } = null!;
}
