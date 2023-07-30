using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillServiceClasssifcation")]
public partial class MBillServiceClasssifcation
{
    [Key]
    public int ServiceClassificationId { get; set; }

    public int ServiceGroupId { get; set; }

    public int FacilityId { get; set; }

    [StringLength(50)]
    public string ShortName { get; set; } = null!;

    [StringLength(100)]
    public string LongName { get; set; } = null!;

    [StringLength(10)]
    public string Status { get; set; } = null!;

    public int? OrderGroupId { get; set; }

    public int? PrintGroupId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(500)]
    public string? Remark { get; set; }

    public bool? GeneratedServiceShortName { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MBillServiceClasssifcations")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("ServiceClassification")]
    public virtual ICollection<MBillService> MBillServices { get; set; } = new List<MBillService>();

    [ForeignKey("OrderGroupId")]
    [InverseProperty("MBillServiceClasssifcationOrderGroups")]
    public virtual MGeneralLookup? OrderGroup { get; set; }

    [ForeignKey("PrintGroupId")]
    [InverseProperty("MBillServiceClasssifcationPrintGroups")]
    public virtual MGeneralLookup? PrintGroup { get; set; }

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("MBillServiceClasssifcationServiceGroups")]
    public virtual MGeneralLookup ServiceGroup { get; set; } = null!;

    [InverseProperty("ServiceClassification")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrders { get; set; } = new List<TPatientAccountOrder>();
}
