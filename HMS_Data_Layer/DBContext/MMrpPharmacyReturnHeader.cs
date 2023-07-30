using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_PharmacyReturnHeader")]
public partial class MMrpPharmacyReturnHeader
{
    [Key]
    public long PharmacyReturnHeaderId { get; set; }

    public int? FacilityId { get; set; }

    public long? PatientId { get; set; }

    public long? EncounterId { get; set; }

    public long? BillId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

    [StringLength(100)]
    public string? Reason { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? RefundedAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BalanceAmount { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [Column("Pharmacy_Return_StoreID")]
    public long? PharmacyReturnStoreId { get; set; }
}
