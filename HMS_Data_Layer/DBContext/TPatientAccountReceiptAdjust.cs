using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountReceiptAdjust")]
public partial class TPatientAccountReceiptAdjust
{
    [Key]
    [Column("ReceiptAdjustID")]
    public long ReceiptAdjustId { get; set; }

    [Column("ReceiptAllocationID")]
    public long ReceiptAllocationId { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? AdjustedAmount { get; set; }

    [Column("PatientBillID")]
    public long? PatientBillId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("PatientBillId")]
    [InverseProperty("TPatientAccountReceiptAdjusts")]
    public virtual TPatientAccountBill? PatientBill { get; set; }

    [ForeignKey("ReceiptAllocationId")]
    [InverseProperty("TPatientAccountReceiptAdjusts")]
    public virtual TPatientAccountReceiptAllocation ReceiptAllocation { get; set; } = null!;
}
