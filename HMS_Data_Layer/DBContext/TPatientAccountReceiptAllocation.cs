using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountReceiptAllocation")]
public partial class TPatientAccountReceiptAllocation
{
    [Key]
    [Column("ReceiptAllocationID")]
    public long ReceiptAllocationId { get; set; }

    [Column("ReceiptID")]
    public long ReceiptId { get; set; }

    [Column("IndicatorID")]
    public int IndicatorId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? IndicatorDescription { get; set; }

    [Column("IndicatorDescriptionID")]
    public int? IndicatorDescriptionId { get; set; }

    [Column("PatientTypeID")]
    public int? PatientTypeId { get; set; }

    [Column("EncounterID")]
    public long? EncounterId { get; set; }

    public int? AllocationPercentage { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? AllocationAmount { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Utilized { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Balance { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [Column("PatientBillID")]
    public long? PatientBillId { get; set; }

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientAccountReceiptAllocations")]
    public virtual TEncounter? Encounter { get; set; }

    [ForeignKey("IndicatorId")]
    [InverseProperty("TPatientAccountReceiptAllocationIndicators")]
    public virtual MGeneralLookup Indicator { get; set; } = null!;

    [ForeignKey("PatientTypeId")]
    [InverseProperty("TPatientAccountReceiptAllocationPatientTypes")]
    public virtual MGeneralLookup? PatientType { get; set; }

    [ForeignKey("ReceiptId")]
    [InverseProperty("TPatientAccountReceiptAllocations")]
    public virtual TPatientAccountReceiptHeader Receipt { get; set; } = null!;

    [InverseProperty("ReceiptAllocation")]
    public virtual ICollection<TPatientAccountReceiptAdjust> TPatientAccountReceiptAdjusts { get; set; } = new List<TPatientAccountReceiptAdjust>();
}
