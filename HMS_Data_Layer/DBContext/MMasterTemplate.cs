using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_MasterTemplates")]
public partial class MMasterTemplate
{
    [Key]
    [Column("TID")]
    public long Tid { get; set; }

    [Column("FacilityID")]
    public int? FacilityId { get; set; }

    [StringLength(200)]
    public string? TempName { get; set; }

    [Column("ProviderID")]
    public long? ProviderId { get; set; }

    [Column("TempGroupID")]
    public long? TempGroupId { get; set; }

    public string? TempData { get; set; }

    [Column("ServiceID")]
    public long? ServiceId { get; set; }

    public long? Createdby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public long? Modifiedby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? ActiveFlag { get; set; }

    public bool? IsLab { get; set; }

    public bool? IsRadiology { get; set; }
}
