using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Facility")]
public partial class MFacility
{
    [Key]
    public int FacilityId { get; set; }

    [StringLength(100)]
    public string FacilityName { get; set; } = null!;

    [StringLength(10)]
    public string FacilityCode { get; set; } = null!;

    [StringLength(100)]
    public string? AddressLine1 { get; set; }

    [StringLength(100)]
    public string? AddressLine2 { get; set; }

    public int StateId { get; set; }

    public long PlaceId { get; set; }

    public long AreaId { get; set; }

    [StringLength(10)]
    public string? PinCode { get; set; }

    [StringLength(50)]
    public string? ContactName { get; set; }

    [StringLength(30)]
    public string? PhoneNumber { get; set; }

    [StringLength(30)]
    public string? MobileNumber { get; set; }

    [StringLength(80)]
    public string? ContactEmail { get; set; }

    [StringLength(30)]
    public string? FaxNumber { get; set; }

    public long EnterpriseId { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(250)]
    public string? DateFormat { get; set; }

    [StringLength(250)]
    public string? TimeFormat { get; set; }

    public int? CountryId { get; set; }

    [StringLength(200)]
    public string? FacilityLogo { get; set; }

    [StringLength(200)]
    public string? FacilityPath { get; set; }

    [ForeignKey("AreaId")]
    [InverseProperty("MFacilities")]
    public virtual MArea Area { get; set; } = null!;

    [ForeignKey("CountryId")]
    [InverseProperty("MFacilities")]
    public virtual MGeneralLookup? Country { get; set; }

    [ForeignKey("EnterpriseId")]
    [InverseProperty("MFacilities")]
    public virtual MEnterprise Enterprise { get; set; } = null!;

    [InverseProperty("Facility")]
    public virtual ICollection<MBillAgreement> MBillAgreements { get; set; } = new List<MBillAgreement>();

    [InverseProperty("Facility")]
    public virtual ICollection<MBillAutoCharge> MBillAutoCharges { get; set; } = new List<MBillAutoCharge>();

    [InverseProperty("Facility")]
    public virtual ICollection<MBillBasePriceService> MBillBasePriceServices { get; set; } = new List<MBillBasePriceService>();

    [InverseProperty("Facility")]
    public virtual ICollection<MBillBasePrice> MBillBasePrices { get; set; } = new List<MBillBasePrice>();

    [InverseProperty("Facility")]
    public virtual ICollection<MBillChargeExceptionHeader> MBillChargeExceptionHeaders { get; set; } = new List<MBillChargeExceptionHeader>();

    [InverseProperty("Facility")]
    public virtual ICollection<MBillPriceTariff> MBillPriceTariffs { get; set; } = new List<MBillPriceTariff>();

    [InverseProperty("Facility")]
    public virtual ICollection<MBillServiceClasssifcation> MBillServiceClasssifcations { get; set; } = new List<MBillServiceClasssifcation>();

    [InverseProperty("Facility")]
    public virtual ICollection<MConfiguration> MConfigurations { get; set; } = new List<MConfiguration>();

    [InverseProperty("Facility")]
    public virtual ICollection<MFacilityDepartment> MFacilityDepartments { get; set; } = new List<MFacilityDepartment>();

    [InverseProperty("Facility")]
    public virtual ICollection<MFacilityWorkFlow> MFacilityWorkFlows { get; set; } = new List<MFacilityWorkFlow>();

    [InverseProperty("Facility")]
    public virtual ICollection<MMrpGrnHeader> MMrpGrnHeaders { get; set; } = new List<MMrpGrnHeader>();

    [InverseProperty("Facility")]
    public virtual ICollection<MMrpPoHeader> MMrpPoHeaders { get; set; } = new List<MMrpPoHeader>();

    [InverseProperty("Facility")]
    public virtual ICollection<MMrpStore> MMrpStores { get; set; } = new List<MMrpStore>();

    [InverseProperty("Facility")]
    public virtual ICollection<MMrpStoresProduct> MMrpStoresProducts { get; set; } = new List<MMrpStoresProduct>();

