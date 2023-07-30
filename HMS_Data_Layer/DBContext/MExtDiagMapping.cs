using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Ext_Diag_Mapping")]
public partial class MExtDiagMapping
{
    [Key]
    public long Mid { get; set; }

    [Column("W_TitleId")]
    public long? WTitleId { get; set; }

    [Column("K_TitleId")]
    public long? KTitleId { get; set; }

    [Column("W_AreaId")]
    public long? WAreaId { get; set; }

    [Column("K_AreaId")]
    public long? KAreaId { get; set; }

    [Column("W_CityId")]
    public long? WCityId { get; set; }

    [Column("K_DistrictId")]
    public long? KDistrictId { get; set; }

    [Column("W_StateId")]
    public long? WStateId { get; set; }

    [Column("K_StateId")]
    public long? KStateId { get; set; }

    [Column("W_ProviderId")]
    public long? WProviderId { get; set; }

    [Column("K_ConsultationId")]
    public long? KConsultationId { get; set; }

    [Column("W_ReferbyId")]
    public long? WReferbyId { get; set; }

    [Column("K_ReferbyId")]
    public long? KReferbyId { get; set; }

    [Column("W_ServiceId")]
    public long? WServiceId { get; set; }

    [Column("K_ServiceId")]
    public long? KServiceId { get; set; }
}
