using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Bed")]
public partial class MBed
{
    [Key]
    public long BedId { get; set; }

    public long WardId { get; set; }

    [StringLength(20)]
    public string BedName { get; set; } = null!;

    public int? FacilityId { get; set; }

    public int? PatientStatus { get; set; }

    public long? PatientId { get; set; }

    public long? AdtId { get; set; }

    public int? ReasonForBlock { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BlockTime { get; set; }

    [StringLength(200)]
    public string? Remarks { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("Bed")]
    public virtual ICollection<TEncounter> TEncounters { get; set; } = new List<TEncounter>();

    [InverseProperty("Bed")]
    public virtual ICollection<TPatientDischarge> TPatientDischarges { get; set; } = new List<TPatientDischarge>();

    [InverseProperty("Bed")]
    public virtual ICollection<TPatientMovement> TPatientMovements { get; set; } = new List<TPatientMovement>();

    [InverseProperty("FromBed")]
    public virtual ICollection<TTransaction> TTransactionFromBeds { get; set; } = new List<TTransaction>();

    [InverseProperty("ToBed")]
    public virtual ICollection<TTransaction> TTransactionToBeds { get; set; } = new List<TTransaction>();

    [ForeignKey("WardId")]
    [InverseProperty("MBeds")]
    public virtual MWard Ward { get; set; } = null!;
}
