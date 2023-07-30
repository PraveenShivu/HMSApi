using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_PoDelivery")]
public partial class MMrpPoDelivery
{
    [Key]
    public int PoDeliveryId { get; set; }

    public long? PoLineId { get; set; }

    public int? DeliveryQuantity { get; set; }

    public int? Uom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [StringLength(30)]
    public string? DeliveryLocation { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("PoLineId")]
    [InverseProperty("MMrpPoDeliveries")]
    public virtual MMrpPoLine? PoLine { get; set; }
}
