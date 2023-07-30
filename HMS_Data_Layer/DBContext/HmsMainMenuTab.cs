using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("HMS_Main_Menu_Tabs")]
public partial class HmsMainMenuTab
{
    [Key]
    [Column("Main_Menu_Tabs_Id")]
    public int MainMenuTabsId { get; set; }

    [Column("Menu_Id")]
    public int MenuId { get; set; }

    [Column("Tab_Object_Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string TabObjectName { get; set; } = null!;

    [Column("Tab_Name")]
    [StringLength(50)]
    [Unicode(false)]
    public string TabName { get; set; } = null!;

    [InverseProperty("MainMenuTabs")]
    public virtual ICollection<HmsRolesMenu> HmsRolesMenus { get; set; } = new List<HmsRolesMenu>();

    [ForeignKey("MenuId")]
    [InverseProperty("HmsMainMenuTabs")]
    public virtual HmsMainMenu Menu { get; set; } = null!;
}
