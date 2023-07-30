using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_States")]
[Index("StateCode", "CountryId", "CreatedDateTime", "ActiveFlag", Name = "uc_CountryStateCode", IsUnique = true)]
[Index("StateName", "StateCode", "CountryId", "CreatedDateTime", "ActiveFlag", Name = "uc_State", IsUnique = true)]
public partial class MState
{
    [Key]
    public int StateId { get; set; }

    [StringLength(50)]
    public string StateName { get; set; } = null!;

    [StringLength(5)]
    public string StateCode { get; set; } = null!;

    public int CountryId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("MStates")]
    public virtual MGeneralLookup Country { get; set; } = null!;

    [InverseProperty("State")]
    public virtual ICollection<MEnterprise> MEnterprises { get; set; } = new List<MEnterprise>();

    [InverseProperty("State")]
    public virtual ICollection<MFacility> MFacilities { get; set; } = new List<MFacility>();

    [InverseProperty("State")]
    public virtual ICollection<MPayerRegistration> MPayerRegistrations { get; set; } = new List<MPayerRegistration>();

    [InverseProperty("State")]
    public virtual ICollection<MPlace> MPlaces { get; set; } = new List<MPlace>();

    [InverseProperty("State")]
    public virtual ICollection<MVendor> MVendors { get; set; } = new List<MVendor>();
}
