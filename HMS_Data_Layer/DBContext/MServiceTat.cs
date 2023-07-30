using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ServiceTat")]
public partial class MServiceTat
{
    [Key]
    public int TatId { get; set; }

    public int ServiceId { get; set; }

    [StringLength(10)]
    public string OrderPriorityId { get; set; } = null!;

    public int? TatValue { get; set; }

    public int? TatUom { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("ServiceId")]
    [InverseProperty("MServiceTats")]
    public virtual MBillService Service { get; set; } = null!;

    [ForeignKey("TatUom")]
    [InverseProperty("MServiceTats")]
    public virtual MUom? TatUomNavigation { get; set; }
}
