using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_VendorReturnHeader")]
public partial class MMrpVendorReturnHeader
{
    [Key]
    public long VendorReturnHeaderId { get; set; }

    public int FacilityId { get; set; }

    public long ReturningStoreId { get; set; }

    public long VendorId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReturnDate { get; set; }

    [StringLength(50)]
    public string ReferenceNo { get; set; } = null!;

    [StringLength(100)]
    public string? Reason { get; set; }

    [StringLength(50)]
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
}
