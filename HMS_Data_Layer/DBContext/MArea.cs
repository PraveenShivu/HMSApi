using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Area")]
[Index("AreaName", "PlaceId", "CreatedDateTime", "ActiveFlag", Name = "uc_Area", IsUnique = true)]
public partial class MArea
{
    [Key]
    public long AreaId { get; set; }

    [StringLength(50)]
    public string AreaName { get; set; } = null!;

    public long PlaceId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("Area")]
    public virtual ICollection<MEnterprise> MEnterprises { get; set; } = new List<MEnterprise>();

    [InverseProperty("Area")]
    public virtual ICollection<MFacility> MFacilities { get; set; } = new List<MFacility>();

    [InverseProperty("PermanentArea")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationPermanentAreas { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("PresentArea")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationPresentAreas { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("PermanentArea")]
    public virtual ICollection<MProvider> MProviderPermanentAreas { get; set; } = new List<MProvider>();

    [InverseProperty("PresentArea")]
    public virtual ICollection<MProvider> MProviderPresentAreas { get; set; } = new List<MProvider>();

    [InverseProperty("Area")]
    public virtual ICollection<MReferral> MReferrals { get; set; } = new List<MReferral>();

    [InverseProperty("AreaNavigation")]
    public virtual ICollection<MVendor> MVendors { get; set; } = new List<MVendor>();

    [ForeignKey("PlaceId")]
    [InverseProperty("MAreas")]
    public virtual MPlace Place { get; set; } = null!;
}
