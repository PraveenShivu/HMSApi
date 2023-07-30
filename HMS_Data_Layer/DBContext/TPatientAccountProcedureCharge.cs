using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountProcedureCharges")]
public partial class TPatientAccountProcedureCharge
{
    [Key]
    public int ProcedureChargeId { get; set; }

    public int FacilityId { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    public int AnesthesiaTypeId { get; set; }

    public int AnesthesiaTypeChargeId { get; set; }

    public bool? IsChargeable { get; set; }

    public int? ProcedureId { get; set; }

    public int? Rate { get; set; }

    public int? ChargeAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public int? ProviderId { get; set; }

    public int? Priority { get; set; }

    public int? Discount { get; set; }

    public bool? ServiceTax { get; set; }

    public int? TaxAmount { get; set; }

    public int? NetAmount { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? DiscountRate { get; set; }

    [ForeignKey("AnesthesiaTypeId")]
    [InverseProperty("TPatientAccountProcedureChargeAnesthesiaTypes")]
    public virtual MGeneralLookup AnesthesiaType { get; set; } = null!;

    [ForeignKey("AnesthesiaTypeChargeId")]
    [InverseProperty("TPatientAccountProcedureChargeAnesthesiaTypeCharges")]
    public virtual MGeneralLookup AnesthesiaTypeCharge { get; set; } = null!;

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientAccountProcedureCharges")]
    public virtual TEncounter Encounter { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("TPatientAccountProcedureCharges")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientAccountProcedureCharges")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;

    [ForeignKey("ProcedureId")]
    [InverseProperty("TPatientAccountProcedureCharges")]
    public virtual MBillService? Procedure { get; set; }

    [ForeignKey("ProviderId")]
    [InverseProperty("TPatientAccountProcedureCharges")]
    public virtual MProvider? Provider { get; set; }

    [InverseProperty("ProcedureCharge")]
    public virtual ICollection<TPatientAccountProcedureChargesDetail> TPatientAccountProcedureChargesDetails { get; set; } = new List<TPatientAccountProcedureChargesDetail>();
}
