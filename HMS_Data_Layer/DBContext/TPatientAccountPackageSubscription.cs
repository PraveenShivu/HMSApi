using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientAccountPackageSubscription")]
public partial class TPatientAccountPackageSubscription
{
    [Key]
    [Column("PackageSubsID")]
    public int PackageSubsId { get; set; }

    [Column("PatientID")]
    public long PatientId { get; set; }

    [Column("EncounterID")]
    public long EncounterId { get; set; }

    [Column("ServicePackageID")]
    public int ServicePackageId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public int NoOfDays { get; set; }

    [Column("ProviderID")]
    public int ProviderId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal PackageAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal DepositPaid { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal BalanceAmt { get; set; }

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
    [InverseProperty("TPatientAccountPackageSubscriptions")]
    public virtual TEncounter Encounter { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("TPatientAccountPackageSubscriptions")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;

    [ForeignKey("ProviderId")]
    [InverseProperty("TPatientAccountPackageSubscriptions")]
    public virtual MProvider Provider { get; set; } = null!;

    [ForeignKey("ServicePackageId")]
    [InverseProperty("TPatientAccountPackageSubscriptions")]
    public virtual MBillService ServicePackage { get; set; } = null!;
}
