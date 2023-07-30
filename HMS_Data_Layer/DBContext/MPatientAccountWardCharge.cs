using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PatientAccountWardCharges")]
public partial class MPatientAccountWardCharge
{
    [Key]
    public long ChargeId { get; set; }

    public long? PatientId { get; set; }

    public long? EncounterId { get; set; }

    public int? ServiceId { get; set; }

    public int? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Rate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    public bool? IsPosted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }
}
