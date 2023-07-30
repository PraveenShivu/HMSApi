using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_UOM")]
public partial class MUom
{
    [Key]
    [Column("UOMId")]
    public int Uomid { get; set; }

    [StringLength(20)]
    public string ShortName { get; set; } = null!;

    [StringLength(100)]
    public string LongName { get; set; } = null!;

    public bool ActiveFlag { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    [InverseProperty("Uom")]
    public virtual ICollection<MBillBasePriceService> MBillBasePriceServices { get; set; } = new List<MBillBasePriceService>();

    [InverseProperty("ExecutionUomServiceDurationNavigation")]
    public virtual ICollection<MBillService> MBillServiceExecutionUomServiceDurationNavigations { get; set; } = new List<MBillService>();

    [InverseProperty("Uom")]
    public virtual ICollection<MBillService> MBillServiceUoms { get; set; } = new List<MBillService>();

    [InverseProperty("Uom")]
    public virtual ICollection<MMrpGrnLine> MMrpGrnLines { get; set; } = new List<MMrpGrnLine>();

    [InverseProperty("Uom")]
    public virtual ICollection<MMrpIndentIssueLine> MMrpIndentIssueLines { get; set; } = new List<MMrpIndentIssueLine>();

    [InverseProperty("UomNavigation")]
    public virtual ICollection<MMrpPoLine> MMrpPoLines { get; set; } = new List<MMrpPoLine>();

    [InverseProperty("Uom")]
    public virtual ICollection<MMrpStockCurrent> MMrpStockCurrents { get; set; } = new List<MMrpStockCurrent>();

    [InverseProperty("Uom")]
    public virtual ICollection<MMrpStoreConsumptionLine> MMrpStoreConsumptionLines { get; set; } = new List<MMrpStoreConsumptionLine>();

    [InverseProperty("Uom")]
    public virtual ICollection<MMrpStoreIndentLine> MMrpStoreIndentLines { get; set; } = new List<MMrpStoreIndentLine>();

    [InverseProperty("Uom")]
    public virtual ICollection<MMrpStoreIndentReceiptLine> MMrpStoreIndentReceiptLines { get; set; } = new List<MMrpStoreIndentReceiptLine>();

    [InverseProperty("Uom")]
    public virtual ICollection<MMrpStoreOpeningStockLine> MMrpStoreOpeningStockLines { get; set; } = new List<MMrpStoreOpeningStockLine>();

    [InverseProperty("OrderUomNavigation")]
    public virtual ICollection<MProductDefinition> MProductDefinitionOrderUomNavigations { get; set; } = new List<MProductDefinition>();

    [InverseProperty("UomprimaryUomNavigation")]
    public virtual ICollection<MProductDefinition> MProductDefinitionUomprimaryUomNavigations { get; set; } = new List<MProductDefinition>();

    [InverseProperty("EndAgeUomNavigation")]
    public virtual ICollection<MProductOrdering> MProductOrderingEndAgeUomNavigations { get; set; } = new List<MProductOrdering>();

    [InverseProperty("StartAgeUomNavigation")]
    public virtual ICollection<MProductOrdering> MProductOrderingStartAgeUomNavigations { get; set; } = new List<MProductOrdering>();

    [InverseProperty("AlternateUomNavigation")]
    public virtual ICollection<MProductUom> MProductUomAlternateUomNavigations { get; set; } = new List<MProductUom>();

    [InverseProperty("EquivalentUomNavigation")]
    public virtual ICollection<MProductUom> MProductUomEquivalentUomNavigations { get; set; } = new List<MProductUom>();

    [InverseProperty("StorageUomNavigation")]
    public virtual ICollection<MServiceLabAttribute> MServiceLabAttributeStorageUomNavigations { get; set; } = new List<MServiceLabAttribute>();

    [InverseProperty("VolumeUomNavigation")]
    public virtual ICollection<MServiceLabAttribute> MServiceLabAttributeVolumeUomNavigations { get; set; } = new List<MServiceLabAttribute>();

    [InverseProperty("EndAgeUomNavigation")]
    public virtual ICollection<MServiceOrdering> MServiceOrderingEndAgeUomNavigations { get; set; } = new List<MServiceOrdering>();

    [InverseProperty("StartAgeUomNavigation")]
    public virtual ICollection<MServiceOrdering> MServiceOrderingStartAgeUomNavigations { get; set; } = new List<MServiceOrdering>();

    [InverseProperty("ServiceUomNavigation")]
    public virtual ICollection<MServicePackage> MServicePackages { get; set; } = new List<MServicePackage>();

    [InverseProperty("TatUomNavigation")]
    public virtual ICollection<MServiceTat> MServiceTats { get; set; } = new List<MServiceTat>();

    [InverseProperty("ServiceUomNavigation")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountCharges { get; set; } = new List<TPatientAccountCharge>();
}
