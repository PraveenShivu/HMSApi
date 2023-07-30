using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountBill")]
public partial class TPatientAccountBill
{
    [Key]
    [Column("BillID")]
    public long BillId { get; set; }

    [Column("FacilityID")]
    public int FacilityId { get; set; }

    [StringLength(50)]
    public string BillNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime BillDate { get; set; }

    public long BillTo { get; set; }

    public bool IsCashBill { get; set; }

    public bool? IsPharmacyBill { get; set; }

    public bool? BillHasPackage { get; set; }

    [Column("PatientID")]
    public long PatientId { get; set; }

    [Column("EncounterID")]
    public long EncounterId { get; set; }

    [Column("PayerID")]
    public int? PayerId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal BillAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? DiscountPercent { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TaxPercent { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? RoundOffAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? FinalBillAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? BillSettledAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? BillOutstandingAmount { get; set; }

    [StringLength(50)]
    public string? ClaimReference { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ClaimAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ClaimAgreedAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ClaimSettledAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ClaimPendingAmount { get; set; }

    [StringLength(50)]
    public string? BillStatus { get; set; }

    [StringLength(50)]
    public string? CancelReason { get; set; }

    public int? PreparedBy { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PayerTax { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PayerAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PayerTotal { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ClaimDeniedAmount { get; set; }

    public int? Status { get; set; }

    public int? ClaimStatus { get; set; }

    [StringLength(50)]
    public string? ClaimNumber { get; set; }

    public int? AssignedPlanId { get; set; }

    [Column(TypeName = "text")]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? OrginalCliamAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SubmittedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecivedDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Refundamount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TotalAdjustedAmt { get; set; }

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientAccountBills")]
    public virtual TEncounter Encounter { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("TPatientAccountBills")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientAccountBills")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;

    [ForeignKey("PreparedBy")]
    [InverseProperty("TPatientAccountBills")]
    public virtual MProvider? PreparedByNavigation { get; set; }

    [InverseProperty("PatientBill")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountCharges { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("PatientBill")]
    public virtual ICollection<TPatientAccountReceiptAdjust> TPatientAccountReceiptAdjusts { get; set; } = new List<TPatientAccountReceiptAdjust>();
}
