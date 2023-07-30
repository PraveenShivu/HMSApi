using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountProcedureChargesDetails")]
public partial class TPatientAccountProcedureChargesDetail
{
    [Key]
    public int ProcedureChargeDetailId { get; set; }

    public int? ProcedureChargeId { get; set; }

    public bool? IsChargeable { get; set; }

    public int? AssociativeServiceId { get; set; }

    public int ProviderId { get; set; }

    public int ServiceQty { get; set; }

    public int ChargeAmount { get; set; }

    public int? DiscountAmount { get; set; }

    public int? TaxRate { get; set; }

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

    [ForeignKey("AssociativeServiceId")]
    [InverseProperty("TPatientAccountProcedureChargesDetails")]
    public virtual MBillService? AssociativeService { get; set; }

    [ForeignKey("ProcedureChargeId")]
    [InverseProperty("TPatientAccountProcedureChargesDetails")]
    public virtual TPatientAccountProcedureCharge? ProcedureCharge { get; set; }

    [ForeignKey("ProviderId")]
    [InverseProperty("TPatientAccountProcedureChargesDetails")]
    public virtual MProvider Provider { get; set; } = null!;
}
