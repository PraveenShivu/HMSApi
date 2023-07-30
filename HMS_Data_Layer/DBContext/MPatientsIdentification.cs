using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PatientsIdentification")]
public partial class MPatientsIdentification
{
    [Key]
    public long PatientIdentityId { get; set; }

    public long PatientId { get; set; }

    public int IdentificationId { get; set; }

    [StringLength(50)]
    public string IdNo { get; set; } = null!;

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("IdentificationId")]
    [InverseProperty("MPatientsIdentifications")]
    public virtual MGeneralLookup Identification { get; set; } = null!;

    [ForeignKey("PatientId")]
    [InverseProperty("MPatientsIdentifications")]
    public virtual MPatientsRegistration Patient { get; set; } = null!;
}
