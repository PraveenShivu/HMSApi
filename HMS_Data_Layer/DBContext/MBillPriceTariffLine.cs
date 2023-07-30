using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillPriceTariffLine")]
public partial class MBillPriceTariffLine
{
    [Key]
    public int PriceTariffLineId { get; set; }

    public int PriceTariffId { get; set; }

    public int? WardTypeId { get; set; }

    public int? PatientTypeId { get; set; }

    public int? Gender { get; set; }

    public int? Nationality { get; set; }

    public int? Payer { get; set; }

    public int? Provider { get; set; }

    public int? IncomeLimit { get; set; }

    public int Indicator { get; set; }

    public int? IndicatorDescriptionId { get; set; }

    [StringLength(20)]
    public string? TariffLineIndicator { get; set; }

    [StringLength(20)]
    public string? FactorAmount { get; set; }

    public int? TariffLineValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveTo { get; set; }

    public int? RevisionNo { get; set; }

    [StringLength(10)]
    public string Status { get; set; } = null!;

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("Gender")]
    [InverseProperty("MBillPriceTariffLineGenderNavigations")]
    public virtual MGeneralLookup? GenderNavigation { get; set; }

    [ForeignKey("Indicator")]
    [InverseProperty("MBillPriceTariffLineIndicatorNavigations")]
    public virtual MGeneralLookup IndicatorNavigation { get; set; } = null!;

    [ForeignKey("Nationality")]
    [InverseProperty("MBillPriceTariffLineNationalityNavigations")]
    public virtual MGeneralLookup? NationalityNavigation { get; set; }

    [ForeignKey("PatientTypeId")]
    [InverseProperty("MBillPriceTariffLinePatientTypes")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("Payer")]
    [InverseProperty("MBillPriceTariffLines")]
    public virtual MPayerRegistration? PayerNavigation { get; set; }

    [ForeignKey("PriceTariffId")]
    [InverseProperty("MBillPriceTariffLines")]
    public virtual MBillPriceTariff PriceTariff { get; set; } = null!;

    [ForeignKey("Provider")]
    [InverseProperty("MBillPriceTariffLines")]
    public virtual MProvider? ProviderNavigation { get; set; }

    [ForeignKey("WardTypeId")]
    [InverseProperty("MBillPriceTariffLineWardTypes")]
    public virtual MGeneralLookup? WardType { get; set; }
}
