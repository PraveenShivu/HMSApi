using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ServicePackage")]
public partial class MServicePackage
{
    [Key]
    public int ServicePackageId { get; set; }

    public int ServiceId { get; set; }

    public int IndicatorId { get; set; }

    public int DescriptionId { get; set; }

    [StringLength(1)]
    public string IsExcluded { get; set; } = null!;

    [StringLength(1)]
    public string IsReplaceable { get; set; } = null!;

    public int? ReplaceableDescriptionId { get; set; }

    public int MaxQty { get; set; }

    public int ServiceUom { get; set; }

    [StringLength(1)]
    public string Preference { get; set; } = null!;

    public int PkgPrice { get; set; }

    [StringLength(1)]
    public string AllowFund { get; set; } = null!;

    public int? MaximunRefundAmount { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? MaxAmount { get; set; }

    [ForeignKey("IndicatorId")]
    [InverseProperty("MServicePackages")]
    public virtual MGeneralLookup Indicator { get; set; } = null!;

    [ForeignKey("ServiceId")]
    [InverseProperty("MServicePackages")]
    public virtual MBillService Service { get; set; } = null!;

    [ForeignKey("ServiceUom")]
    [InverseProperty("MServicePackages")]
    public virtual MUom ServiceUomNavigation { get; set; } = null!;
}
