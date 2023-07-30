using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_AntenatalVitalHeader")]
public partial class TAntenatalVitalHeader
{
    [Key]
    [Column("AVHeaderId")]
    public int AvheaderId { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    [Column("LMP", TypeName = "datetime")]
    public DateTime? Lmp { get; set; }

    [Column("EDD", TypeName = "datetime")]
    public DateTime? Edd { get; set; }

    [Column("EGAWeeks")]
    public int? Egaweeks { get; set; }

    [Column("EGADays")]
    public int? Egadays { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TotalPrevPreg { get; set; }

    public int? NuOfAlive { get; set; }

    public int? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(100)]
    public string? HeartDisease { get; set; }

    [StringLength(100)]
    public string? Diabetes { get; set; }

    [StringLength(100)]
    public string? Hypertension { get; set; }

    [StringLength(100)]
    public string? SickleCell { get; set; }

    [StringLength(100)]
    public string? Operations { get; set; }

    [StringLength(100)]
    public string? ChestDisease { get; set; }

    [StringLength(100)]
    public string? KidneyDisease { get; set; }

    [StringLength(100)]
    public string? Allergy { get; set; }

    [StringLength(100)]
    public string? Others { get; set; }

    [StringLength(100)]
    public string? PrimaryAssessment { get; set; }

    [Column("PADate", TypeName = "datetime")]
    public DateTime? Padate { get; set; }
}
