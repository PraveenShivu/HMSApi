using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_TestMethods")]
public partial class MTestMethod
{
    [Key]
    [Column("TestMethodID")]
    public long TestMethodId { get; set; }

    [Column("TestID")]
    public long TestId { get; set; }

    [StringLength(200)]
    public string? MethodName { get; set; }

    [StringLength(200)]
    public string? Unit { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }
}
