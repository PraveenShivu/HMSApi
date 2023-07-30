using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Reprint_temptbl")]
public partial class MReprintTemptbl
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Column("EncounterID")]
    public long? EncounterId { get; set; }

    [Column("PatientID")]
    public long? PatientId { get; set; }

    [Column("Receipt_Amount", TypeName = "decimal(18, 0)")]
    public decimal? ReceiptAmount { get; set; }

    [Column("Receipt_Date", TypeName = "datetime")]
    public DateTime? ReceiptDate { get; set; }

    [Column("Receipt_No")]
    [StringLength(250)]
    public string? ReceiptNo { get; set; }

    [Column("ReceiptID")]
    public int? ReceiptId { get; set; }

    [StringLength(250)]
    public string? ReccivedFrom { get; set; }

    [Column("FacilityID")]
    public int? FacilityId { get; set; }

    public int? PaymentMode { get; set; }

    [StringLength(50)]
    public string? PaymentModeName { get; set; }
}
