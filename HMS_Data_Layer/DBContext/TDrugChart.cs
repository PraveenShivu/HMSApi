using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_DrugChart")]
public partial class TDrugChart
{
    [Key]
    public long DrugChartId { get; set; }

    public long? DrugId { get; set; }

    public int? Route { get; set; }

    public int? NurseInitial { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    public TimeSpan? Time { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? DrugName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    public int? Dose { get; set; }

    public int? CreatedBy { get; set; }

    public bool ActiveFlag { get; set; }

    public int? ModifiedBy { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    public int? UomId { get; set; }
}
