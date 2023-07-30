using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_PharmacyReturnLine")]
public partial class MMrpPharmacyReturnLine
{
    [Key]
    public long PharmacyReturnLineId { get; set; }

    public long? PharmacyReturnHeaderId { get; set; }

    public long? ProductId { get; set; }

    [StringLength(50)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    public int? ReturnQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

    public bool? ActiveFlag { get; set; }

    public long? ChargeId { get; set; }
}
