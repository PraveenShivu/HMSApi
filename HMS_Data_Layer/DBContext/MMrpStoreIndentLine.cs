using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreIndentLine")]
public partial class MMrpStoreIndentLine
{
    [Key]
    public long IndentLineId { get; set; }

    public long IndentId { get; set; }

    public long ProductId { get; set; }

    public int UomId { get; set; }

    public int RequestQty { get; set; }

    public int? FullfilledQty { get; set; }

    public int? BalanceQty { get; set; }

    [StringLength(50)]
    public string? IndentLineStatus { get; set; }

    public bool? Favourite { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("IndentId")]
    [InverseProperty("MMrpStoreIndentLines")]
    public virtual MMrpStoreIndent Indent { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStoreIndentLines")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("UomId")]
    [InverseProperty("MMrpStoreIndentLines")]
    public virtual MUom Uom { get; set; } = null!;
}
