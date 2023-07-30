using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ProductOrdering")]
public partial class MProductOrdering
{
    [Key]
    public long ProductOrderAttrId { get; set; }

    public long ProductId { get; set; }

    public int Gender { get; set; }

    public int StartAge { get; set; }

    [Column("StartAgeUOM")]
    public int StartAgeUom { get; set; }

    public int? EndAge { get; set; }

    [Column("EndAgeUOM")]
    public int EndAgeUom { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("EndAgeUom")]
    [InverseProperty("MProductOrderingEndAgeUomNavigations")]
    public virtual MUom EndAgeUomNavigation { get; set; } = null!;

    [ForeignKey("Gender")]
    [InverseProperty("MProductOrderings")]
    public virtual MGeneralLookup GenderNavigation { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("MProductOrderings")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("StartAgeUom")]
    [InverseProperty("MProductOrderingStartAgeUomNavigations")]
    public virtual MUom StartAgeUomNavigation { get; set; } = null!;
}
