using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_Stores")]
public partial class MMrpStore
{
    [Key]
    public long StoreId { get; set; }

    public int FacilityId { get; set; }

    [StringLength(50)]
    public string StoreType { get; set; } = null!;

    public int ServiceLocationId { get; set; }

    public long? DefaultParentStore { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("IsOP")]
    [StringLength(1)]
    public string? IsOp { get; set; }

    [Column("IsIP")]
    [StringLength(1)]
    public string? IsIp { get; set; }

    [StringLength(1)]
    public string? IsDirect { get; set; }

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
    [InverseProperty("MMrpStores")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("ReceivingStore")]
    public virtual ICollection<MMrpGrnHeader> MMrpGrnHeaders { get; set; } = new List<MMrpGrnHeader>();

    [InverseProperty("IssueStore")]
    public virtual ICollection<MMrpIndentIssue> MMrpIndentIssueIssueStores { get; set; } = new List<MMrpIndentIssue>();

    [InverseProperty("RequestStore")]
    public virtual ICollection<MMrpIndentIssue> MMrpIndentIssueRequestStores { get; set; } = new List<MMrpIndentIssue>();

    [InverseProperty("IssueStore")]
    public virtual ICollection<MMrpIndentIssuesPatient> MMrpIndentIssuesPatients { get; set; } = new List<MMrpIndentIssuesPatient>();

    [InverseProperty("ProcurementStore")]
    public virtual ICollection<MMrpPoHeader> MMrpPoHeaders { get; set; } = new List<MMrpPoHeader>();

    [InverseProperty("Store")]
    public virtual ICollection<MMrpStockCurrent> MMrpStockCurrents { get; set; } = new List<MMrpStockCurrent>();

    [InverseProperty("Store")]
    public virtual ICollection<MMrpStockLedger> MMrpStockLedgers { get; set; } = new List<MMrpStockLedger>();

    [InverseProperty("Store")]
    public virtual ICollection<MMrpStoreAccessRight> MMrpStoreAccessRights { get; set; } = new List<MMrpStoreAccessRight>();

    [InverseProperty("IssueStore")]
    public virtual ICollection<MMrpStoreConsumption> MMrpStoreConsumptions { get; set; } = new List<MMrpStoreConsumption>();

    [InverseProperty("IssuingStore")]
    public virtual ICollection<MMrpStoreIndent> MMrpStoreIndentIssuingStores { get; set; } = new List<MMrpStoreIndent>();

    [InverseProperty("IssueStore")]
    public virtual ICollection<MMrpStoreIndentReceipt> MMrpStoreIndentReceiptIssueStores { get; set; } = new List<MMrpStoreIndentReceipt>();

    [InverseProperty("RequestStore")]
    public virtual ICollection<MMrpStoreIndentReceipt> MMrpStoreIndentReceiptRequestStores { get; set; } = new List<MMrpStoreIndentReceipt>();

    [InverseProperty("RequestingStore")]
    public virtual ICollection<MMrpStoreIndent> MMrpStoreIndentRequestingStores { get; set; } = new List<MMrpStoreIndent>();

    [InverseProperty("ReceivingStore")]
    public virtual ICollection<MMrpStoreOpeningStock> MMrpStoreOpeningStocks { get; set; } = new List<MMrpStoreOpeningStock>();

    [InverseProperty("Store")]
    public virtual ICollection<MMrpStoresProduct> MMrpStoresProducts { get; set; } = new List<MMrpStoresProduct>();
}
