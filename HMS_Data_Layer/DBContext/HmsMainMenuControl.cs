using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("HMS_MainMenuControls")]
public partial class HmsMainMenuControl
{
    [Key]
    [Column("Main_Menu_Ctrl_Id")]
    public int MainMenuCtrlId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ActionName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ControllerName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MenuLogoPath { get; set; }

    [Column("Main_Menu_Id")]
    public int? MainMenuId { get; set; }

    [InverseProperty("MainMenuCtrl")]
    public virtual ICollection<HmsMainMenu> HmsMainMenus { get; set; } = new List<HmsMainMenu>();

    [ForeignKey("MainMenuId")]
    [InverseProperty("HmsMainMenuControls")]
    public virtual HmsMainMenu? MainMenu { get; set; }
}
