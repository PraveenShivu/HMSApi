using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ContainerDefinition")]
public partial class MContainerDefinition
{
    [Key]
    [Column("CDID")]
    public long Cdid { get; set; }

    [StringLength(100)]
    public string? ContainerName { get; set; }

    [StringLength(100)]
    public string? ValuesName { get; set; }

    public bool IsActive { get; set; }

    public long? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    public long? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }
}
