using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_GrnHeader")]
public partial class MMrpGrnHeader
{
    [Key]
    public long GrnHeaderId { get; set; }

    public int FacilityId { get; set; }

    public long? PoHeaderId { get; set; }

    public long ReceivingStoreId { get; set; }

    public long SupplierId { get; set; }

    [StringLength(50)]
    public string GrnNumber { get; set; } = null!;

    public int DocumentType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime GrnDate { get; set; }

    [StringLength(20)]
    public string GrnStatus { get; set; } = null!;

    [StringLength(50)]
    public string InvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal InvoiceAmount { get; set; }

    [StringLength(50)]
    public string? DcNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DcDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReceivedDate { get; set; }

    [StringLength(80)]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal RoundOff { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal TotalPoAmount { get; set; }

    [StringLength(20)]
    public string? GrnType { get; set; }

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
    [InverseProperty("MMrpGrnHeaders")]
    public virtual MGeneralLookup DocumentTypeNavigation { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("MMrpGrnHeaders")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("ReceivingStoreId")]
    [InverseProperty("MMrpGrnHeaders")]
    public virtual MMrpStore ReceivingStore { get; set; } = null!;

    [ForeignKey("SupplierId")]
    [InverseProperty("MMrpGrnHeaders")]
    public virtual MVendor Supplier { get; set; } = null!;
}
