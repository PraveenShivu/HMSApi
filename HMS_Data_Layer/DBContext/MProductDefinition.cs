using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_ProductDefinition")]
public partial class MProductDefinition
{
    [Key]
    public long ProductId { get; set; }

    public long ProductClassificationId { get; set; }

    [StringLength(20)]
    public string ShortName { get; set; } = null!;

    [StringLength(50)]
    public string LongName { get; set; } = null!;

    [StringLength(1000)]
    public string? Remarks { get; set; }

    public long? ManufacturerId { get; set; }

    [StringLength(1)]
    public string? IsAtomic { get; set; }

    [StringLength(10)]
    public string Status { get; set; } = null!;

    [StringLength(30)]
    public string Sourcing { get; set; } = null!;

    [StringLength(30)]
    public string Expiry { get; set; } = null!;

    [StringLength(30)]
    public string TrackingMethod { get; set; } = null!;

    [StringLength(1)]
    public string? BillingIsChargeable { get; set; }

    [StringLength(30)]
    public string BillingPricingMethod { get; set; } = null!;

    [StringLength(1)]
    public string? BillingIsProviderMandatory { get; set; }

    [Column("UOMPrimaryUOM")]
    public int UomprimaryUom { get; set; }

    [Column("UOMDecimalPlaces")]
    public int? UomdecimalPlaces { get; set; }

    [StringLength(1)]
    public string? OrderIsOrderable { get; set; }

    [StringLength(1)]
    public string? OrderIsIntervalApplicable { get; set; }

    [StringLength(1)]
    public string? OrderIsQuantityApplicable { get; set; }

    public int? OrderDuration { get; set; }

    [Column("OrderUOM")]
    public int? OrderUom { get; set; }

    public int? OrderDefaultFrequency { get; set; }

    public int? OrderRoute { get; set; }

    [StringLength(1)]
    public string? OrderPatTypeCommercialPatient { get; set; }

    [StringLength(1)]
    public string? OrderPatTypeEmergency { get; set; }

    [StringLength(1)]
    public string? OrderPatTypeIp { get; set; }

    [StringLength(1)]
    public string? OrderPatTypeAmbulatory { get; set; }

    [StringLength(1)]
    public string? OrderPatTypeShortstay { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(50)]
    public string? HsnSac { get; set; }

    public int? FacilityId { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<MMrpGrnLine> MMrpGrnLines { get; set; } = new List<MMrpGrnLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpIndentIssueLine> MMrpIndentIssueLines { get; set; } = new List<MMrpIndentIssueLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpIndentIssuesPatientLine> MMrpIndentIssuesPatientLines { get; set; } = new List<MMrpIndentIssuesPatientLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpPoLine> MMrpPoLines { get; set; } = new List<MMrpPoLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStockCurrent> MMrpStockCurrents { get; set; } = new List<MMrpStockCurrent>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStockLedger> MMrpStockLedgers { get; set; } = new List<MMrpStockLedger>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStoreConsumptionLine> MMrpStoreConsumptionLines { get; set; } = new List<MMrpStoreConsumptionLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStoreIndentLine> MMrpStoreIndentLines { get; set; } = new List<MMrpStoreIndentLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStoreIndentReceiptBatch> MMrpStoreIndentReceiptBatches { get; set; } = new List<MMrpStoreIndentReceiptBatch>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStoreIndentReceiptLine> MMrpStoreIndentReceiptLines { get; set; } = new List<MMrpStoreIndentReceiptLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStoreOpeningStockBatch> MMrpStoreOpeningStockBatches { get; set; } = new List<MMrpStoreOpeningStockBatch>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStoreOpeningStockLine> MMrpStoreOpeningStockLines { get; set; } = new List<MMrpStoreOpeningStockLine>();

    [InverseProperty("Product")]
    public virtual ICollection<MMrpStoresProduct> MMrpStoresProducts { get; set; } = new List<MMrpStoresProduct>();

    [InverseProperty("Product")]
    public virtual ICollection<MProductOrdering> MProductOrderings { get; set; } = new List<MProductOrdering>();

    [InverseProperty("Product")]
    public virtual ICollection<MProductStock> MProductStocks { get; set; } = new List<MProductStock>();

    [InverseProperty("Product")]
    public virtual ICollection<MProductUom> MProductUoms { get; set; } = new List<MProductUom>();

    [ForeignKey("ManufacturerId")]
    [InverseProperty("MProductDefinitions")]
    public virtual MVendor? Manufacturer { get; set; }

    [ForeignKey("OrderDefaultFrequency")]
    [InverseProperty("MProductDefinitionOrderDefaultFrequencyNavigations")]
    public virtual MGeneralLookup? OrderDefaultFrequencyNavigation { get; set; }

    [ForeignKey("OrderRoute")]
    [InverseProperty("MProductDefinitionOrderRouteNavigations")]
    public virtual MGeneralLookup? OrderRouteNavigation { get; set; }

    [ForeignKey("OrderUom")]
    [InverseProperty("MProductDefinitionOrderUomNavigations")]
    public virtual MUom? OrderUomNavigation { get; set; }

    [ForeignKey("ProductClassificationId")]
    [InverseProperty("MProductDefinitions")]
    public virtual MProductClasssifcation ProductClassification { get; set; } = null!;

    [ForeignKey("UomprimaryUom")]
    [InverseProperty("MProductDefinitionUomprimaryUomNavigations")]
    public virtual MUom UomprimaryUomNavigation { get; set; } = null!;
}
