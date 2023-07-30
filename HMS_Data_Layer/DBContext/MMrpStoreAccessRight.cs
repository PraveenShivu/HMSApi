using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreAccessRights")]
public partial class MMrpStoreAccessRight
{
    [Key]
    public long StoreAccessRightId { get; set; }

    public long? StoreId { get; set; }

    public int? FeatureId { get; set; }

    public bool? IsApplicable { get; set; }

    public bool? IsSingleStage { get; set; }

    public bool? IsMultiStage { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? ActiveFlag { get; set; }

    [ForeignKey("FeatureId")]
    [InverseProperty("MMrpStoreAccessRights")]
    public virtual MGeneralLookup? Feature { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("MMrpStoreAccessRights")]
    public virtual MMrpStore? Store { get; set; }
}
