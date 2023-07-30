using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ScreenField")]
public partial class MScreenField
{
    [Key]
    public long ScreenFieldId { get; set; }

    public long FieldId { get; set; }

    public int FacilityId { get; set; }

    public long ScreenId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MScreenFields")]
    public virtual MFacility Facility { get; set; } = null!;

    [ForeignKey("FieldId")]
    [InverseProperty("MScreenFields")]
    public virtual MField Field { get; set; } = null!;

    [ForeignKey("ScreenId")]
    [InverseProperty("MScreenFields")]
    public virtual MScreen Screen { get; set; } = null!;
}
