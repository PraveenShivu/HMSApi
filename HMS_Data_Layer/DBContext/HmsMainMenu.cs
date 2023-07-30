using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("HMS_MainMenu")]
public partial class HmsMainMenu
{
    [Key]
    [Column("Main_Menu_Id")]
    public int MainMenuId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string MenuName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MenuObjectName { get; set; } = null!;

    [Column("Parent_Id")]
    public int? ParentId { get; set; }

    [Column("Main_Menu_Ctrl_Id")]
    public int? MainMenuCtrlId { get; set; }

    [InverseProperty("MainMenu")]
    public virtual ICollection<HmsMainMenuControl> HmsMainMenuControls { get; set; } = new List<HmsMainMenuControl>();

    [InverseProperty("Menu")]
    public virtual ICollection<HmsMainMenuTab> HmsMainMenuTabs { get; set; } = new List<HmsMainMenuTab>();

    [InverseProperty("Menu")]
    public virtual ICollection<HmsRolesMenu> HmsRolesMenus { get; set; } = new List<HmsRolesMenu>();

    [ForeignKey("MainMenuCtrlId")]
    [InverseProperty("HmsMainMenus")]
    public virtual HmsMainMenuControl? MainMenuCtrl { get; set; }
}
