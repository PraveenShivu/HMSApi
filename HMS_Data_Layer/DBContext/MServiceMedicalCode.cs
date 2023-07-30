using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ServiceMedicalCodes")]
public partial class MServiceMedicalCode
{
    [Key]
    public int MedicalCodeId { get; set; }

    public int ServiceId { get; set; }

    public int MedicalCodeTypeId { get; set; }

    [StringLength(20)]
    public string? Version { get; set; }

    [StringLength(50)]
    public string? MedicalCodeTypeDescription { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("MedicalCodeTypeId")]
    [InverseProperty("MServiceMedicalCodes")]
    public virtual MGeneralLookup MedicalCodeType { get; set; } = null!;

    [ForeignKey("ServiceId")]
    [InverseProperty("MServiceMedicalCodes")]
    public virtual MBillService Service { get; set; } = null!;
}
