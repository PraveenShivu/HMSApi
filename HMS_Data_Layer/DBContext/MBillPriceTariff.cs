using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillPriceTariff")]
public partial class MBillPriceTariff
{
    [Key]
    public int PriceTariffId { get; set; }

    public int? FacilityId { get; set; }

    [StringLength(20)]
    public string ShortPriceDescription { get; set; } = null!;

    [StringLength(50)]
    public string LongPriceDescription { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveFrom { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveTo { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MBillPriceTariffs")]
    public virtual MFacility? Facility { get; set; }

    [InverseProperty("PriceTariff")]
    public virtual ICollection<MBillPriceTariffLine> MBillPriceTariffLines { get; set; } = new List<MBillPriceTariffLine>();

    [InverseProperty("TariffPlan")]
    public virtual ICollection<TPatientAccountAssignedPlan> TPatientAccountAssignedPlans { get; set; } = new List<TPatientAccountAssignedPlan>();

    [InverseProperty("PriceTariff")]
    public virtual ICollection<TPatientAccountDefaultTariff> TPatientAccountDefaultTariffs { get; set; } = new List<TPatientAccountDefaultTariff>();
}
