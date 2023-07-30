using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Menu")]
public partial class MMenu
{
    [Key]
    public int MenuId { get; set; }

    [StringLength(50)]
    public string? MenuName { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    public bool? IsActive { get; set; }

    [InverseProperty("Menu")]
    public virtual ICollection<MSubMenuActivity> MSubMenuActivities { get; set; } = new List<MSubMenuActivity>();
}
