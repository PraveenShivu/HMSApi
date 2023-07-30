using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountReFundHeader")]
public partial class TPatientAccountReFundHeader
{
    [Key]
    public long ReFundId { get; set; }

    [StringLength(50)]
    public string? RecieptNumber { get; set; }

    public int? FacilityId { get; set; }

    [Column("PatientID")]
    public long? PatientId { get; set; }

    [Column("EncounterID")]
    public long? EncounterId { get; set; }

    [Column("ProviderID")]
    public int? ProviderId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReFundDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ReFundAmount { get; set; }

    [StringLength(100)]
    public string? ReFundTo { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? BalanceAmt { get; set; }

    [StringLength(100)]
    public string? Remarks { get; set; }

    [StringLength(50)]
    public string? ReFundStatus { get; set; }

    public int? ReFundCancelReasonId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? ActiveFlag { get; set; }

    [Column("ReceiptID")]
    public long? ReceiptId { get; set; }
}
