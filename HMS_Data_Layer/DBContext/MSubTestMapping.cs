using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_SubTestMapping")]
public partial class MSubTestMapping
{
    [Key]
    [Column("SubTestMapID")]
    public long SubTestMapId { get; set; }

    [Column("MainTestID")]
    public long? MainTestId { get; set; }

    public long? SubTestId { get; set; }

    public int? TestOrder { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }
}
