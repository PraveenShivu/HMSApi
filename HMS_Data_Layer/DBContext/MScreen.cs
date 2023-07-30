using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Screen")]
public partial class MScreen
{
    [Key]
    public long ScreenId { get; set; }

    [StringLength(255)]
    public string? ScreenName { get; set; }

    [StringLength(255)]
    public string? ScreenDescription { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(50)]
    public string? Controller { get; set; }

    [StringLength(50)]
    public string? Action { get; set; }

    [InverseProperty("Screen")]
    public virtual ICollection<MScreenField> MScreenFields { get; set; } = new List<MScreenField>();

    [InverseProperty("Screen")]
    public virtual ICollection<MWorkFlowScreen> MWorkFlowScreens { get; set; } = new List<MWorkFlowScreen>();
}
