using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryPreopLine")]
public partial class TSummaryPreopLine
{
    [Key]
    [Column("PreopLineID")]
    public int PreopLineId { get; set; }

    public int PreopId { get; set; }

    public int AttendeeId { get; set; }

    public int RoleId { get; set; }

    public int? EncounterId { get; set; }

    public int? PatientId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Timein { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Timeout { get; set; }

    public bool? ActiveFlag { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "date")]
    public DateTime ModifiedOn { get; set; }

    [Column("PreCATimeIn")]
    [StringLength(20)]
    public string? PreCatimeIn { get; set; }

    [Column("PreCATimeOut")]
    [StringLength(20)]
    public string? PreCatimeOut { get; set; }
}
