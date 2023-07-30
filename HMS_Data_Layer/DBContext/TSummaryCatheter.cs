using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SummaryCatheters")]
public partial class TSummaryCatheter
{
    [Key]
    public int CathetersId { get; set; }

    public int CathetersDrainsId { get; set; }

    [Column("CathetersDrainsSiteID")]
    [StringLength(10)]
    public string? CathetersDrainsSiteId { get; set; }

    public int? CollectionDeviceId { get; set; }

    public int? InsertedById { get; set; }

    [Column("RemovedByID")]
    public int? RemovedById { get; set; }

    public int? PresentId { get; set; }

    public int? RemovedId { get; set; }

    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool ActiveFlag { get; set; }

    [Column("ProcedureID")]
    public int ProcedureId { get; set; }

    public int EncounterId { get; set; }

    public int PatientId { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedOn { get; set; }
}
