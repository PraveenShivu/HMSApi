using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Frequency")]
public partial class TFrequency
{
    [Key]
    public int FrequencyId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FrequencyName { get; set; }

    public int FacilityId { get; set; }

    public int CountId { get; set; }

    public int CreatedBy { get; set; }

    public int ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Modifieddate { get; set; }

    public bool? Frequencystatus { get; set; }

    public string? LocalLang { get; set; }
}
