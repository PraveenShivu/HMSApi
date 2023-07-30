using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreIndentReceiptLine")]
public partial class MMrpStoreIndentReceiptLine
{
    [Key]
    public long IndentReceiptLineId { get; set; }

    public long IndentReceiptId { get; set; }

    public long ProductId { get; set; }

    public int UomId { get; set; }

    public int ReceiptQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("IndentReceiptId")]
    [InverseProperty("MMrpStoreIndentReceiptLines")]
    public virtual MMrpStoreIndentReceipt IndentReceipt { get; set; } = null!;

    [InverseProperty("IndentReceiptLine")]
    public virtual ICollection<MMrpStoreIndentReceiptBatch> MMrpStoreIndentReceiptBatches { get; set; } = new List<MMrpStoreIndentReceiptBatch>();

    [ForeignKey("ProductId")]
    [InverseProperty("MMrpStoreIndentReceiptLines")]
    public virtual MProductDefinition Product { get; set; } = null!;

    [ForeignKey("UomId")]
    [InverseProperty("MMrpStoreIndentReceiptLines")]
    public virtual MUom Uom { get; set; } = null!;
}
