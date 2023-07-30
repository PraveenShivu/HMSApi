using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Recipt_Bill_Temp")]
public partial class MReciptBillTemp
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Column("Receipt_Amount", TypeName = "decimal(9, 2)")]
    public decimal? ReceiptAmount { get; set; }

    [Column("Payment_Mode")]
    [StringLength(250)]
    [Unicode(false)]
    public string? PaymentMode { get; set; }

    [Column("Receipt_No")]
    [StringLength(250)]
    [Unicode(false)]
    public string? ReceiptNo { get; set; }

    [Column("Receipt_Date", TypeName = "datetime")]
    public DateTime? ReceiptDate { get; set; }

    public long? FacilityId { get; set; }

    [Column("PatiendID")]
    public long? PatiendId { get; set; }

    public long? EncounterId { get; set; }

    [Column("PatientBillID")]
    public long? PatientBillId { get; set; }

    [StringLength(50)]
    public string? PatientBillNo { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? RoundOffAmount { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? BillOutstandingAmount { get; set; }

    [StringLength(50)]
    public string? ClaimReference { get; set; }

    [StringLength(50)]
    public string? PaymentModeName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Cashreciptdate { get; set; }

    public long? ReceiptId { get; set; }
}
