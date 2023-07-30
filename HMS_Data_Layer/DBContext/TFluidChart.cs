using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_FluidChart")]
public partial class TFluidChart
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    public TimeSpan? Time { get; set; }

    public int? NurseInitial { get; set; }

    public int? Fluidid { get; set; }

    public int? Route { get; set; }

    [StringLength(150)]
    public string? RouteData { get; set; }

    [StringLength(150)]
    public string? Rectal { get; set; }

    [StringLength(150)]
    public string? Urine { get; set; }

    [StringLength(150)]
    public string? Vomit { get; set; }

    [StringLength(150)]
    public string? Diarrhoea { get; set; }

    [StringLength(150)]
    public string? Suction { get; set; }

    [StringLength(50)]
    public string? Type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public int? CreatedBy { get; set; }

    public bool ActiveFlag { get; set; }

    public int? ModifiedBy { get; set; }

    public long PatientId { get; set; }

    public long EncounterId { get; set; }

    public int? InputUom { get; set; }

    public int? RectalUom { get; set; }

    public int? UrineUom { get; set; }

    public int? VomitUom { get; set; }

    public int? DiarrhoeaUom { get; set; }

    public int? SuctionUom { get; set; }
}
