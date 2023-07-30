using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreIndentReceipt")]
public partial class MMrpStoreIndentReceipt
{
    [Key]
    public long IndentReceiptId { get; set; }

    [StringLength(50)]
    public string ReceiptNumber { get; set; } = null!;

    public long? IndentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReceiptDate { get; set; }

    public long IssueStoreId { get; set; }

    public long RequestStoreId { get; set; }

    public long IndentIssueId { get; set; }

    [StringLength(10)]
    public string IndentReceiptStatus { get; set; } = null!;

    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? FacilityId { get; set; }

    [ForeignKey("IssueStoreId")]
    [InverseProperty("MMrpStoreIndentReceiptIssueStores")]
    public virtual MMrpStore IssueStore { get; set; } = null!;

    [InverseProperty("IndentReceipt")]
    public virtual ICollection<MMrpStoreIndentReceiptLine> MMrpStoreIndentReceiptLines { get; set; } = new List<MMrpStoreIndentReceiptLine>();

    [ForeignKey("RequestStoreId")]
    [InverseProperty("MMrpStoreIndentReceiptRequestStores")]
    public virtual MMrpStore RequestStore { get; set; } = null!;
}
