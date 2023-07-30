using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_PatientVitals")]
public partial class TPatientVital
{
    [StringLength(20)]
    public string? Time { get; set; }

    [StringLength(10)]
    public string? BloodPreasure { get; set; }

    [StringLength(10)]
    public string? Weight { get; set; }

    [StringLength(10)]
    public string? Position { get; set; }

    [StringLength(10)]
    public string? HeartRate { get; set; }

    [StringLength(10)]
    public string? Temperature { get; set; }

    [StringLength(20)]
    public string? Height { get; set; }

    [Column("EncounterID")]
    [StringLength(20)]
    public string EncounterId { get; set; } = null!;

    [Key]
    [Column("PatientVitalID")]
    public int PatientVitalId { get; set; }

    [Column("PatientID")]
    public int PatientId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    public bool ActiveFlag { get; set; }

    [Column("BND")]
    public bool Bnd { get; set; }

    [Column("WND")]
    public bool Wnd { get; set; }

    [Column("HND")]
    public bool Hnd { get; set; }

    [Column("TMND")]
    public bool Tmnd { get; set; }

    [Column("HEND")]
    public bool Hend { get; set; }

    [StringLength(100)]
    public string? TempReadingIn { get; set; }

    [StringLength(100)]
    public string? WtReadingIn { get; set; }

    [Column(TypeName = "date")]
    public DateTime? PvDate { get; set; }

    [StringLength(20)]
    public string? RespiratoryRate { get; set; }

    [StringLength(20)]
    public string? Oxygensaturation { get; set; }

    [Column("RND")]
    public bool Rnd { get; set; }

    [Column("OND")]
    public bool Ond { get; set; }
}
