using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_LookupType")]
public partial class MLookupType
{
    [Key]
    [StringLength(50)]
    public string LookupType { get; set; } = null!;

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    public bool IsEditable { get; set; }

    [InverseProperty("LookupTypeNavigation")]
    public virtual ICollection<MGeneralLookup> MGeneralLookups { get; set; } = new List<MGeneralLookup>();
}
