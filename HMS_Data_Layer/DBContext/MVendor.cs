using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Vendors")]
public partial class MVendor
{
    [Key]
    public long VendorId { get; set; }

    [StringLength(20)]
    public string ShortName { get; set; } = null!;

    [StringLength(50)]
    public string LongName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveTo { get; set; }

    [StringLength(50)]
    public string? ContactPerson { get; set; }

    [StringLength(20)]
    public string? VendorGroup { get; set; }

    public bool? IsSupplier { get; set; }

    public bool? IsManufacturer { get; set; }

    [StringLength(100)]
    public string AddrressLine1 { get; set; } = null!;

    [StringLength(100)]
    public string AddrressLine2 { get; set; } = null!;

    public long Area { get; set; }

    public long Place { get; set; }

    public int StateId { get; set; }

    public int CountryId { get; set; }

    [StringLength(10)]
    public string? PinCode { get; set; }

    [StringLength(30)]
    public string? MobileNo { get; set; }

    [StringLength(30)]
    public string? LandlineNo { get; set; }

    [StringLength(80)]
    public string? EmailId { get; set; }

    public int? CreditDays { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? FacilityId { get; set; }

    [ForeignKey("Area")]
    [InverseProperty("MVendors")]
    public virtual MArea AreaNavigation { get; set; } = null!;

    [ForeignKey("CountryId")]
    [InverseProperty("MVendors")]
    public virtual MGeneralLookup Country { get; set; } = null!;

    [InverseProperty("Supplier")]
    public virtual ICollection<MMrpGrnHeader> MMrpGrnHeaders { get; set; } = new List<MMrpGrnHeader>();

    [InverseProperty("Supplier")]
    public virtual ICollection<MMrpPoHeader> MMrpPoHeaders { get; set; } = new List<MMrpPoHeader>();

    [InverseProperty("Manufacturer")]
    public virtual ICollection<MProductDefinition> MProductDefinitions { get; set; } = new List<MProductDefinition>();

    [ForeignKey("Place")]
    [InverseProperty("MVendors")]
    public virtual MPlace PlaceNavigation { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("MVendors")]
    public virtual MState State { get; set; } = null!;
}
