using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_DischargeSummary")]
public partial class TDischargeSummary
{
    [Key]
    [Column("DischargeSummaryID")]
    public long DischargeSummaryId { get; set; }

    public long? PatientId { get; set; }

    public long? EncounterId { get; set; }

    [Unicode(false)]
    public string? DiaProcedure { get; set; }

    [Unicode(false)]
    public string? Symptoms { get; set; }

    [Unicode(false)]
    public string? HistoryAllergy { get; set; }

    [Unicode(false)]
    public string? ClinicalFinding { get; set; }

    [Unicode(false)]
    public string? CourseInHospital { get; set; }

    [Unicode(false)]
    public string? Advice { get; set; }

    public bool? FollowUpCheck { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FollowUpDate { get; set; }

    public bool? SurgeryCheck { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Surgery { get; set; }

    public bool? IsActive { get; set; }

    public bool? ActiveFlag { get; set; }

    public int? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    public int? FacilityId { get; set; }

    [Unicode(false)]
    public string? ChiefComplaint { get; set; }
}
