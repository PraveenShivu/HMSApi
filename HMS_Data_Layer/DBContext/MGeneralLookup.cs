using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_GeneralLookup")]
public partial class MGeneralLookup
{
    [Key]
    public int LookupId { get; set; }

    [StringLength(50)]
    public string LookupType { get; set; } = null!;

    [StringLength(50)]
    public string LookupDescription { get; set; } = null!;

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? Modified { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("LookupType")]
    [InverseProperty("MGeneralLookups")]
    public virtual MLookupType LookupTypeNavigation { get; set; } = null!;

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<MBillAgreementLine> MBillAgreementLineGenderNavigations { get; set; } = new List<MBillAgreementLine>();

    [InverseProperty("IndicatorNavigation")]
    public virtual ICollection<MBillAgreementLine> MBillAgreementLineIndicatorNavigations { get; set; } = new List<MBillAgreementLine>();

    [InverseProperty("NationalityNavigation")]
    public virtual ICollection<MBillAgreementLine> MBillAgreementLineNationalityNavigations { get; set; } = new List<MBillAgreementLine>();

    [InverseProperty("PatientType")]
    public virtual ICollection<MBillAgreementLine> MBillAgreementLinePatientTypes { get; set; } = new List<MBillAgreementLine>();

    [InverseProperty("WardType")]
    public virtual ICollection<MBillAgreementLine> MBillAgreementLineWardTypes { get; set; } = new List<MBillAgreementLine>();

    [InverseProperty("RestrictedAuthLimitTypeNavigation")]
    public virtual ICollection<MBillAgreement> MBillAgreementRestrictedAuthLimitTypeNavigations { get; set; } = new List<MBillAgreement>();

    [InverseProperty("RestrictedDeductibleTypeNavigation")]
    public virtual ICollection<MBillAgreement> MBillAgreementRestrictedDeductibleTypeNavigations { get; set; } = new List<MBillAgreement>();

    [InverseProperty("EncounterType")]
    public virtual ICollection<MBillAutoCharge> MBillAutoChargeEncounterTypes { get; set; } = new List<MBillAutoCharge>();

    [InverseProperty("PatientType")]
    public virtual ICollection<MBillAutoCharge> MBillAutoChargePatientTypes { get; set; } = new List<MBillAutoCharge>();

    [InverseProperty("IndicatorNavigation")]
    public virtual ICollection<MBillChargeExceptionLine> MBillChargeExceptionLineIndicatorNavigations { get; set; } = new List<MBillChargeExceptionLine>();

    [InverseProperty("PatientType")]
    public virtual ICollection<MBillChargeExceptionLine> MBillChargeExceptionLinePatientTypes { get; set; } = new List<MBillChargeExceptionLine>();

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<MBillPriceTariffLine> MBillPriceTariffLineGenderNavigations { get; set; } = new List<MBillPriceTariffLine>();

    [InverseProperty("IndicatorNavigation")]
    public virtual ICollection<MBillPriceTariffLine> MBillPriceTariffLineIndicatorNavigations { get; set; } = new List<MBillPriceTariffLine>();

    [InverseProperty("NationalityNavigation")]
    public virtual ICollection<MBillPriceTariffLine> MBillPriceTariffLineNationalityNavigations { get; set; } = new List<MBillPriceTariffLine>();

    [InverseProperty("PatientType")]
    public virtual ICollection<MBillPriceTariffLine> MBillPriceTariffLinePatientTypes { get; set; } = new List<MBillPriceTariffLine>();

    [InverseProperty("WardType")]
    public virtual ICollection<MBillPriceTariffLine> MBillPriceTariffLineWardTypes { get; set; } = new List<MBillPriceTariffLine>();

    [InverseProperty("OrderGroup")]
    public virtual ICollection<MBillServiceClasssifcation> MBillServiceClasssifcationOrderGroups { get; set; } = new List<MBillServiceClasssifcation>();

