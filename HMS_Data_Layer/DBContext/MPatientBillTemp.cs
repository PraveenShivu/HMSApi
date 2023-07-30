using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Patient_Bill_Temp")]
public partial class MPatientBillTemp
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("PatientBillID")]
    public long? PatientBillId { get; set; }

    [Column("UHID")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Uhid { get; set; }

    [Column("Patient_Name")]
    [StringLength(550)]
    [Unicode(false)]
    public string? PatientName { get; set; }

    [Column("PatientID")]
    public int? PatientId { get; set; }

    [Column("EncounterID")]
    public long? EncounterId { get; set; }

    [Column("Provider_Name")]
    [StringLength(550)]
    [Unicode(false)]
    public string? ProviderName { get; set; }

    [Column("Bill_No")]
    [StringLength(550)]
    public string? BillNo { get; set; }

    [Column("Bill_Date", TypeName = "datetime")]
    public DateTime? BillDate { get; set; }

    [Column("Admission_Time", TypeName = "datetime")]
    public DateTime? AdmissionTime { get; set; }

    [Column("DepartmentID")]
    public int? DepartmentId { get; set; }

    [Column("Department_Name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DepartmentName { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientTaxAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientNetAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientDiscountAmount { get; set; }

    [Column("ServiceID")]
    public int? ServiceId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientChargeAmount { get; set; }

    [Column("Mobile_No")]
    [StringLength(250)]
    [Unicode(false)]
    public string? MobileNo { get; set; }

    public int? FacilityId { get; set; }

    [StringLength(250)]
    public string? Address { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? RoundOffAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? BillOutstandingAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ClaimReference { get; set; }

    [StringLength(550)]
    [Unicode(false)]
    public string? PaymentModeName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Cashreciptdate { get; set; }

    public int? ServiceGroupId { get; set; }

    [StringLength(250)]
    public string? ServicegroupName { get; set; }

    [Column("OrderID")]
    public int? OrderId { get; set; }

    [StringLength(250)]
    public string? OrderNo { get; set; }

    public int? ServiceClassificationId { get; set; }

    [StringLength(250)]
    public string? ServiceClassificationName { get; set; }

    [StringLength(250)]
    public string? ServiceName { get; set; }

    [Column("PAtientTypeID")]
    public int? PatientTypeId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Taxrate { get; set; }

    [Column("PAtientTypename")]
    [StringLength(250)]
    public string? PatientTypename { get; set; }

    [Column("ProviderID")]
    public long? ProviderId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? BaseChargeAmt { get; set; }

    public long? PayerId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PayerTotal { get; set; }

    public int? Qty { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? AdjustedAmt { get; set; }
}
