using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PayerIdentification")]
public partial class MPayerIdentification
{
    [Key]
    public int PayerIdentityId { get; set; }

    public int PayerId { get; set; }

    public int IdentificationId { get; set; }

    [StringLength(30)]
    public string? IdentityReferenceNo { get; set; }

    [Column(TypeName = "date")]
    public DateTime ExpiryDate { get; set; }

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

    [ForeignKey("IdentificationId")]
    [InverseProperty("MPayerIdentifications")]
    public virtual MGeneralLookup Identification { get; set; } = null!;

    [ForeignKey("PayerId")]
    [InverseProperty("MPayerIdentifications")]
    public virtual MPayerRegistration Payer { get; set; } = null!;
}
