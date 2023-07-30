using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Ward")]
public partial class MWard
{
    [Key]
    public long WardId { get; set; }

    [StringLength(20)]
    public string WardShortName { get; set; } = null!;

    [StringLength(50)]
    public string? WardName { get; set; }

    public int? ServiceLocationId { get; set; }

    public int? WardCategoryId { get; set; }

    public int? Gender { get; set; }

    public int? FacilityId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("Gender")]
    [InverseProperty("MWardGenderNavigations")]
    public virtual MGeneralLookup? GenderNavigation { get; set; }

    [InverseProperty("Ward")]
    public virtual ICollection<MBed> MBeds { get; set; } = new List<MBed>();

    [InverseProperty("Ward")]
    public virtual ICollection<TEncounter> TEncounters { get; set; } = new List<TEncounter>();

    [ForeignKey("WardCategoryId")]
    [InverseProperty("MWardWardCategories")]
    public virtual MGeneralLookup? WardCategory { get; set; }
}
