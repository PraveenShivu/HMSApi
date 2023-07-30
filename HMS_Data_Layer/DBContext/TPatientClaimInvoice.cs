using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientClaimInvoice")]
public partial class TPatientClaimInvoice
{
    [Key]
    public int PatientInvoiceId { get; set; }

    public int PayerId { get; set; }

    public int StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public int FacilityId { get; set; }

    public bool ActiveFlag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Authorisationdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Submissioondate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Orginalclimedamount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Agreedamount { get; set; }

    [Column("climedamount", TypeName = "decimal(9, 2)")]
    public decimal? Climedamount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Denaiedamount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Recivedamount { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PendingAmount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AuthorisationRef { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecivedDate { get; set; }

    public long? PatientId { get; set; }

    public long? EncounterId { get; set; }

    [Column("BillID")]
    public long? BillId { get; set; }

    public int? InsuranceId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Encounter { get; set; }

    [StringLength(100)]
    public string? Statusname { get; set; }

    [StringLength(100)]
    public string? Payer { get; set; }

    [StringLength(100)]
    public string? InsuranceName { get; set; }
}
