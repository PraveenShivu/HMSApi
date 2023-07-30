using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ServiceLabAttributes")]
public partial class MServiceLabAttribute
{
    [Key]
    public int LabAttributeId { get; set; }

    public int ServiceId { get; set; }

    public int? SpecimenPrepId { get; set; }

    [StringLength(1)]
    public string? IsFixativeRequired { get; set; }

    public int? ContainerTypeId { get; set; }

    public int? ContainerCapacity { get; set; }

    [StringLength(1)]
    public string? IsAdditiveRequired { get; set; }

    public int? MinimumValue { get; set; }

    public int? MaximumValue { get; set; }

    public int? VolumeUom { get; set; }

    public int? StoragePeriod { get; set; }

    public int? StorageUom { get; set; }

    public int? AdditionalContainerId { get; set; }

    public int? AdditionalContainerCapacity { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("AdditionalContainerId")]
    [InverseProperty("MServiceLabAttributeAdditionalContainers")]
    public virtual MGeneralLookup? AdditionalContainer { get; set; }

    [ForeignKey("ContainerTypeId")]
    [InverseProperty("MServiceLabAttributeContainerTypes")]
    public virtual MGeneralLookup? ContainerType { get; set; }

    [ForeignKey("ServiceId")]
    [InverseProperty("MServiceLabAttributes")]
    public virtual MBillService Service { get; set; } = null!;

    [ForeignKey("SpecimenPrepId")]
    [InverseProperty("MServiceLabAttributeSpecimenPreps")]
    public virtual MGeneralLookup? SpecimenPrep { get; set; }

    [ForeignKey("StorageUom")]
    [InverseProperty("MServiceLabAttributeStorageUomNavigations")]
    public virtual MUom? StorageUomNavigation { get; set; }

    [ForeignKey("VolumeUom")]
    [InverseProperty("MServiceLabAttributeVolumeUomNavigations")]
    public virtual MUom? VolumeUomNavigation { get; set; }
}
