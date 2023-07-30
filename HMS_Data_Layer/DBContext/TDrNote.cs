using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_DrNote")]
public partial class TDrNote
{
    [Key]
    public long DrNoteId { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    public TimeSpan? Time { get; set; }

    public string? DrNote { get; set; }

    public int? Createdby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public int? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool? ActiveFlag { get; set; }
}
