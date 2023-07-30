using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ProductClasssifcation")]
public partial class MProductClasssifcation
{
    [Key]
    public long ProductClassificationId { get; set; }

    public int ProductGroupId { get; set; }

    [StringLength(20)]
    public string ShortName { get; set; } = null!;

    [StringLength(50)]
    public string LongName { get; set; } = null!;

    [StringLength(100)]
    public string? Remarks { get; set; }

    public bool? Status { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("ProductClassification")]
    public virtual ICollection<MProductDefinition> MProductDefinitions { get; set; } = new List<MProductDefinition>();

    [ForeignKey("ProductGroupId")]
    [InverseProperty("MProductClasssifcations")]
    public virtual MGeneralLookup ProductGroup { get; set; } = null!;
}
