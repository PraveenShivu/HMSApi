using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Keyless]
[Table("Prod")]
public partial class Prod
{
    public long? ProId { get; set; }

    [Column("serialization")]
    [StringLength(30)]
    public string? Serialization { get; set; }

    [StringLength(30)]
    public string? BarcodeApplicability { get; set; }

    [Column("activeFlag")]
    [StringLength(10)]
    public string? ActiveFlag { get; set; }

    [StringLength(30)]
    public string? IsConsumAllow { get; set; }
}
