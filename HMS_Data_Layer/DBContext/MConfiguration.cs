using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Configuration")]
public partial class MConfiguration
{
    [Key]
    public int ConfigurationId { get; set; }

    public int FacilityId { get; set; }

    [StringLength(15)]
    public string GenerateIdFor { get; set; } = null!;

    [StringLength(1)]
    public string IsSimpleNumber { get; set; } = null!;

    [StringLength(10)]
    public string? IdPrefix { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? IdSuffix { get; set; }

    public int? IdIncrement { get; set; }

    public long? IdLastNumber { get; set; }

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
    [InverseProperty("MConfigurations")]
    public virtual MFacility Facility { get; set; } = null!;
}