    [InverseProperty("PrintGroup")]
    public virtual ICollection<MBillServiceClasssifcation> MBillServiceClasssifcationPrintGroups { get; set; } = new List<MBillServiceClasssifcation>();

    [InverseProperty("ServiceGroup")]
    public virtual ICollection<MBillServiceClasssifcation> MBillServiceClasssifcationServiceGroups { get; set; } = new List<MBillServiceClasssifcation>();

    [InverseProperty("Category")]
    public virtual ICollection<MBillService> MBillServices { get; set; } = new List<MBillService>();

    [InverseProperty("Country")]
    public virtual ICollection<MEnterprise> MEnterprises { get; set; } = new List<MEnterprise>();

    [InverseProperty("Country")]
    public virtual ICollection<MFacility> MFacilities { get; set; } = new List<MFacility>();

    [InverseProperty("PatientType")]
    public virtual ICollection<MFacilityDepartmentPatientType> MFacilityDepartmentPatientTypes { get; set; } = new List<MFacilityDepartmentPatientType>();

    [InverseProperty("Equipment")]
    public virtual ICollection<MFacilityDepartmentServiceLocationEquipment> MFacilityDepartmentServiceLocationEquipments { get; set; } = new List<MFacilityDepartmentServiceLocationEquipment>();

    [InverseProperty("DocumentTypeNavigation")]
    public virtual ICollection<MMrpGrnHeader> MMrpGrnHeaders { get; set; } = new List<MMrpGrnHeader>();

    [InverseProperty("DocumentTypeNavigation")]
    public virtual ICollection<MMrpPoHeader> MMrpPoHeaders { get; set; } = new List<MMrpPoHeader>();

    [InverseProperty("Feature")]
    public virtual ICollection<MMrpStoreAccessRight> MMrpStoreAccessRights { get; set; } = new List<MMrpStoreAccessRight>();

    [InverseProperty("StockLocatorNavigation")]
    public virtual ICollection<MMrpStoresProduct> MMrpStoresProducts { get; set; } = new List<MMrpStoresProduct>();

    [InverseProperty("Indicator")]
    public virtual ICollection<MPatientAccountAdditionalChargesAssociation> MPatientAccountAdditionalChargesAssociations { get; set; } = new List<MPatientAccountAdditionalChargesAssociation>();

    [InverseProperty("AnesthesiaChargeType")]
    public virtual ICollection<MPatientAccountAdditionalChargesSurgery> MPatientAccountAdditionalChargesSurgeryAnesthesiaChargeTypes { get; set; } = new List<MPatientAccountAdditionalChargesSurgery>();

    [InverseProperty("AnesthesiaType")]
    public virtual ICollection<MPatientAccountAdditionalChargesSurgery> MPatientAccountAdditionalChargesSurgeryAnesthesiaTypes { get; set; } = new List<MPatientAccountAdditionalChargesSurgery>();

    [InverseProperty("ClearanceType")]
    public virtual ICollection<MPatientDischargeClearanceSetUp> MPatientDischargeClearanceSetUpClearanceTypes { get; set; } = new List<MPatientDischargeClearanceSetUp>();

    [InverseProperty("PatientType")]
    public virtual ICollection<MPatientDischargeClearanceSetUp> MPatientDischargeClearanceSetUpPatientTypes { get; set; } = new List<MPatientDischargeClearanceSetUp>();

    [InverseProperty("Identification")]
    public virtual ICollection<MPatientsIdentification> MPatientsIdentifications { get; set; } = new List<MPatientsIdentification>();

