using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Places")]
[Index("PlaceName", "StateId", "CreatedDateTime", "ActiveFlag", Name = "uc_Place", IsUnique = true)]
public partial class MPlace
{
    [Key]
    public long PlaceId { get; set; }

    [StringLength(50)]
    public string PlaceName { get; set; } = null!;

    public int StateId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [InverseProperty("Place")]
    public virtual ICollection<MArea> MAreas { get; set; } = new List<MArea>();

    [InverseProperty("Place")]
    public virtual ICollection<MEnterprise> MEnterprises { get; set; } = new List<MEnterprise>();

    [InverseProperty("Place")]
    public virtual ICollection<MFacility> MFacilities { get; set; } = new List<MFacility>();

    [InverseProperty("PlaceNavigation")]
    public virtual ICollection<MVendor> MVendors { get; set; } = new List<MVendor>();

    [ForeignKey("StateId")]
    [InverseProperty("MPlaces")]
    public virtual MState State { get; set; } = null!;
}
