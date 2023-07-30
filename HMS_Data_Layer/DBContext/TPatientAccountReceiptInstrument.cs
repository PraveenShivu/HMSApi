using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountReceiptInstrument")]
public partial class TPatientAccountReceiptInstrument
{
    [Key]
    [Column("PaymentModeID")]
    public long PaymentModeId { get; set; }

    [Column("ReceiptID")]
    public long ReceiptId { get; set; }

    [Column("PaymentTypeID")]
    public int PaymentTypeId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal InstrumentAmount { get; set; }

    [Column("BankID")]
    public int? BankId { get; set; }

    [StringLength(50)]
    public string? BranchName { get; set; }

    [Column("IFSC")]
    [StringLength(12)]
    public string? Ifsc { get; set; }

    [StringLength(16)]
    public string? CardNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChequeDate { get; set; }

    public int? CardExpiryYear { get; set; }

    public int? CardExpiryMonth { get; set; }

    [StringLength(10)]
    public string? AuthorizationReference { get; set; }

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

    [Column("EncounterID")]
    public long? EncounterId { get; set; }

    [ForeignKey("BankId")]
    [InverseProperty("TPatientAccountReceiptInstrumentBanks")]
    public virtual MGeneralLookup? Bank { get; set; }

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientAccountReceiptInstruments")]
    public virtual TEncounter? Encounter { get; set; }

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("TPatientAccountReceiptInstrumentPaymentTypes")]
    public virtual MGeneralLookup PaymentType { get; set; } = null!;

    [ForeignKey("ReceiptId")]
    [InverseProperty("TPatientAccountReceiptInstruments")]
    public virtual TPatientAccountReceiptHeader Receipt { get; set; } = null!;
}
