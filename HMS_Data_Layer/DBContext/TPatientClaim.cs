using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientClaim")]
public partial class TPatientClaim
{
    [Key]
    public int PatientclaimId { get; set; }

    [StringLength(50)]
    public string Uhid { get; set; } = null!;

    public int PatientId { get; set; }

    public int PayerId { get; set; }

    [StringLength(100)]
    public string? Payername { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fromdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Todate { get; set; }

    public int EncounterId { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    public int StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public int FacilityId { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(50)]
    public string? Claimnumber { get; set; }

    [StringLength(50)]
    public string? ClaimStatus { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? BillAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BillNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Billdate { get; set; }
}