    [InverseProperty("Facility")]
    public virtual ICollection<MPatientAccountAdditionalCharge> MPatientAccountAdditionalCharges { get; set; } = new List<MPatientAccountAdditionalCharge>();

    [InverseProperty("Facility")]
    public virtual ICollection<MPatientDischargeClearanceSetUp> MPatientDischargeClearanceSetUps { get; set; } = new List<MPatientDischargeClearanceSetUp>();

    [InverseProperty("Facility")]
    public virtual ICollection<MScheduleAvailabilityCalendar> MScheduleAvailabilityCalendars { get; set; } = new List<MScheduleAvailabilityCalendar>();

    [InverseProperty("Facility")]
    public virtual ICollection<MScheduleFacilityHoliday> MScheduleFacilityHolidays { get; set; } = new List<MScheduleFacilityHoliday>();

    [InverseProperty("Facility")]
    public virtual ICollection<MScheduleProviderAbsence> MScheduleProviderAbsences { get; set; } = new List<MScheduleProviderAbsence>();

    [InverseProperty("Facility")]
    public virtual ICollection<MScheduleProvider> MScheduleProviders { get; set; } = new List<MScheduleProvider>();

    [InverseProperty("Facility")]
    public virtual ICollection<MScheduleSpecialEvent> MScheduleSpecialEvents { get; set; } = new List<MScheduleSpecialEvent>();

    [InverseProperty("Facility")]
    public virtual ICollection<MScheduleTemplateSession> MScheduleTemplateSessions { get; set; } = new List<MScheduleTemplateSession>();

    [InverseProperty("Facility")]
    public virtual ICollection<MScheduleTemplate> MScheduleTemplates { get; set; } = new List<MScheduleTemplate>();

    [InverseProperty("Facility")]
    public virtual ICollection<MScreenField> MScreenFields { get; set; } = new List<MScreenField>();

    [InverseProperty("Facility")]
    public virtual ICollection<MUser> MUsers { get; set; } = new List<MUser>();

    [ForeignKey("PlaceId")]
    [InverseProperty("MFacilities")]
    public virtual MPlace Place { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("MFacilities")]
    public virtual MState State { get; set; } = null!;

    [InverseProperty("Facility")]
    public virtual ICollection<TEncounter> TEncounters { get; set; } = new List<TEncounter>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientAccountAssignedPlan> TPatientAccountAssignedPlans { get; set; } = new List<TPatientAccountAssignedPlan>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientAccountBill> TPatientAccountBills { get; set; } = new List<TPatientAccountBill>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientAccountChargeAttribute> TPatientAccountChargeAttributes { get; set; } = new List<TPatientAccountChargeAttribute>();

    [InverseProperty("Facillity")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountChargeFacillities { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("PerformingFacility")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountChargePerformingFacilities { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientAccountDefaultTariff> TPatientAccountDefaultTariffs { get; set; } = new List<TPatientAccountDefaultTariff>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientAccountDepositDefinition> TPatientAccountDepositDefinitions { get; set; } = new List<TPatientAccountDepositDefinition>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientAccountLedger> TPatientAccountLedgers { get; set; } = new List<TPatientAccountLedger>();

    [InverseProperty("OrderingFacility")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrderOrderingFacilities { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("PerformingFacility")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrderPerformingFacilities { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientAccountProcedureCharge> TPatientAccountProcedureCharges { get; set; } = new List<TPatientAccountProcedureCharge>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientAccountRecurringCharge> TPatientAccountRecurringCharges { get; set; } = new List<TPatientAccountRecurringCharge>();

    [InverseProperty("Facility")]
    public virtual ICollection<TPatientDischargeClearance> TPatientDischargeClearances { get; set; } = new List<TPatientDischargeClearance>();

    [InverseProperty("Facility")]
    public virtual ICollection<TQueue> TQueues { get; set; } = new List<TQueue>();

    [InverseProperty("Facility")]
    public virtual ICollection<TScheduleProviderAppointment> TScheduleProviderAppointments { get; set; } = new List<TScheduleProviderAppointment>();
}
