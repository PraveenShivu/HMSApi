using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_Seq_t_User")]
public partial class TSeqTUser
{
    [Key]
    [Column("PKID")]
    public int Pkid { get; set; }

    public int Seed { get; set; }

    public int Incr { get; set; }

    public long? Currval { get; set; }
}
