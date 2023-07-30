using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ProductUOM")]
public partial class MProductUom
{
    [Key]
    public long UomId { get; set; }

    public long ProductId { get; set; }

    [Column("AlternateUOMUnits")]
    public int? AlternateUomunits { get; set; }

    [Column("AlternateUOM")]
    public int? AlternateUom { get; set; }

    [Column("EquivalentUOMUnits")]
    public int? EquivalentUomunits { get; set; }

    [Column("EquivalentUOM")]
    public int? EquivalentUom { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("AlternateUom")]
    [InverseProperty("MProductUomAlternateUomNavigations")]
    public virtual MUom? AlternateUomNavigation { get; set; }

    [ForeignKey("EquivalentUom")]
    [InverseProperty("MProductUomEquivalentUomNavigations")]
    public virtual MUom? EquivalentUomNavigation { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MProductUoms")]
    public virtual MProductDefinition Product { get; set; } = null!;
}
