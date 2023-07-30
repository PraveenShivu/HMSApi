using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ProviderCredential")]
public partial class MProviderCredential
{
    [Key]
    public int ProviderCredentialId { get; set; }

    public int ProviderId { get; set; }

    public int CredentialId { get; set; }

    [StringLength(25)]
    public string? ReferenceNo { get; set; }

    [StringLength(100)]
    public string? Remarks { get; set; }

    [StringLength(1)]
    public string? Status { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("CredentialId")]
    [InverseProperty("MProviderCredentials")]
    public virtual MGeneralLookup Credential { get; set; } = null!;

    [ForeignKey("ProviderId")]
    [InverseProperty("MProviderCredentials")]
    public virtual MProvider Provider { get; set; } = null!;
}
