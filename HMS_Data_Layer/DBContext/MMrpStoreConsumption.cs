using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_mrp_StoreConsumption")]
public partial class MMrpStoreConsumption
{
    [Key]
    public long StoreConsumptionId { get; set; }

    public long IssueStoreId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ConsumptionDate { get; set; }

    [StringLength(50)]
    public string ConsumptionRefNo { get; set; } = null!;

    [StringLength(200)]
    public string? Remarks { get; set; }

    [StringLength(50)]
    public string ConsumptionStatus { get; set; } = null!;

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

    [ForeignKey("IssueStoreId")]
    [InverseProperty("MMrpStoreConsumptions")]
    public virtual MMrpStore IssueStore { get; set; } = null!;

    [InverseProperty("StoreConsumption")]
    public virtual ICollection<MMrpStoreConsumptionLine> MMrpStoreConsumptionLines { get; set; } = new List<MMrpStoreConsumptionLine>();
}
