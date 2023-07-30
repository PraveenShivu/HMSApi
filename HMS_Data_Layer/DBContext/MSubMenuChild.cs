using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_SubMenu_Child")]
public partial class MSubMenuChild
{
    [Key]
    public int SubMenuChildId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SubMenuChildName { get; set; }

    public int? SubMenuId { get; set; }

    public int? MenuId { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    public bool? IsActive { get; set; }
}
