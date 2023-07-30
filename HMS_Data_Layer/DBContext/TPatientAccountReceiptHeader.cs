using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountReceiptHeader")]
public partial class TPatientAccountReceiptHeader
{
    [Key]
    [Column("ReceiptID")]
    public long ReceiptId { get; set; }

    public int? FacilityId { get; set; }

    [Column("PatientID")]
    public long PatientId { get; set; }

    [Column("EncounterID")]
    public long? EncounterId { get; set; }

    [StringLength(100)]
    public string? ReceivedFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReceiptDate { get; set; }

    public bool? IsDeposit { get; set; }

    [StringLength(20)]
    public string? DepositType { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? ReceiptAmount { get; set; }

    [StringLength(100)]
    public string? Remarks { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? DeductedAmount { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? RemainingAmount { get; set; }

    [StringLength(50)]
    public string? RecieptNumber { get; set; }

    [StringLength(50)]
    public string? RecieptStatus { get; set; }

    [StringLength(250)]
    public string? DocumentType { get; set; }

    public int? ReceiptCancelReasonId { get; set; }

    public bool? IsPharmacyBill { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RefrenceDoc { get; set; }

    [Column("PayerID")]
    public int? PayerId { get; set; }

    [Column("PayerTypeID")]
    public int? PayerTypeId { get; set; }

    [InverseProperty("Receipt")]
    public virtual ICollection<TPatientAccountReceiptAllocation> TPatientAccountReceiptAllocations { get; set; } = new List<TPatientAccountReceiptAllocation>();

    [InverseProperty("Receipt")]
    public virtual ICollection<TPatientAccountReceiptInstrument> TPatientAccountReceiptInstruments { get; set; } = new List<TPatientAccountReceiptInstrument>();
}
