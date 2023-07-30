using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Transactions")]
public partial class TTransaction
{
    [Key]
    public long AdtId { get; set; }

    [StringLength(50)]
    public string AdtType { get; set; } = null!;

    public long PatientId { get; set; }

    public int FromDepartmentId { get; set; }

    public int FromServiceLocationId { get; set; }

    public int FromProviderId { get; set; }

    public int FromWardCategoryId { get; set; }

    public long? FromWardId { get; set; }

    public long? FromBedId { get; set; }

    public int ReasonId { get; set; }

    [StringLength(1)]
    public string? RetainCurrentBed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PreferredDatetime { get; set; }

    public int ToServiceLocationId { get; set; }

    public int ToWardCategoryId { get; set; }

    public long? ToWardId { get; set; }

    public long? ToBedId { get; set; }

    [StringLength(50)]
    public string? TransferStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestedDatetime { get; set; }

    [StringLength(50)]
    public string? RequestedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AcceptRejectTime { get; set; }

    [StringLength(50)]
    public string? AcceptRejectBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransferTime { get; set; }

    [StringLength(50)]
    public string? TransferBy { get; set; }

    [StringLength(50)]
    public string ActionStatus { get; set; } = null!;

    public int FacilityId { get; set; }

    public long? EncounterId { get; set; }

    [ForeignKey("FromBedId")]
    [InverseProperty("TTransactionFromBeds")]
    public virtual MBed? FromBed { get; set; }

    [ForeignKey("FromWardCategoryId")]
    [InverseProperty("TTransactionFromWardCategories")]
    public virtual MGeneralLookup FromWardCategory { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("TTransactions")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;

    [ForeignKey("ToBedId")]
    [InverseProperty("TTransactionToBeds")]
    public virtual MBed? ToBed { get; set; }

    [ForeignKey("ToWardCategoryId")]
    [InverseProperty("TTransactionToWardCategories")]
    public virtual MGeneralLookup ToWardCategory { get; set; } = null!;
}
