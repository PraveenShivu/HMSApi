using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Referrals")]
public partial class MReferral
{
    [Key]
    public int ReferrerId { get; set; }

    public int ReferrerType { get; set; }

    public int ReferrerTitle { get; set; }

    [StringLength(50)]
    public string ReferrerFirstName { get; set; } = null!;

    [StringLength(50)]
    public string? ReferrerMiddleName { get; set; }

    [StringLength(50)]
    public string? ReferrerLastName { get; set; }

    public int Gender { get; set; }

    [StringLength(50)]
    public string? Qualification { get; set; }

    [StringLength(150)]
    public string Address1 { get; set; } = null!;

    public long AreaId { get; set; }

    [StringLength(10)]
    public string? Pin { get; set; }

    [StringLength(30)]
    public string? MobileNumber { get; set; }

    [StringLength(30)]
    public string? LandlineNumber { get; set; }

    [StringLength(80)]
    public string? EmailId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("AreaId")]
    [InverseProperty("MReferrals")]
    public virtual MArea Area { get; set; } = null!;

    [ForeignKey("Gender")]
    [InverseProperty("MReferralGenderNavigations")]
    public virtual MGeneralLookup GenderNavigation { get; set; } = null!;

    [ForeignKey("ReferrerTitle")]
    [InverseProperty("MReferralReferrerTitleNavigations")]
    public virtual MGeneralLookup ReferrerTitleNavigation { get; set; } = null!;

    [ForeignKey("ReferrerType")]
    [InverseProperty("MReferralReferrerTypeNavigations")]
    public virtual MGeneralLookup ReferrerTypeNavigation { get; set; } = null!;
}
