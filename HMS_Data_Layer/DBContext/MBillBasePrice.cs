using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_BillBasePrice")]
public partial class MBillBasePrice
{
    [Key]
    public int BasePriceId { get; set; }

    public int FacilityId { get; set; }

    [StringLength(20)]
    public string ShortName { get; set; } = null!;

    [StringLength(80)]
    public string LongName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    [StringLength(10)]
    public string Status { get; set; } = null!;

    [StringLength(200)]
    public string? Remarks { get; set; }

    [StringLength(50)]
    public string? AutorizedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AuthorizedDate { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("FacilityId")]
    [InverseProperty("MBillBasePrices")]
    public virtual MFacility Facility { get; set; } = null!;

    [InverseProperty("BasePrice")]
    public virtual ICollection<MBillBasePriceService> MBillBasePriceServices { get; set; } = new List<MBillBasePriceService>();
}
