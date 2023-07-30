using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ServiceOrdering")]
public partial class MServiceOrdering
{
    [Key]
    public int ServiceOrderAttributeId { get; set; }

    public int ServiceId { get; set; }

    public int Gender { get; set; }

    public int StartAge { get; set; }

    public int StartAgeUom { get; set; }

    public int? EndAge { get; set; }

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
    [InverseProperty("MServiceOrderingEndAgeUomNavigations")]
    public virtual MUom EndAgeUomNavigation { get; set; } = null!;

    [ForeignKey("Gender")]
    [InverseProperty("MServiceOrderings")]
    public virtual MGeneralLookup GenderNavigation { get; set; } = null!;

    [ForeignKey("ServiceId")]
    [InverseProperty("MServiceOrderings")]
    public virtual MBillService Service { get; set; } = null!;

    [ForeignKey("StartAgeUom")]
    [InverseProperty("MServiceOrderingStartAgeUomNavigations")]
    public virtual MUom StartAgeUomNavigation { get; set; } = null!;
}
