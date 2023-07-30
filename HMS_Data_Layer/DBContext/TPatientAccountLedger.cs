using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountLedger")]
public partial class TPatientAccountLedger
{
    [Key]
    [Column("PatientLedgerID")]
    public long PatientLedgerId { get; set; }

    [Column("FacilityID")]
    public int FacilityId { get; set; }

    [StringLength(50)]
    public string? SourceType { get; set; }

    [Column("PatientID")]
    public long? PatientId { get; set; }

    [Column("EncounterID")]
    public long? EncounterId { get; set; }

    [StringLength(50)]
    public string? DocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? DebitAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? CreditAmount { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? BalanceAmount { get; set; }

    [StringLength(100)]
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

    [ForeignKey("EncounterId")]
    [InverseProperty("TPatientAccountLedgers")]
    public virtual TEncounter? Encounter { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("TPatientAccountLedgers")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientAccountLedgers")]
    public virtual MPatientsRegistration? Patient { get; set; }
}
