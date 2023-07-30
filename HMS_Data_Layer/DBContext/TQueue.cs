using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Queue")]
public partial class TQueue
{
    [Key]
    [Column("QId")]
    public long Qid { get; set; }

    public int FacilityId { get; set; }

    [Column("QDate", TypeName = "datetime")]
    public DateTime Qdate { get; set; }

    public int ServiceLocationId { get; set; }

    public int ProviderId { get; set; }

    [Column("QNo")]
    public int Qno { get; set; }

    public int TokenNo { get; set; }

    [StringLength(1)]
    public string CheckInType { get; set; } = null!;

    public long EncounterId { get; set; }

    public long PatientId { get; set; }

    [Column("QStatus")]
    public int Qstatus { get; set; }

    public int? DispositionType { get; set; }

    public TimeSpan? ConsultationStartTime { get; set; }

    [Column("QNoAtConsultation")]
    public int? QnoAtConsultation { get; set; }

    [Column("QInTime")]
    public TimeSpan? QinTime { get; set; }

    [Column("QOutTime")]
    public TimeSpan? QoutTime { get; set; }

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
    [InverseProperty("TQueues")]
    public virtual TEncounter Encounter { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("TQueues")]
    public virtual MFacility Facility { get; set; } = null!;
}
