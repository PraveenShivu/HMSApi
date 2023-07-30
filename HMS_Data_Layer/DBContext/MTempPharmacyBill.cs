using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_temp_Pharmacy_Bill")]
public partial class MTempPharmacyBill
{
    [Key]
    public int PharId { get; set; }

    [Column("AssignPlanID")]
    public long? AssignPlanId { get; set; }

    [StringLength(500)]
    public string? Batchno { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ChargeAmt { get; set; }

    public long? ChargeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatDatetime { get; set; }

    public long? Encounterid { get; set; }

    [StringLength(500)]
    public string? Encounter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Exipirydate { get; set; }

    [Column("facilityId")]
    public int? FacilityId { get; set; }

    [Column("netAmt", TypeName = "decimal(9, 2)")]
    public decimal? NetAmt { get; set; }

    public int? Orderid { get; set; }

    [Column("PatientBillID")]
    public long? PatientBillId { get; set; }

    public long? PatientId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientTaxAmt { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientTaxrate1 { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PatientTaxrate2 { get; set; }

    [Column("PatientTypeID")]
    public int? PatientTypeId { get; set; }

    [Column("PatientProviderID")]
    public int? PatientProviderId { get; set; }

    [Column("quantity")]
    public int? Quantity { get; set; }

    [Column("rate", TypeName = "decimal(18, 0)")]
    public decimal? Rate { get; set; }

    [Column("serviceclassificationid")]
    public long? Serviceclassificationid { get; set; }

    [Column("serviceId")]
    public long? ServiceId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Taxrate1 { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Taxrate2 { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TaxAmt { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Discount { get; set; }

    public long? PaymentMode { get; set; }

    public long? ReceiptId { get; set; }
}
