using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_IndentIssues")]
public partial class MMrpIndentIssue
{
    [Key]
    public long IndentIssueId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssueDate { get; set; }

    public long IssueStoreId { get; set; }

    public long RequestStoreId { get; set; }

    public long? IndentId { get; set; }

    [StringLength(15)]
    public string IssueRefNo { get; set; } = null!;

    [StringLength(200)]
    public string? Remarks { get; set; }

    [StringLength(50)]
    public string IssueStatus { get; set; } = null!;

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

    [ForeignKey("IssueStoreId")]
    [InverseProperty("MMrpIndentIssueIssueStores")]
    public virtual MMrpStore IssueStore { get; set; } = null!;

    [InverseProperty("IndentIssue")]
    public virtual ICollection<MMrpIndentIssueLine> MMrpIndentIssueLines { get; set; } = new List<MMrpIndentIssueLine>();

    [ForeignKey("RequestStoreId")]
    [InverseProperty("MMrpIndentIssueRequestStores")]
    public virtual MMrpStore RequestStore { get; set; } = null!;
}
