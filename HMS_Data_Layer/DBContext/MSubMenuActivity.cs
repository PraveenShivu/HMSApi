using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_SubMenu_Activity")]
public partial class MSubMenuActivity
{
    [Key]
    public int SubMenuId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SubMenuName { get; set; }

    public int? MenuId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MenuName { get; set; }

    public int? ActivityId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ActivityName { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    public bool? IsActive { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("MSubMenuActivities")]
    public virtual MMenu? Menu { get; set; }
}
