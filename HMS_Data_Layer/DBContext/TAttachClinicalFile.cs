using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("t_AttachClinicalFiles")]
public partial class TAttachClinicalFile
{
    [Key]
    public int FileId { get; set; }

    [StringLength(50)]
    public string UhId { get; set; } = null!;

    [StringLength(50)]
    public string? Encounter { get; set; }

    public long EncounterId { get; set; }

    public int ClinicalDocumentTypeId { get; set; }

    [StringLength(50)]
    public string? ClinicalDocumentTypeName { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Extension { get; set; }
}
