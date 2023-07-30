using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_IndentIssuesPatient")]
public partial class MMrpIndentIssuesPatient
{
    [Key]
    public long PatientIssueId { get; set; }

    [StringLength(50)]
    public string? IndentType { get; set; }

    public long IssueStoreId { get; set; }

    public long? IndentId { get; set; }

    public long? OrderLocationId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssueDate { get; set; }

    [StringLength(50)]
    public string IssueRefNo { get; set; } = null!;

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

    [StringLength(50)]
    public string IssueStatus { get; set; } = null!;

    [StringLength(50)]
    public string IssueCategory { get; set; } = null!;

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

    [StringLength(5)]
    [Unicode(false)]
    public string? Servicetype { get; set; }

    [Column("ChargeID")]
    public long? ChargeId { get; set; }

    [ForeignKey("IssueStoreId")]
    [InverseProperty("MMrpIndentIssuesPatients")]
    public virtual MMrpStore IssueStore { get; set; } = null!;

    [InverseProperty("PatientIssue")]
    public virtual ICollection<MMrpIndentIssuesPatientLine> MMrpIndentIssuesPatientLines { get; set; } = new List<MMrpIndentIssuesPatientLine>();
}
