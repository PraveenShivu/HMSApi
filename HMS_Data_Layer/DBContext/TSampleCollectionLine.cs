using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_SampleCollectionLine")]
public partial class TSampleCollectionLine
{
    [Key]
    public long SmpColLineId { get; set; }

    public long SmpColHeaderId { get; set; }

    [StringLength(100)]
    public string? Container1 { get; set; }

    [StringLength(100)]
    public string? Container2 { get; set; }

    [StringLength(100)]
    public string? Container3 { get; set; }

    [StringLength(100)]
    public string? Container4 { get; set; }

    [StringLength(100)]
    public string? Container5 { get; set; }

    [StringLength(100)]
    public string? Container6 { get; set; }

    [StringLength(100)]
    public string? Container7 { get; set; }

    [StringLength(100)]
    public string? Conatiner8 { get; set; }

    [StringLength(100)]
    public string? Container9 { get; set; }

    [StringLength(100)]
    public string? Container10 { get; set; }
}
