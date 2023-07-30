using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Clinical_Line_Advice")]
public partial class TClinicalLineAdvice
{
    [Key]
    [Column("ADLineID")]
    public int AdlineId { get; set; }

    [Column("ADID")]
    public int? Adid { get; set; }

    [Column("ICD_Code")]
    public long? IcdCode { get; set; }

    [Column("ICD_Desc")]
    public string? IcdDesc { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedOn { get; set; }

    public bool? ActiveFlag { get; set; }
}
