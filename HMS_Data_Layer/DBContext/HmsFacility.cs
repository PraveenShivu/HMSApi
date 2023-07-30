using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("HMS_Facilitys")]
public partial class HmsFacility
{
    [Key]
    public int FacilityId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FacilityName { get; set; }

    public byte IsActive { get; set; }

    [Column("Created_Date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("Created_By")]
    public int? CreatedBy { get; set; }

    [Column("Updated_Date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("Updated_By")]
    public int? UpdatedBy { get; set; }

    [ForeignKey("CreatedBy")]
    [InverseProperty("HmsFacilityCreatedByNavigations")]
    public virtual HmsAppUser? CreatedByNavigation { get; set; }

    [ForeignKey("UpdatedBy")]
    [InverseProperty("HmsFacilityUpdatedByNavigations")]
    public virtual HmsAppUser? UpdatedByNavigation { get; set; }
}
