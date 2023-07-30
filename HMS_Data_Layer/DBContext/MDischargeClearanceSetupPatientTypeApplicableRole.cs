using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_DischargeClearanceSetupPatientTypeApplicableRoles")]
public partial class MDischargeClearanceSetupPatientTypeApplicableRole
{
    [Key]
    public long DischargeClearanceSetupPatientTypeApplicableRolesId { get; set; }

    public long? DischargeClearanceSetUpId { get; set; }

    public int? ApplicableRole { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? ActiveFlag { get; set; }
}
