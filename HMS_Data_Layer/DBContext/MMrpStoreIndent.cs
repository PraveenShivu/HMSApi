using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreIndent")]
public partial class MMrpStoreIndent
{
    [Key]
    public long IndentId { get; set; }

    [StringLength(50)]
    public string? IndentNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IndentDate { get; set; }

    public long? RequestingStoreId { get; set; }

    public long IssuingStoreId { get; set; }

    public int IndentTemplateId { get; set; }

    [StringLength(50)]
    public string? IndentType { get; set; }

    public long? PatientId { get; set; }

    public long? EncounterId { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

    [StringLength(50)]
    public string IndentStatus { get; set; } = null!;

    [StringLength(50)]
    public string IndentCategory { get; set; } = null!;

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

    [ForeignKey("EncounterId")]
    [InverseProperty("MMrpStoreIndents")]
    public virtual TEncounter? Encounter { get; set; }

    [ForeignKey("IssuingStoreId")]
    [InverseProperty("MMrpStoreIndentIssuingStores")]
    public virtual MMrpStore IssuingStore { get; set; } = null!;

    [InverseProperty("Indent")]
    public virtual ICollection<MMrpStoreIndentLine> MMrpStoreIndentLines { get; set; } = new List<MMrpStoreIndentLine>();

    [ForeignKey("PatientId")]
    [InverseProperty("MMrpStoreIndents")]
    public virtual MPatientsRegistration? Patient { get; set; }

    [ForeignKey("RequestingStoreId")]
    [InverseProperty("MMrpStoreIndentRequestingStores")]
    public virtual MMrpStore? RequestingStore { get; set; }
}
