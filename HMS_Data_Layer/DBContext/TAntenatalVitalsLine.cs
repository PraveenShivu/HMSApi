using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_AntenatalVitalsLine")]
public partial class TAntenatalVitalsLine
{
    [Key]
    [Column("AVLineId")]
    public int AvlineId { get; set; }

    [Column("AVHeaderId")]
    public int? AvheaderId { get; set; }

    public long? PatientId { get; set; }

    public long? EncounterId { get; set; }

    [Column("AntDOB", TypeName = "datetime")]
    public DateTime? AntDob { get; set; }

    public int? DurOfPreg { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? BirthWeight { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ComplInPreg { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ComplInLabour { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Pueperium { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Alive { get; set; }

    public int? AgeAtDeath { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CauseOfDeath { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public bool ActiveFlag { get; set; }
}
