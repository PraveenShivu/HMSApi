using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountDefaultTariff")]
public partial class TPatientAccountDefaultTariff
{
    [Key]
    public int DefaultTariffId { get; set; }

    public int FacilityId { get; set; }

    public bool CashPatient { get; set; }

    public int? PayerId { get; set; }

    public int PatientTypeId { get; set; }

    public int PriceTariffId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("TPatientAccountDefaultTariffs")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("PatientTypeId")]
    [InverseProperty("TPatientAccountDefaultTariffs")]
    public virtual MGeneralLookup PatientType { get; set; } = null!;

    [ForeignKey("PayerId")]
    [InverseProperty("TPatientAccountDefaultTariffs")]
    public virtual MPayerRegistration? Payer { get; set; }

    [ForeignKey("PriceTariffId")]
    [InverseProperty("TPatientAccountDefaultTariffs")]
    public virtual MBillPriceTariff PriceTariff { get; set; } = null!;
}
