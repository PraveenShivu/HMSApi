using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("HMS_Roles_Menu")]
public partial class HmsRolesMenu
{
    [Key]
    [Column("RoleMenu_Id")]
    public int RoleMenuId { get; set; }

    [Column("Role_Id")]
    public int RoleId { get; set; }

    [Column("Menu_Id")]
    public int MenuId { get; set; }

    [Column("Main_Menu_Tabs_Id")]
    public int? MainMenuTabsId { get; set; }

    public byte AccessStatus { get; set; }

    [ForeignKey("MainMenuTabsId")]
    [InverseProperty("HmsRolesMenus")]
    public virtual HmsMainMenuTab? MainMenuTabs { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("HmsRolesMenus")]
    public virtual HmsMainMenu Menu { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("HmsRolesMenus")]
    public virtual HmsRole Role { get; set; } = null!;
}