    [InverseProperty("BloodGroupNavigation")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationBloodGroupNavigations { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("Ethnicity")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationEthnicities { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("FhTitleNavigation")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationFhTitleNavigations { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationGenderNavigations { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationMaritalStatusNavigations { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("PatientTitleNavigation")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationPatientTitleNavigations { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("PrimaryLanguage")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationPrimaryLanguages { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("Religion")]
    public virtual ICollection<MPatientsRegistration> MPatientsRegistrationReligions { get; set; } = new List<MPatientsRegistration>();

    [InverseProperty("Identification")]
    public virtual ICollection<MPayerIdentification> MPayerIdentifications { get; set; } = new List<MPayerIdentification>();

    [InverseProperty("Country")]
    public virtual ICollection<MPayerRegistration> MPayerRegistrationCountries { get; set; } = new List<MPayerRegistration>();

    [InverseProperty("PayerType")]
    public virtual ICollection<MPayerRegistration> MPayerRegistrationPayerTypes { get; set; } = new List<MPayerRegistration>();

    [InverseProperty("ProductGroup")]
    public virtual ICollection<MProductClasssifcation> MProductClasssifcations { get; set; } = new List<MProductClasssifcation>();

    [InverseProperty("OrderDefaultFrequencyNavigation")]
    public virtual ICollection<MProductDefinition> MProductDefinitionOrderDefaultFrequencyNavigations { get; set; } = new List<MProductDefinition>();

    [InverseProperty("OrderRouteNavigation")]
    public virtual ICollection<MProductDefinition> MProductDefinitionOrderRouteNavigations { get; set; } = new List<MProductDefinition>();

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<MProductOrdering> MProductOrderings { get; set; } = new List<MProductOrdering>();

    [InverseProperty("DrugFormNavigation")]
    public virtual ICollection<MProductStock> MProductStocks { get; set; } = new List<MProductStock>();

    [InverseProperty("ConsultantType")]
    public virtual ICollection<MProvider> MProviderConsultantTypes { get; set; } = new List<MProvider>();

    [InverseProperty("Credential")]
    public virtual ICollection<MProviderCredential> MProviderCredentials { get; set; } = new List<MProviderCredential>();

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<MProvider> MProviderGenderNavigations { get; set; } = new List<MProvider>();

    [InverseProperty("Identification")]
    public virtual ICollection<MProviderIdentification> MProviderIdentifications { get; set; } = new List<MProviderIdentification>();

    [InverseProperty("ProviderTitleNavigation")]
    public virtual ICollection<MProvider> MProviderProviderTitleNavigations { get; set; } = new List<MProvider>();

    [InverseProperty("StructuralRole")]
    public virtual ICollection<MProvider> MProviderStructuralRoles { get; set; } = new List<MProvider>();

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<MReferral> MReferralGenderNavigations { get; set; } = new List<MReferral>();

    [InverseProperty("ReferrerTitleNavigation")]
    public virtual ICollection<MReferral> MReferralReferrerTitleNavigations { get; set; } = new List<MReferral>();

    [InverseProperty("ReferrerTypeNavigation")]
    public virtual ICollection<MReferral> MReferralReferrerTypeNavigations { get; set; } = new List<MReferral>();

    [InverseProperty("WeekDayFrequencyNavigation")]
    public virtual ICollection<MScheduleProvider> MScheduleProviderWeekDayFrequencyNavigations { get; set; } = new List<MScheduleProvider>();

    [InverseProperty("WeekDayNavigation")]
    public virtual ICollection<MScheduleProvider> MScheduleProviderWeekDayNavigations { get; set; } = new List<MScheduleProvider>();

    [InverseProperty("Weekday")]
    public virtual ICollection<MScheduleProvider> MScheduleProviderWeekdays { get; set; } = new List<MScheduleProvider>();

    [InverseProperty("AdditionalContainer")]
    public virtual ICollection<MServiceLabAttribute> MServiceLabAttributeAdditionalContainers { get; set; } = new List<MServiceLabAttribute>();

    [InverseProperty("ContainerType")]
    public virtual ICollection<MServiceLabAttribute> MServiceLabAttributeContainerTypes { get; set; } = new List<MServiceLabAttribute>();

    [InverseProperty("SpecimenPrep")]
    public virtual ICollection<MServiceLabAttribute> MServiceLabAttributeSpecimenPreps { get; set; } = new List<MServiceLabAttribute>();

    [InverseProperty("ServiceLocationType")]
    public virtual ICollection<MServiceLocation> MServiceLocations { get; set; } = new List<MServiceLocation>();

    [InverseProperty("MedicalCodeType")]
    public virtual ICollection<MServiceMedicalCode> MServiceMedicalCodes { get; set; } = new List<MServiceMedicalCode>();

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<MServiceOrdering> MServiceOrderings { get; set; } = new List<MServiceOrdering>();

    [InverseProperty("Indicator")]
    public virtual ICollection<MServicePackage> MServicePackages { get; set; } = new List<MServicePackage>();

    [InverseProperty("Country")]
    public virtual ICollection<MState> MStates { get; set; } = new List<MState>();

    [InverseProperty("Country")]
    public virtual ICollection<MVendor> MVendors { get; set; } = new List<MVendor>();

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<MWard> MWardGenderNavigations { get; set; } = new List<MWard>();

    [InverseProperty("WardCategory")]
    public virtual ICollection<MWard> MWardWardCategories { get; set; } = new List<MWard>();

    [InverseProperty("EncounterCancelReason")]
    public virtual ICollection<TEncounter> TEncounterEncounterCancelReasons { get; set; } = new List<TEncounter>();

    [InverseProperty("EncounterEditReason")]
    public virtual ICollection<TEncounter> TEncounterEncounterEditReasons { get; set; } = new List<TEncounter>();

    [InverseProperty("EncounterReason")]
    public virtual ICollection<TEncounter> TEncounterEncounterReasons { get; set; } = new List<TEncounter>();

    [InverseProperty("EncounterType")]
    public virtual ICollection<TEncounter> TEncounterEncounterTypes { get; set; } = new List<TEncounter>();

    [InverseProperty("PatientTypeNavigation")]
    public virtual ICollection<TEncounter> TEncounterPatientTypeNavigations { get; set; } = new List<TEncounter>();

    [InverseProperty("WardCategory")]
    public virtual ICollection<TEncounter> TEncounterWardCategories { get; set; } = new List<TEncounter>();

    [InverseProperty("EligibleWardType")]
    public virtual ICollection<TPatientAccountAssignedPlan> TPatientAccountAssignedPlans { get; set; } = new List<TPatientAccountAssignedPlan>();

    [InverseProperty("GenderNavigation")]
    public virtual ICollection<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLineGenderNavigations { get; set; } = new List<TPatientAccountAuthorizationLine>();

    [InverseProperty("IndicatorNavigation")]
    public virtual ICollection<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLineIndicatorNavigations { get; set; } = new List<TPatientAccountAuthorizationLine>();

    [InverseProperty("NationalityNavigation")]
    public virtual ICollection<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLineNationalityNavigations { get; set; } = new List<TPatientAccountAuthorizationLine>();

    [InverseProperty("PatientType")]
    public virtual ICollection<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLinePatientTypes { get; set; } = new List<TPatientAccountAuthorizationLine>();

    [InverseProperty("WardType")]
    public virtual ICollection<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLineWardTypes { get; set; } = new List<TPatientAccountAuthorizationLine>();

    [InverseProperty("WardTypeNavigation")]
    public virtual ICollection<TPatientAccountChargeAttribute> TPatientAccountChargeAttributes { get; set; } = new List<TPatientAccountChargeAttribute>();

    [InverseProperty("ChargeableWardTypeNavigation")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountChargeChargeableWardTypeNavigations { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("PatientType")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountChargePatientTypes { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("ServiceGroup")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountChargeServiceGroups { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("WardTypeNavigation")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountChargeWardTypeNavigations { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("PatientType")]
    public virtual ICollection<TPatientAccountDefaultTariff> TPatientAccountDefaultTariffs { get; set; } = new List<TPatientAccountDefaultTariff>();

    [InverseProperty("AccommodationTypeNavigation")]
    public virtual ICollection<TPatientAccountDepositDefinition> TPatientAccountDepositDefinitionAccommodationTypeNavigations { get; set; } = new List<TPatientAccountDepositDefinition>();

    [InverseProperty("PatientType")]
    public virtual ICollection<TPatientAccountDepositDefinition> TPatientAccountDepositDefinitionPatientTypes { get; set; } = new List<TPatientAccountDepositDefinition>();

    [InverseProperty("OrderStatusNavigation")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrderOrderStatusNavigations { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("PatientType")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrderPatientTypes { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("ServiceGroup")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrderServiceGroups { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("AnesthesiaTypeCharge")]
    public virtual ICollection<TPatientAccountProcedureCharge> TPatientAccountProcedureChargeAnesthesiaTypeCharges { get; set; } = new List<TPatientAccountProcedureCharge>();

    [InverseProperty("AnesthesiaType")]
    public virtual ICollection<TPatientAccountProcedureCharge> TPatientAccountProcedureChargeAnesthesiaTypes { get; set; } = new List<TPatientAccountProcedureCharge>();

    [InverseProperty("Indicator")]
    public virtual ICollection<TPatientAccountReceiptAllocation> TPatientAccountReceiptAllocationIndicators { get; set; } = new List<TPatientAccountReceiptAllocation>();

    [InverseProperty("PatientType")]
    public virtual ICollection<TPatientAccountReceiptAllocation> TPatientAccountReceiptAllocationPatientTypes { get; set; } = new List<TPatientAccountReceiptAllocation>();

    [InverseProperty("Bank")]
    public virtual ICollection<TPatientAccountReceiptInstrument> TPatientAccountReceiptInstrumentBanks { get; set; } = new List<TPatientAccountReceiptInstrument>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<TPatientAccountReceiptInstrument> TPatientAccountReceiptInstrumentPaymentTypes { get; set; } = new List<TPatientAccountReceiptInstrument>();

    [InverseProperty("PatientType")]
    public virtual ICollection<TPatientAccountRecurringCharge> TPatientAccountRecurringCharges { get; set; } = new List<TPatientAccountRecurringCharge>();

    [InverseProperty("CancelReasonNavigation")]
    public virtual ICollection<TPatientDischarge> TPatientDischargeCancelReasonNavigations { get; set; } = new List<TPatientDischarge>();

    [InverseProperty("ClearanceType")]
    public virtual ICollection<TPatientDischargeClearance> TPatientDischargeClearances { get; set; } = new List<TPatientDischargeClearance>();

    [InverseProperty("DispositionType")]
    public virtual ICollection<TPatientDischarge> TPatientDischargeDispositionTypes { get; set; } = new List<TPatientDischarge>();

    [InverseProperty("AppointmentReason")]
    public virtual ICollection<TScheduleProviderAppointment> TScheduleProviderAppointmentAppointmentReasons { get; set; } = new List<TScheduleProviderAppointment>();

    [InverseProperty("CancelAppointmentNavigation")]
    public virtual ICollection<TScheduleProviderAppointment> TScheduleProviderAppointmentCancelAppointmentNavigations { get; set; } = new List<TScheduleProviderAppointment>();

    [InverseProperty("TransferAppointmentNavigation")]
    public virtual ICollection<TScheduleProviderAppointment> TScheduleProviderAppointmentTransferAppointmentNavigations { get; set; } = new List<TScheduleProviderAppointment>();

    [InverseProperty("FromWardCategory")]
    public virtual ICollection<TTransaction> TTransactionFromWardCategories { get; set; } = new List<TTransaction>();

    [InverseProperty("ToWardCategory")]
    public virtual ICollection<TTransaction> TTransactionToWardCategories { get; set; } = new List<TTransaction>();
}
