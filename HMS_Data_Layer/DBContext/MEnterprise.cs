using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Enterprise")]
public partial class MEnterprise
{
    [Key]
    public long EnterpriseId { get; set; }

    [StringLength(100)]
    public string EnterpriseName { get; set; } = null!;

    [StringLength(100)]
    public string? AddressLine1 { get; set; }

    [StringLength(100)]
    public string? AddressLine2 { get; set; }

    public int StateId { get; set; }

    public long PlaceId { get; set; }

    public long AreaId { get; set; }

    [StringLength(10)]
    public string? PinCode { get; set; }

    [StringLength(50)]
    public string? ContactName { get; set; }

    [StringLength(30)]
    public string? PhoneNumber { get; set; }

    [StringLength(30)]
    public string? MobileNumber { get; set; }

    [StringLength(80)]
    public string? ContactEmail { get; set; }

    [StringLength(30)]
    public string? FaxNumber { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public int? CountryId { get; set; }

    [ForeignKey("AreaId")]
    [InverseProperty("MEnterprises")]
    public virtual MArea Area { get; set; } = null!;

    [ForeignKey("CountryId")]
    [InverseProperty("MEnterprises")]
    public virtual MGeneralLookup? Country { get; set; }

    [InverseProperty("Enterprise")]
    public virtual ICollection<MFacility> MFacilities { get; set; } = new List<MFacility>();

    [ForeignKey("PlaceId")]
    [InverseProperty("MEnterprises")]
    public virtual MPlace Place { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("MEnterprises")]
    public virtual MState State { get; set; } = null!;
}
