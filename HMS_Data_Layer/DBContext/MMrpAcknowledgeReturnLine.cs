using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_AcknowledgeReturnLine")]
public partial class MMrpAcknowledgeReturnLine
{
    [Key]
    public long ReturnLineId { get; set; }

    public long ReturnHeaderId { get; set; }

    public long ProductId { get; set; }

    public int? UomId { get; set; }

    [StringLength(50)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    public int? ReturnQty { get; set; }

    public int? ReturnBonusQty { get; set; }

    public int? ReturnValue { get; set; }

    [StringLength(100)]
    public string? Remarks { get; set; }
}
