using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillBasePriceServices")]
public partial class MBillBasePriceService
{
    [Key]
    public int ServicePriceId { get; set; }

    public int BasePriceId { get; set; }

    public int? FacilityId { get; set; }

    public int ServiceId { get; set; }

    public bool? IsEditable { get; set; }

    public int Qty { get; set; }

    public int? Price { get; set; }

    public int? UomId { get; set; }

    public int? MinPrice { get; set; }

    public int? MaxPrice { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveTo { get; set; }

    public int? RevisionNo { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("BasePriceId")]
    [InverseProperty("MBillBasePriceServices")]
    public virtual MBillBasePrice BasePrice { get; set; } = null!;

    [ForeignKey("FacilityId")]
    [InverseProperty("MBillBasePriceServices")]
    public virtual MFacility? Facility { get; set; }

    [ForeignKey("ServiceId")]
    [InverseProperty("MBillBasePriceServices")]
    public virtual MBillService Service { get; set; } = null!;

    [ForeignKey("UomId")]
    [InverseProperty("MBillBasePriceServices")]
    public virtual MUom? Uom { get; set; }
}
