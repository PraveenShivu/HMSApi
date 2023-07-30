using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

public partial class HMS_Api_DbContext : DbContext
{
    public HMS_Api_DbContext()
    {
    }

    public HMS_Api_DbContext(DbContextOptions<HMS_Api_DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DummyProvider> DummyProviders { get; set; }

    public virtual DbSet<HmsAppUser> HmsAppUsers { get; set; }

    public virtual DbSet<HmsAppUserRole> HmsAppUserRoles { get; set; }

    public virtual DbSet<HmsFacility> HmsFacilitys { get; set; }

    public virtual DbSet<HmsMainMenu> HmsMainMenus { get; set; }

    public virtual DbSet<HmsMainMenuControl> HmsMainMenuControls { get; set; }

    public virtual DbSet<HmsMainMenuTab> HmsMainMenuTabs { get; set; }

    public virtual DbSet<HmsRole> HmsRoles { get; set; }

    public virtual DbSet<HmsRolesMenu> HmsRolesMenus { get; set; }

    public virtual DbSet<MArea> MAreas { get; set; }

    public virtual DbSet<MBed> MBeds { get; set; }

    public virtual DbSet<MBillAgreement> MBillAgreements { get; set; }

    public virtual DbSet<MBillAgreementLine> MBillAgreementLines { get; set; }

    public virtual DbSet<MBillAutoCharge> MBillAutoCharges { get; set; }

    public virtual DbSet<MBillBasePrice> MBillBasePrices { get; set; }

    public virtual DbSet<MBillBasePriceService> MBillBasePriceServices { get; set; }

    public virtual DbSet<MBillChargeExceptionHeader> MBillChargeExceptionHeaders { get; set; }

    public virtual DbSet<MBillChargeExceptionLine> MBillChargeExceptionLines { get; set; }

    public virtual DbSet<MBillPriceTariff> MBillPriceTariffs { get; set; }

    public virtual DbSet<MBillPriceTariffLine> MBillPriceTariffLines { get; set; }

    public virtual DbSet<MBillService> MBillServices { get; set; }

    public virtual DbSet<MBillServiceClasssifcation> MBillServiceClasssifcations { get; set; }

    public virtual DbSet<MClinicalFlowChart> MClinicalFlowCharts { get; set; }

    public virtual DbSet<MClinicalSetup> MClinicalSetups { get; set; }

    public virtual DbSet<MConfiguration> MConfigurations { get; set; }

    public virtual DbSet<MContainerDefinition> MContainerDefinitions { get; set; }

    public virtual DbSet<MDepartment> MDepartments { get; set; }

    public virtual DbSet<MDischargeClearanceSetupPatientTypeApplicableRole> MDischargeClearanceSetupPatientTypeApplicableRoles { get; set; }

    public virtual DbSet<MEnterprise> MEnterprises { get; set; }

    public virtual DbSet<MExtDiagMapping> MExtDiagMappings { get; set; }

    public virtual DbSet<MFacility> MFacilities { get; set; }

    public virtual DbSet<MFacilityDepartment> MFacilityDepartments { get; set; }

    public virtual DbSet<MFacilityDepartmentPatientType> MFacilityDepartmentPatientTypes { get; set; }

    public virtual DbSet<MFacilityDepartmentProvider> MFacilityDepartmentProviders { get; set; }

    public virtual DbSet<MFacilityDepartmentServiceLocation> MFacilityDepartmentServiceLocations { get; set; }

    public virtual DbSet<MFacilityDepartmentServiceLocationEquipment> MFacilityDepartmentServiceLocationEquipments { get; set; }

    public virtual DbSet<MFacilityWorkFlow> MFacilityWorkFlows { get; set; }

    public virtual DbSet<MField> MFields { get; set; }

    public virtual DbSet<MGeneralLookup> MGeneralLookups { get; set; }

    public virtual DbSet<MLookupType> MLookupTypes { get; set; }

    public virtual DbSet<MMasterTemplate> MMasterTemplates { get; set; }

    public virtual DbSet<MMenu> MMenus { get; set; }

    public virtual DbSet<MMrpAcknowledgeReturnHeader> MMrpAcknowledgeReturnHeaders { get; set; }

    public virtual DbSet<MMrpAcknowledgeReturnLine> MMrpAcknowledgeReturnLines { get; set; }

    public virtual DbSet<MMrpGrnBatch> MMrpGrnBatches { get; set; }

    public virtual DbSet<MMrpGrnHeader> MMrpGrnHeaders { get; set; }

    public virtual DbSet<MMrpGrnLine> MMrpGrnLines { get; set; }

    public virtual DbSet<MMrpIndentIssue> MMrpIndentIssues { get; set; }

    public virtual DbSet<MMrpIndentIssueLine> MMrpIndentIssueLines { get; set; }

    public virtual DbSet<MMrpIndentIssuesBatch> MMrpIndentIssuesBatches { get; set; }

    public virtual DbSet<MMrpIndentIssuesPatient> MMrpIndentIssuesPatients { get; set; }

    public virtual DbSet<MMrpIndentIssuesPatientBatch> MMrpIndentIssuesPatientBatches { get; set; }

    public virtual DbSet<MMrpIndentIssuesPatientLine> MMrpIndentIssuesPatientLines { get; set; }

    public virtual DbSet<MMrpPharmacyReturnHeader> MMrpPharmacyReturnHeaders { get; set; }

    public virtual DbSet<MMrpPharmacyReturnLine> MMrpPharmacyReturnLines { get; set; }

    public virtual DbSet<MMrpPoDelivery> MMrpPoDeliveries { get; set; }

    public virtual DbSet<MMrpPoHeader> MMrpPoHeaders { get; set; }

    public virtual DbSet<MMrpPoLine> MMrpPoLines { get; set; }

    public virtual DbSet<MMrpStockCurrent> MMrpStockCurrents { get; set; }

    public virtual DbSet<MMrpStockLedger> MMrpStockLedgers { get; set; }

    public virtual DbSet<MMrpStore> MMrpStores { get; set; }

    public virtual DbSet<MMrpStoreAccessRight> MMrpStoreAccessRights { get; set; }

    public virtual DbSet<MMrpStoreConsumption> MMrpStoreConsumptions { get; set; }

    public virtual DbSet<MMrpStoreConsumptionBatch> MMrpStoreConsumptionBatches { get; set; }

    public virtual DbSet<MMrpStoreConsumptionLine> MMrpStoreConsumptionLines { get; set; }

    public virtual DbSet<MMrpStoreIndent> MMrpStoreIndents { get; set; }

    public virtual DbSet<MMrpStoreIndentLine> MMrpStoreIndentLines { get; set; }

    public virtual DbSet<MMrpStoreIndentReceipt> MMrpStoreIndentReceipts { get; set; }

    public virtual DbSet<MMrpStoreIndentReceiptBatch> MMrpStoreIndentReceiptBatches { get; set; }

    public virtual DbSet<MMrpStoreIndentReceiptLine> MMrpStoreIndentReceiptLines { get; set; }

    public virtual DbSet<MMrpStoreOpeningStock> MMrpStoreOpeningStocks { get; set; }

    public virtual DbSet<MMrpStoreOpeningStockBatch> MMrpStoreOpeningStockBatches { get; set; }

    public virtual DbSet<MMrpStoreOpeningStockLine> MMrpStoreOpeningStockLines { get; set; }

    public virtual DbSet<MMrpStoreReturnHeader> MMrpStoreReturnHeaders { get; set; }

    public virtual DbSet<MMrpStoreReturnLine> MMrpStoreReturnLines { get; set; }

    public virtual DbSet<MMrpStoresProduct> MMrpStoresProducts { get; set; }

    public virtual DbSet<MMrpVendorReturnHeader> MMrpVendorReturnHeaders { get; set; }

    public virtual DbSet<MMrpVendorReturnLine> MMrpVendorReturnLines { get; set; }

    public virtual DbSet<MOpeningStockTemp> MOpeningStockTemps { get; set; }

    public virtual DbSet<MParameter> MParameters { get; set; }

    public virtual DbSet<MParameterSetup> MParameterSetups { get; set; }

    public virtual DbSet<MPatientAccountAdditionalCharge> MPatientAccountAdditionalCharges { get; set; }

    public virtual DbSet<MPatientAccountAdditionalChargesAssociation> MPatientAccountAdditionalChargesAssociations { get; set; }

    public virtual DbSet<MPatientAccountAdditionalChargesRule> MPatientAccountAdditionalChargesRules { get; set; }

    public virtual DbSet<MPatientAccountAdditionalChargesSurgery> MPatientAccountAdditionalChargesSurgeries { get; set; }

    public virtual DbSet<MPatientAccountWardCharge> MPatientAccountWardCharges { get; set; }

    public virtual DbSet<MPatientBillTemp> MPatientBillTemps { get; set; }

    public virtual DbSet<MPatientDischargeClearanceSetUp> MPatientDischargeClearanceSetUps { get; set; }

    public virtual DbSet<MPatientsIdentification> MPatientsIdentifications { get; set; }

    public virtual DbSet<MPatientsRegistration> MPatientsRegistrations { get; set; }

    public virtual DbSet<MPayerIdentification> MPayerIdentifications { get; set; }

    public virtual DbSet<MPayerRegistration> MPayerRegistrations { get; set; }

    public virtual DbSet<MPlace> MPlaces { get; set; }

    public virtual DbSet<MProductClasssifcation> MProductClasssifcations { get; set; }

    public virtual DbSet<MProductDefinition> MProductDefinitions { get; set; }

    public virtual DbSet<MProductOrdering> MProductOrderings { get; set; }

    public virtual DbSet<MProductStock> MProductStocks { get; set; }

    public virtual DbSet<MProductUom> MProductUoms { get; set; }

    public virtual DbSet<MProvider> MProviders { get; set; }

    public virtual DbSet<MProviderCredential> MProviderCredentials { get; set; }

    public virtual DbSet<MProviderIdentification> MProviderIdentifications { get; set; }

    public virtual DbSet<MReciptBillTemp> MReciptBillTemps { get; set; }

    public virtual DbSet<MReferral> MReferrals { get; set; }

    public virtual DbSet<MReprintTemptbl> MReprintTemptbls { get; set; }

    public virtual DbSet<MRole> MRoles { get; set; }

    public virtual DbSet<MScheduleAvailabilityCalendar> MScheduleAvailabilityCalendars { get; set; }

    public virtual DbSet<MScheduleFacilityHoliday> MScheduleFacilityHolidays { get; set; }

    public virtual DbSet<MScheduleProvider> MScheduleProviders { get; set; }

    public virtual DbSet<MScheduleProviderAbsence> MScheduleProviderAbsences { get; set; }

    public virtual DbSet<MScheduleSpecialEvent> MScheduleSpecialEvents { get; set; }

    public virtual DbSet<MScheduleTemplate> MScheduleTemplates { get; set; }

    public virtual DbSet<MScheduleTemplateSession> MScheduleTemplateSessions { get; set; }

    public virtual DbSet<MScreen> MScreens { get; set; }

    public virtual DbSet<MScreenField> MScreenFields { get; set; }

    public virtual DbSet<MServiceLabAttribute> MServiceLabAttributes { get; set; }

    public virtual DbSet<MServiceLocation> MServiceLocations { get; set; }

    public virtual DbSet<MServiceMedicalCode> MServiceMedicalCodes { get; set; }

    public virtual DbSet<MServiceOrdering> MServiceOrderings { get; set; }

    public virtual DbSet<MServicePackage> MServicePackages { get; set; }

    public virtual DbSet<MServiceTat> MServiceTats { get; set; }

    public virtual DbSet<MState> MStates { get; set; }

    public virtual DbSet<MSubMenuActivity> MSubMenuActivities { get; set; }

    public virtual DbSet<MSubMenuChild> MSubMenuChildren { get; set; }

    public virtual DbSet<MSubTestMapping> MSubTestMappings { get; set; }

    public virtual DbSet<MTempPharmacyBill> MTempPharmacyBills { get; set; }

    public virtual DbSet<MTestMethod> MTestMethods { get; set; }

    public virtual DbSet<MTestReferance> MTestReferances { get; set; }

    public virtual DbSet<MUom> MUoms { get; set; }

    public virtual DbSet<MUser> MUsers { get; set; }

    public virtual DbSet<MUserRegistration> MUserRegistrations { get; set; }

    public virtual DbSet<MVendor> MVendors { get; set; }

    public virtual DbSet<MWard> MWards { get; set; }

    public virtual DbSet<MWorkFlow> MWorkFlows { get; set; }

    public virtual DbSet<MWorkFlowScreen> MWorkFlowScreens { get; set; }

    public virtual DbSet<MWorkFlowScreenParameter> MWorkFlowScreenParameters { get; set; }

    public virtual DbSet<Prod> Prods { get; set; }

    public virtual DbSet<TAntenatalVitalHeader> TAntenatalVitalHeaders { get; set; }

    public virtual DbSet<TAntenatalVitalsLine> TAntenatalVitalsLines { get; set; }

    public virtual DbSet<TAttachClinicalFile> TAttachClinicalFiles { get; set; }

    public virtual DbSet<TClinicalAdvice> TClinicalAdvices { get; set; }

    public virtual DbSet<TClinicalAllergy> TClinicalAllergies { get; set; }

    public virtual DbSet<TClinicalFinding> TClinicalFindings { get; set; }

    public virtual DbSet<TClinicalHistory> TClinicalHistories { get; set; }

    public virtual DbSet<TClinicalLineAdvice> TClinicalLineAdvices { get; set; }

    public virtual DbSet<TClinicalMedicalHistory> TClinicalMedicalHistories { get; set; }

    public virtual DbSet<TClinicalRisk> TClinicalRisks { get; set; }

    public virtual DbSet<TClinicalproblem> TClinicalproblems { get; set; }

    public virtual DbSet<TDischargeSummary> TDischargeSummaries { get; set; }

    public virtual DbSet<TDischargeSummaryMedication> TDischargeSummaryMedications { get; set; }

    public virtual DbSet<TDrNote> TDrNotes { get; set; }

    public virtual DbSet<TDrugChart> TDrugCharts { get; set; }

    public virtual DbSet<TEncounter> TEncounters { get; set; }

    public virtual DbSet<TFluidChart> TFluidCharts { get; set; }

    public virtual DbSet<TFrequency> TFrequencies { get; set; }

    public virtual DbSet<TNrNote> TNrNotes { get; set; }

    public virtual DbSet<TPatientAccountAssignedPlan> TPatientAccountAssignedPlans { get; set; }

    public virtual DbSet<TPatientAccountAssignedPlanAuthorization> TPatientAccountAssignedPlanAuthorizations { get; set; }

    public virtual DbSet<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLines { get; set; }

    public virtual DbSet<TPatientAccountBill> TPatientAccountBills { get; set; }

    public virtual DbSet<TPatientAccountCharge> TPatientAccountCharges { get; set; }

    public virtual DbSet<TPatientAccountChargeAttribute> TPatientAccountChargeAttributes { get; set; }

    public virtual DbSet<TPatientAccountDefaultTariff> TPatientAccountDefaultTariffs { get; set; }

    public virtual DbSet<TPatientAccountDepositDefinition> TPatientAccountDepositDefinitions { get; set; }

    public virtual DbSet<TPatientAccountLedger> TPatientAccountLedgers { get; set; }

    public virtual DbSet<TPatientAccountOrder> TPatientAccountOrders { get; set; }

    public virtual DbSet<TPatientAccountPackageSubscription> TPatientAccountPackageSubscriptions { get; set; }

    public virtual DbSet<TPatientAccountProcedureCharge> TPatientAccountProcedureCharges { get; set; }

    public virtual DbSet<TPatientAccountProcedureChargesDetail> TPatientAccountProcedureChargesDetails { get; set; }

    public virtual DbSet<TPatientAccountReFundHeader> TPatientAccountReFundHeaders { get; set; }

    public virtual DbSet<TPatientAccountReFundInstrument> TPatientAccountReFundInstruments { get; set; }

    public virtual DbSet<TPatientAccountReceiptAdjust> TPatientAccountReceiptAdjusts { get; set; }

    public virtual DbSet<TPatientAccountReceiptAllocation> TPatientAccountReceiptAllocations { get; set; }

    public virtual DbSet<TPatientAccountReceiptHeader> TPatientAccountReceiptHeaders { get; set; }

    public virtual DbSet<TPatientAccountReceiptInstrument> TPatientAccountReceiptInstruments { get; set; }

    public virtual DbSet<TPatientAccountRecurringCharge> TPatientAccountRecurringCharges { get; set; }

    public virtual DbSet<TPatientClaim> TPatientClaims { get; set; }

    public virtual DbSet<TPatientClaimInvoice> TPatientClaimInvoices { get; set; }

    public virtual DbSet<TPatientDischarge> TPatientDischarges { get; set; }

    public virtual DbSet<TPatientDischargeClearance> TPatientDischargeClearances { get; set; }

    public virtual DbSet<TPatientLabStatus> TPatientLabStatuses { get; set; }

    public virtual DbSet<TPatientMovement> TPatientMovements { get; set; }

    public virtual DbSet<TPatientVital> TPatientVitals { get; set; }

    public virtual DbSet<TPrescriptionLine> TPrescriptionLines { get; set; }

    public virtual DbSet<TPriscptionHedder> TPriscptionHedders { get; set; }

    public virtual DbSet<TQueue> TQueues { get; set; }

    public virtual DbSet<TSampleCollectionHeader> TSampleCollectionHeaders { get; set; }

    public virtual DbSet<TSampleCollectionLine> TSampleCollectionLines { get; set; }

    public virtual DbSet<TScheduleProviderAppointment> TScheduleProviderAppointments { get; set; }

    public virtual DbSet<TSeqTUser> TSeqTUsers { get; set; }

    public virtual DbSet<TSummaryCase> TSummaryCases { get; set; }

    public virtual DbSet<TSummaryCatheter> TSummaryCatheters { get; set; }

    public virtual DbSet<TSummaryDressing> TSummaryDressings { get; set; }

    public virtual DbSet<TSummaryImplant> TSummaryImplants { get; set; }

    public virtual DbSet<TSummaryIntraop> TSummaryIntraops { get; set; }

    public virtual DbSet<TSummaryPosition> TSummaryPositions { get; set; }

    public virtual DbSet<TSummaryPreop> TSummaryPreops { get; set; }

    public virtual DbSet<TSummaryPreopLine> TSummaryPreopLines { get; set; }

    public virtual DbSet<TSummaryProcedure> TSummaryProcedures { get; set; }

    public virtual DbSet<TSummaryRecovery> TSummaryRecoveries { get; set; }

    public virtual DbSet<TSummarySkin> TSummarySkins { get; set; }

    public virtual DbSet<TSummarySpeciman> TSummarySpecimen { get; set; }

    public virtual DbSet<TTestResultEntry> TTestResultEntries { get; set; }

    public virtual DbSet<TTransaction> TTransactions { get; set; }

    public virtual DbSet<TUser> TUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-FF351R2\\SQLEXPRESS;Database=WellBeing_Development_New;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<HmsAppUserRole>(entity =>
        {
            entity.HasKey(e => e.AppUserRoleId).HasName("PK__HMS_AppU__73EF1A640EE00A7E");

            entity.HasOne(d => d.AppUser).WithMany(p => p.HmsAppUserRoleAppUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HMS_AppUs__AppUs__2962141D");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.HmsAppUserRoleCreatedByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HMS_AppUs__Creat__2A563856");

            entity.HasOne(d => d.Role).WithMany(p => p.HmsAppUserRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HMS_AppUs__Role___2B4A5C8F");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.HmsAppUserRoleUpdatedByNavigations).HasConstraintName("FK__HMS_AppUs__Updat__2C3E80C8");
        });

        modelBuilder.Entity<HmsFacility>(entity =>
        {
            entity.HasKey(e => e.FacilityId).HasName("PK__HMS_Faci__5FB08A745D939D7C");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.HmsFacilityCreatedByNavigations).HasConstraintName("FK__HMS_Facil__Creat__2D32A501");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.HmsFacilityUpdatedByNavigations).HasConstraintName("FK__HMS_Facil__Updat__2E26C93A");
        });

        modelBuilder.Entity<HmsMainMenu>(entity =>
        {
            entity.HasKey(e => e.MainMenuId).HasName("PK__HMS_Main__9C4DC01F278372B7");

            entity.HasOne(d => d.MainMenuCtrl).WithMany(p => p.HmsMainMenus).HasConstraintName("FK__HMS_MainM__Main___300F11AC");
        });

        modelBuilder.Entity<HmsMainMenuControl>(entity =>
        {
            entity.HasKey(e => e.MainMenuCtrlId).HasName("PK__HMS_Main__946A28C7139CE4C9");

            entity.HasOne(d => d.MainMenu).WithMany(p => p.HmsMainMenuControls).HasConstraintName("FK__HMS_MainM__Main___310335E5");
        });

        modelBuilder.Entity<HmsMainMenuTab>(entity =>
        {
            entity.HasOne(d => d.Menu).WithMany(p => p.HmsMainMenuTabs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HMS_Main___Menu___2F1AED73");
        });

        modelBuilder.Entity<HmsRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__HMS_Role__D80AB4BB6537365D");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.HmsRoleCreatedByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HMS_Roles__Creat__31F75A1E");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.HmsRoleUpdatedByNavigations).HasConstraintName("FK__HMS_Roles__Updat__32EB7E57");
        });

        modelBuilder.Entity<HmsRolesMenu>(entity =>
        {
            entity.HasKey(e => e.RoleMenuId).HasName("PK__HMS_Role__AC18E4E8FED5B2E1");

            entity.HasOne(d => d.MainMenuTabs).WithMany(p => p.HmsRolesMenus).HasConstraintName("FK_HMS_Roles_Menu_HMS_Main_Menu_Tabs");

            entity.HasOne(d => d.Menu).WithMany(p => p.HmsRolesMenus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HMS_Roles_Menu_HMS_MainMenu");

            entity.HasOne(d => d.Role).WithMany(p => p.HmsRolesMenus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HMS_Roles_Menu_HMS_Roles");
        });

        modelBuilder.Entity<MArea>(entity =>
        {
            entity.HasOne(d => d.Place).WithMany(p => p.MAreas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Area_m_Places");
        });

        modelBuilder.Entity<MBed>(entity =>
        {
            entity.HasOne(d => d.Ward).WithMany(p => p.MBeds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Bed_m_Ward");
        });

        modelBuilder.Entity<MBillAgreement>(entity =>
        {
            entity.HasOne(d => d.Employer).WithMany(p => p.MBillAgreementEmployers).HasConstraintName("FK_m_BillAgreement_m_PayerRegistration1");

            entity.HasOne(d => d.Facility).WithMany(p => p.MBillAgreements).HasConstraintName("FK_m_BillAgreement_m_Facility");

            entity.HasOne(d => d.Insurer).WithMany(p => p.MBillAgreementInsurers).HasConstraintName("FK_m_BillAgreement_m_PayerRegistration2");

            entity.HasOne(d => d.Payer).WithMany(p => p.MBillAgreementPayers).HasConstraintName("FK_m_BillAgreement_m_PayerRegistration");

            entity.HasOne(d => d.RestrictedAuthLimitTypeNavigation).WithMany(p => p.MBillAgreementRestrictedAuthLimitTypeNavigations).HasConstraintName("FK_m_BillAgreement_m_GeneralLookup1");

            entity.HasOne(d => d.RestrictedDeductibleTypeNavigation).WithMany(p => p.MBillAgreementRestrictedDeductibleTypeNavigations).HasConstraintName("FK_m_BillAgreement_m_GeneralLookup");
        });

        modelBuilder.Entity<MBillAgreementLine>(entity =>
        {
            entity.HasOne(d => d.Agreement).WithMany(p => p.MBillAgreementLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillAgreementLine_m_BillAgreement");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.MBillAgreementLineGenderNavigations).HasConstraintName("FK_m_BillAgreementLine_m_GeneralLookup2");

            entity.HasOne(d => d.IndicatorNavigation).WithMany(p => p.MBillAgreementLineIndicatorNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillAgreementLine_m_GeneralLookup4");

            entity.HasOne(d => d.NationalityNavigation).WithMany(p => p.MBillAgreementLineNationalityNavigations).HasConstraintName("FK_m_BillAgreementLine_m_GeneralLookup3");

            entity.HasOne(d => d.PatientType).WithMany(p => p.MBillAgreementLinePatientTypes).HasConstraintName("FK_m_BillAgreementLine_m_GeneralLookup1");

            entity.HasOne(d => d.PayerNavigation).WithMany(p => p.MBillAgreementLines).HasConstraintName("FK_m_BillAgreementLine_m_PayerRegistration");

            entity.HasOne(d => d.ProviderNavigation).WithMany(p => p.MBillAgreementLines).HasConstraintName("FK_m_BillAgreementLine_m_Providers");

            entity.HasOne(d => d.WardType).WithMany(p => p.MBillAgreementLineWardTypes).HasConstraintName("FK_m_BillAgreementLine_m_GeneralLookup");
        });

        modelBuilder.Entity<MBillAutoCharge>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.MBillAutoCharges).HasConstraintName("FK_m_BillAutoCharge_m_FacilityDepartment");

            entity.HasOne(d => d.EncounterType).WithMany(p => p.MBillAutoChargeEncounterTypes).HasConstraintName("FK_m_BillAutoCharge_m_GeneralLookup");

            entity.HasOne(d => d.Facility).WithMany(p => p.MBillAutoCharges).HasConstraintName("FK_m_BillAutoCharge_m_Facility");

            entity.HasOne(d => d.PatientType).WithMany(p => p.MBillAutoChargePatientTypes).HasConstraintName("FK_m_BillAutoCharge_m_GeneralLookup1");

            entity.HasOne(d => d.Provider).WithMany(p => p.MBillAutoCharges).HasConstraintName("FK_m_BillAutoCharge_m_Providers");

            entity.HasOne(d => d.Service).WithMany(p => p.MBillAutoCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillAutoCharge_m_BillServices");
        });

        modelBuilder.Entity<MBillBasePrice>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MBillBasePrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillBasePrice_m_Facility");
        });

        modelBuilder.Entity<MBillBasePriceService>(entity =>
        {
            entity.HasOne(d => d.BasePrice).WithMany(p => p.MBillBasePriceServices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillBasePriceServices_m_BillBasePrice");

            entity.HasOne(d => d.Facility).WithMany(p => p.MBillBasePriceServices).HasConstraintName("FK_m_BillBasePriceServices_m_Facility");

            entity.HasOne(d => d.Service).WithMany(p => p.MBillBasePriceServices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillBasePriceServices_m_BillServices");

            entity.HasOne(d => d.Uom).WithMany(p => p.MBillBasePriceServices).HasConstraintName("FK_m_BillBasePriceServices_m_UOM");
        });

        modelBuilder.Entity<MBillChargeExceptionHeader>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MBillChargeExceptionHeaders).HasConstraintName("FK_m_BillChargeExceptionHeader_m_Facility");
        });

        modelBuilder.Entity<MBillChargeExceptionLine>(entity =>
        {
            entity.HasKey(e => e.ExceptionLineId).HasName("PK_m_BillChargeExceptionLine_1");

            entity.HasOne(d => d.ExceptionHeader).WithMany(p => p.MBillChargeExceptionLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillChargeExceptionLine_m_BillChargeExceptionHeader");

            entity.HasOne(d => d.Holiday).WithMany(p => p.MBillChargeExceptionLines).HasConstraintName("FK_m_BillChargeExceptionLine_m_ScheduleFacilityHoliday");

            entity.HasOne(d => d.IndicatorNavigation).WithMany(p => p.MBillChargeExceptionLineIndicatorNavigations).HasConstraintName("FK_m_BillChargeExceptionLine_m_GeneralLookup1");

            entity.HasOne(d => d.PatientType).WithMany(p => p.MBillChargeExceptionLinePatientTypes).HasConstraintName("FK_m_BillChargeExceptionLine_m_GeneralLookup");

            entity.HasOne(d => d.Provider).WithMany(p => p.MBillChargeExceptionLines).HasConstraintName("FK_m_BillChargeExceptionLine_m_Providers");

            entity.HasOne(d => d.ServiceLocation).WithMany(p => p.MBillChargeExceptionLines).HasConstraintName("FK_m_BillChargeExceptionLine_m_ServiceLocations");
        });

        modelBuilder.Entity<MBillPriceTariff>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MBillPriceTariffs).HasConstraintName("FK_m_BillPriceTariff_m_Facility");
        });

        modelBuilder.Entity<MBillPriceTariffLine>(entity =>
        {
            entity.HasKey(e => e.PriceTariffLineId).HasName("PK_m_BillBasePriceTariffLine");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.MBillPriceTariffLineGenderNavigations).HasConstraintName("FK_m_BillPriceTariffLine_m_GeneralLookup");

            entity.HasOne(d => d.IndicatorNavigation).WithMany(p => p.MBillPriceTariffLineIndicatorNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillPriceTariffLine_m_GeneralLookup4");

            entity.HasOne(d => d.NationalityNavigation).WithMany(p => p.MBillPriceTariffLineNationalityNavigations).HasConstraintName("FK_m_BillPriceTariffLine_m_GeneralLookup2");

            entity.HasOne(d => d.PatientType).WithMany(p => p.MBillPriceTariffLinePatientTypes).HasConstraintName("FK_m_BillPriceTariffLine_m_GeneralLookup1");

            entity.HasOne(d => d.PayerNavigation).WithMany(p => p.MBillPriceTariffLines).HasConstraintName("FK_m_BillPriceTariffLine_m_PayerRegistration");

            entity.HasOne(d => d.PriceTariff).WithMany(p => p.MBillPriceTariffLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillBasePriceTariffLine_m_BillPriceTariff");

            entity.HasOne(d => d.ProviderNavigation).WithMany(p => p.MBillPriceTariffLines).HasConstraintName("FK_m_BillPriceTariffLine_m_Providers");

            entity.HasOne(d => d.WardType).WithMany(p => p.MBillPriceTariffLineWardTypes).HasConstraintName("FK_m_BillPriceTariffLine_m_GeneralLookup3");
        });

        modelBuilder.Entity<MBillService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__m_BillSe__C51BB00A3847954F");

            entity.Property(e => e.IsFromTestValues).HasDefaultValueSql("('0')");
            entity.Property(e => e.IsRadiology).HasDefaultValueSql("('0')");
            entity.Property(e => e.IsSubTest).HasDefaultValueSql("('0')");

            entity.HasOne(d => d.Category).WithMany(p => p.MBillServices).HasConstraintName("FK_m_BillServices_m_GeneralLookup");

            entity.HasOne(d => d.ExecutionUomServiceDurationNavigation).WithMany(p => p.MBillServiceExecutionUomServiceDurationNavigations).HasConstraintName("FK_m_BillServices_m_UOM1");

            entity.HasOne(d => d.ServiceClassification).WithMany(p => p.MBillServices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillServices_m_BillServiceClasssifcation");

            entity.HasOne(d => d.Uom).WithMany(p => p.MBillServiceUoms).HasConstraintName("FK_m_BillServices_m_UOM");
        });

        modelBuilder.Entity<MBillServiceClasssifcation>(entity =>
        {
            entity.HasKey(e => e.ServiceClassificationId).HasName("PK__m_BillSe__351B6089C210DA02");

            entity.HasOne(d => d.Facility).WithMany(p => p.MBillServiceClasssifcations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillServiceClasssifcation_m_Facility");

            entity.HasOne(d => d.OrderGroup).WithMany(p => p.MBillServiceClasssifcationOrderGroups).HasConstraintName("FK_m_BillServiceClasssifcation_m_GeneralLookup1");

            entity.HasOne(d => d.PrintGroup).WithMany(p => p.MBillServiceClasssifcationPrintGroups).HasConstraintName("FK_m_BillServiceClasssifcation_m_GeneralLookup2");

            entity.HasOne(d => d.ServiceGroup).WithMany(p => p.MBillServiceClasssifcationServiceGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_BillServiceClasssifcation_m_GeneralLookup");
        });

        modelBuilder.Entity<MClinicalFlowChart>(entity =>
        {
            entity.Property(e => e.ClinicalFlowId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MConfiguration>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MConfigurations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Configuration_m_Facility");
        });

        modelBuilder.Entity<MContainerDefinition>(entity =>
        {
            entity.Property(e => e.Cdid).ValueGeneratedNever();
        });

        modelBuilder.Entity<MEnterprise>(entity =>
        {
            entity.HasOne(d => d.Area).WithMany(p => p.MEnterprises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Enterprise_m_Area");

            entity.HasOne(d => d.Country).WithMany(p => p.MEnterprises).HasConstraintName("FK__m_Enterpr__Count__436BFEE3");

            entity.HasOne(d => d.Place).WithMany(p => p.MEnterprises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Enterprise_m_Places");

            entity.HasOne(d => d.State).WithMany(p => p.MEnterprises)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Enterprise_m_States");
        });

        modelBuilder.Entity<MFacility>(entity =>
        {
            entity.HasOne(d => d.Area).WithMany(p => p.MFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Facility_m_Area");

            entity.HasOne(d => d.Country).WithMany(p => p.MFacilities).HasConstraintName("FK__m_Facilit__Count__558AAF1E");

            entity.HasOne(d => d.Enterprise).WithMany(p => p.MFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Facility_m_Enterprise");

            entity.HasOne(d => d.Place).WithMany(p => p.MFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Facility_m_Places");

            entity.HasOne(d => d.State).WithMany(p => p.MFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Facility_m_States");
        });

        modelBuilder.Entity<MFacilityDepartment>(entity =>
        {
            entity.HasOne(d => d.Department).WithMany(p => p.MFacilityDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityDepartment_m_Departments");

            entity.HasOne(d => d.Facility).WithMany(p => p.MFacilityDepartments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityDepartment_m_Facility");
        });

        modelBuilder.Entity<MFacilityDepartmentPatientType>(entity =>
        {
            entity.HasOne(d => d.FacilityDepartment).WithMany(p => p.MFacilityDepartmentPatientTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityDepartmentPatientType_m_FacilityDepartment");

            entity.HasOne(d => d.PatientType).WithMany(p => p.MFacilityDepartmentPatientTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityDepartmentPatientType_m_GeneralLookup");
        });

        modelBuilder.Entity<MFacilityDepartmentProvider>(entity =>
        {
            entity.HasOne(d => d.FacilityDepartment).WithMany(p => p.MFacilityDepartmentProviders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityDepartmentProvider_m_FacilityDepartment");

            entity.HasOne(d => d.Provider).WithMany(p => p.MFacilityDepartmentProviders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityDepartmentProvider_m_Providers");
        });

        modelBuilder.Entity<MFacilityDepartmentServiceLocation>(entity =>
        {
            entity.HasOne(d => d.FacilityDepartment).WithMany(p => p.MFacilityDepartmentServiceLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityDepartmentServiceLocation_m_FacilityDepartment");

            entity.HasOne(d => d.ServiceLocation).WithMany(p => p.MFacilityDepartmentServiceLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityDepartmentServiceLocation_m_ServiceLocations");
        });

        modelBuilder.Entity<MFacilityDepartmentServiceLocationEquipment>(entity =>
        {
            entity.HasKey(e => e.DepartmentServiceLocationEquipmentId).HasName("PK_m_DepartmentServiceLocationEquipment");

            entity.HasOne(d => d.Equipment).WithMany(p => p.MFacilityDepartmentServiceLocationEquipments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_DepartmentServiceLocationEquipment_m_GeneralLookup");

            entity.HasOne(d => d.FacilityDepartmentServiceLocation).WithMany(p => p.MFacilityDepartmentServiceLocationEquipments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_DepartmentServiceLocationEquipment_m_FacilityDepartmentServiceLocation");
        });

        modelBuilder.Entity<MFacilityWorkFlow>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MFacilityWorkFlows)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityWorkFlow_m_Facility");

            entity.HasOne(d => d.WorkFlow).WithMany(p => p.MFacilityWorkFlows)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_FacilityWorkFlow_m_WorkFlow");
        });

        modelBuilder.Entity<MField>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PK__m_Field__C8B6FF0742256C63");
        });

        modelBuilder.Entity<MGeneralLookup>(entity =>
        {
            entity.HasOne(d => d.LookupTypeNavigation).WithMany(p => p.MGeneralLookups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_GeneralLookup_m_LookupType");
        });

        modelBuilder.Entity<MMrpGrnBatch>(entity =>
        {
            entity.HasOne(d => d.GrnLine).WithMany(p => p.MMrpGrnBatches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_GrnBatch_m_mrp_GrnLine");
        });

        modelBuilder.Entity<MMrpGrnHeader>(entity =>
        {
            entity.HasOne(d => d.DocumentTypeNavigation).WithMany(p => p.MMrpGrnHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_GrnHeader_m_GeneralLookup");

            entity.HasOne(d => d.Facility).WithMany(p => p.MMrpGrnHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_GrnHeader_m_Facility");

            entity.HasOne(d => d.ReceivingStore).WithMany(p => p.MMrpGrnHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_GrnHeader_m_mrp_Stores");

            entity.HasOne(d => d.Supplier).WithMany(p => p.MMrpGrnHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_GrnHeader_m_Vendors");
        });

        modelBuilder.Entity<MMrpGrnLine>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.MMrpGrnLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_GrnLine_m_ProductDefinition");

            entity.HasOne(d => d.Uom).WithMany(p => p.MMrpGrnLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_GrnLine_m_UOM");
        });

        modelBuilder.Entity<MMrpIndentIssue>(entity =>
        {
            entity.HasOne(d => d.IssueStore).WithMany(p => p.MMrpIndentIssueIssueStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssues_m_mrp_Stores");

            entity.HasOne(d => d.RequestStore).WithMany(p => p.MMrpIndentIssueRequestStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssues_m_mrp_Stores1");
        });

        modelBuilder.Entity<MMrpIndentIssueLine>(entity =>
        {
            entity.HasOne(d => d.IndentIssue).WithMany(p => p.MMrpIndentIssueLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssueLine_m_mrp_IndentIssues");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpIndentIssueLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssueLine_m_ProductDefinition");

            entity.HasOne(d => d.Uom).WithMany(p => p.MMrpIndentIssueLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssueLine_m_UOM");
        });

        modelBuilder.Entity<MMrpIndentIssuesBatch>(entity =>
        {
            entity.HasKey(e => e.IssueBatchId).HasName("PK_m_mrp_IndentIssueBatch");

            entity.HasOne(d => d.IndentIssueLine).WithMany(p => p.MMrpIndentIssuesBatches).HasConstraintName("FK_m_mrp_IndentIssuesBatch_m_mrp_IndentIssueLine");
        });

        modelBuilder.Entity<MMrpIndentIssuesPatient>(entity =>
        {
            entity.HasOne(d => d.IssueStore).WithMany(p => p.MMrpIndentIssuesPatients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssuesPatient_m_mrp_Stores");
        });

        modelBuilder.Entity<MMrpIndentIssuesPatientBatch>(entity =>
        {
            entity.HasOne(d => d.PatientIssue).WithMany(p => p.MMrpIndentIssuesPatientBatches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssuesPatientBatch_m_mrp_IndentIssuesPatientLine");
        });

        modelBuilder.Entity<MMrpIndentIssuesPatientLine>(entity =>
        {
            entity.HasOne(d => d.PatientIssue).WithMany(p => p.MMrpIndentIssuesPatientLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssuesPatientLine_m_mrp_IndentIssuesPatient");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpIndentIssuesPatientLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_IndentIssuesPatientLine_m_ProductDefinition");
        });

        modelBuilder.Entity<MMrpPoDelivery>(entity =>
        {
            entity.HasOne(d => d.PoLine).WithMany(p => p.MMrpPoDeliveries).HasConstraintName("FK_m_mrp_PoDelivery_m_mrp_PoLine");
        });

        modelBuilder.Entity<MMrpPoHeader>(entity =>
        {
            entity.HasOne(d => d.DocumentTypeNavigation).WithMany(p => p.MMrpPoHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_PoHeader_m_GeneralLookup");

            entity.HasOne(d => d.Facility).WithMany(p => p.MMrpPoHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_PoHeader_m_Facility");

            entity.HasOne(d => d.ProcurementStore).WithMany(p => p.MMrpPoHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_PoHeader_m_mrp_Stores");

            entity.HasOne(d => d.Supplier).WithMany(p => p.MMrpPoHeaders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_PoHeader_m_Vendors");
        });

        modelBuilder.Entity<MMrpPoLine>(entity =>
        {
            entity.HasOne(d => d.PoHeader).WithMany(p => p.MMrpPoLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_PoLine_m_mrp_PoHeader");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpPoLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_PoLine_m_ProductDefinition");

            entity.HasOne(d => d.UomNavigation).WithMany(p => p.MMrpPoLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_PoLine_m_UOM");
        });

        modelBuilder.Entity<MMrpStockCurrent>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStockCurrents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StockCurrent_m_ProductDefinition");

            entity.HasOne(d => d.Store).WithMany(p => p.MMrpStockCurrents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StockCurrent_m_mrp_Stores");

            entity.HasOne(d => d.Uom).WithMany(p => p.MMrpStockCurrents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StockCurrent_m_UOM");
        });

        modelBuilder.Entity<MMrpStockLedger>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStockLedgers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StockLedger_m_ProductDefinition");

            entity.HasOne(d => d.Store).WithMany(p => p.MMrpStockLedgers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StockLedger_m_mrp_Stores");
        });

        modelBuilder.Entity<MMrpStore>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MMrpStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_Stores_m_Facility");
        });

        modelBuilder.Entity<MMrpStoreAccessRight>(entity =>
        {
            entity.HasOne(d => d.Feature).WithMany(p => p.MMrpStoreAccessRights).HasConstraintName("FK_m_mrp_StoreAccessRights_m_GeneralLookup");

            entity.HasOne(d => d.Store).WithMany(p => p.MMrpStoreAccessRights).HasConstraintName("FK_m_mrp_StoreAccessRights_m_mrp_Stores");
        });

        modelBuilder.Entity<MMrpStoreConsumption>(entity =>
        {
            entity.HasOne(d => d.IssueStore).WithMany(p => p.MMrpStoreConsumptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreConsumption_m_mrp_Stores");
        });

        modelBuilder.Entity<MMrpStoreConsumptionBatch>(entity =>
        {
            entity.HasOne(d => d.StoreConsumptionLine).WithMany(p => p.MMrpStoreConsumptionBatches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreConsumptionBatch_m_mrp_StoreConsumptionLine");
        });

        modelBuilder.Entity<MMrpStoreConsumptionLine>(entity =>
        {
            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStoreConsumptionLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreConsumptionLine_m_ProductDefinition");

            entity.HasOne(d => d.StoreConsumption).WithMany(p => p.MMrpStoreConsumptionLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreConsumptionLine_m_mrp_StoreConsumption");

            entity.HasOne(d => d.Uom).WithMany(p => p.MMrpStoreConsumptionLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreConsumptionLine_m_UOM");
        });

        modelBuilder.Entity<MMrpStoreIndent>(entity =>
        {
            entity.HasOne(d => d.Encounter).WithMany(p => p.MMrpStoreIndents).HasConstraintName("FK_m_mrp_StoreIndent_t_Encounter");

            entity.HasOne(d => d.IssuingStore).WithMany(p => p.MMrpStoreIndentIssuingStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndent_m_mrp_Stores1");

            entity.HasOne(d => d.Patient).WithMany(p => p.MMrpStoreIndents).HasConstraintName("FK_m_mrp_StoreIndent_m_PatientsRegistration");

            entity.HasOne(d => d.RequestingStore).WithMany(p => p.MMrpStoreIndentRequestingStores).HasConstraintName("FK_m_mrp_StoreIndent_m_mrp_Stores");
        });

        modelBuilder.Entity<MMrpStoreIndentLine>(entity =>
        {
            entity.HasOne(d => d.Indent).WithMany(p => p.MMrpStoreIndentLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndentLine_m_mrp_StoreIndent");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStoreIndentLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndentLine_m_ProductDefinition");

            entity.HasOne(d => d.Uom).WithMany(p => p.MMrpStoreIndentLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndentLine_m_UOM");
        });

        modelBuilder.Entity<MMrpStoreIndentReceipt>(entity =>
        {
            entity.HasKey(e => e.IndentReceiptId).HasName("PK_m_mrp_storeIndentReceipt");

            entity.HasOne(d => d.IssueStore).WithMany(p => p.MMrpStoreIndentReceiptIssueStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndentReceipt_m_mrp_Stores");

            entity.HasOne(d => d.RequestStore).WithMany(p => p.MMrpStoreIndentReceiptRequestStores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndentReceipt_m_mrp_Stores1");
        });

        modelBuilder.Entity<MMrpStoreIndentReceiptBatch>(entity =>
        {
            entity.HasKey(e => e.IndentReceiptBatchId).HasName("PK_m_mrp_storeIndentReceiptBatch");

            entity.HasOne(d => d.IndentReceiptLine).WithMany(p => p.MMrpStoreIndentReceiptBatches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_storeIndentReceiptBatch_m_mrp_StoreIndentReceiptLine");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStoreIndentReceiptBatches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_storeIndentReceiptBatch_m_ProductDefinition");
        });

        modelBuilder.Entity<MMrpStoreIndentReceiptLine>(entity =>
        {
            entity.HasOne(d => d.IndentReceipt).WithMany(p => p.MMrpStoreIndentReceiptLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndentReceiptLine_m_mrp_storeIndentReceipt");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStoreIndentReceiptLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndentReceiptLine_m_ProductDefinition");

            entity.HasOne(d => d.Uom).WithMany(p => p.MMrpStoreIndentReceiptLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreIndentReceiptLine_m_UOM");
        });

        modelBuilder.Entity<MMrpStoreOpeningStock>(entity =>
        {
            entity.HasOne(d => d.ReceivingStore).WithMany(p => p.MMrpStoreOpeningStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreOpeningStock_m_mrp_Stores");
        });

        modelBuilder.Entity<MMrpStoreOpeningStockBatch>(entity =>
        {
            entity.HasOne(d => d.OpeningStockLine).WithMany(p => p.MMrpStoreOpeningStockBatches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreOpeningStockBatch_m_mrp_StoreOpeningStockLine");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStoreOpeningStockBatches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreOpeningStockBatch_m_ProductDefinition");
        });

        modelBuilder.Entity<MMrpStoreOpeningStockLine>(entity =>
        {
            entity.HasOne(d => d.OpeningStock).WithMany(p => p.MMrpStoreOpeningStockLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreOpeningStockLine_m_mrp_StoreOpeningStock");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStoreOpeningStockLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreOpeningStockLine_m_ProductDefinition");

            entity.HasOne(d => d.Uom).WithMany(p => p.MMrpStoreOpeningStockLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoreOpeningStockLine_m_UOM");
        });

        modelBuilder.Entity<MMrpStoresProduct>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MMrpStoresProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoresProducts_m_Facility");

            entity.HasOne(d => d.Product).WithMany(p => p.MMrpStoresProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoresProducts_m_ProductDefinition");

            entity.HasOne(d => d.StockLocatorNavigation).WithMany(p => p.MMrpStoresProducts).HasConstraintName("FK_m_mrp_StoresProducts_m_GeneralLookup");

            entity.HasOne(d => d.Store).WithMany(p => p.MMrpStoresProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_mrp_StoresProducts_m_mrp_Stores");
        });

        modelBuilder.Entity<MOpeningStockTemp>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__m_Openin__BC789CF234902501");
        });

        modelBuilder.Entity<MPatientAccountAdditionalCharge>(entity =>
        {
            entity.HasKey(e => e.AdditionalChargeId).HasName("PK_[t_PatientAccountAdditionalCharges");

            entity.HasOne(d => d.Facility).WithMany(p => p.MPatientAccountAdditionalCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAdditionalCharges_m_Facility");
        });

        modelBuilder.Entity<MPatientAccountAdditionalChargesAssociation>(entity =>
        {
            entity.HasKey(e => e.AssociationId).HasName("PK_t_PatientAccountAdditionalChargesAssociation");

            entity.HasOne(d => d.AdditionalCharge).WithMany(p => p.MPatientAccountAdditionalChargesAssociations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAdditionalChargesAssociation_t_PatientAccountAdditionalCharges");

            entity.HasOne(d => d.Indicator).WithMany(p => p.MPatientAccountAdditionalChargesAssociations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAdditionalChargesAssociation_m_GeneralLookup");
        });

        modelBuilder.Entity<MPatientAccountAdditionalChargesRule>(entity =>
        {
            entity.HasKey(e => e.AdditionalChargeRuleId).HasName("PK_t_PatientAccountAdditionalChargesRule");

            entity.HasOne(d => d.AdditionalCharge).WithMany(p => p.MPatientAccountAdditionalChargesRules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAdditionalChargesRule_t_PatientAccountAdditionalCharges");
        });

        modelBuilder.Entity<MPatientAccountAdditionalChargesSurgery>(entity =>
        {
            entity.HasKey(e => e.SurgeryRuleId).HasName("PK_t_PatientAccountAdditionalChargesSurgery");

            entity.HasOne(d => d.AdditionalCharge).WithMany(p => p.MPatientAccountAdditionalChargesSurgeries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAdditionalChargesSurgery_t_PatientAccountAdditionalCharges");

            entity.HasOne(d => d.AnesthesiaChargeType).WithMany(p => p.MPatientAccountAdditionalChargesSurgeryAnesthesiaChargeTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAdditionalChargesSurgery_m_GeneralLookup1");

            entity.HasOne(d => d.AnesthesiaType).WithMany(p => p.MPatientAccountAdditionalChargesSurgeryAnesthesiaTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAdditionalChargesSurgery_m_GeneralLookup");

            entity.HasOne(d => d.ChargeEntryCatalog).WithMany(p => p.MPatientAccountAdditionalChargesSurgeryChargeEntryCatalogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAdditionalChargesSurgery_m_BillServices");

            entity.HasOne(d => d.DependOnService).WithMany(p => p.MPatientAccountAdditionalChargesSurgeryDependOnServices).HasConstraintName("FK_t_PatientAccountAdditionalChargesSurgery_m_BillServices1");
        });

        modelBuilder.Entity<MPatientAccountWardCharge>(entity =>
        {
            entity.HasKey(e => e.ChargeId).HasName("PK_m_PatientAccountChargeSetup");
        });

        modelBuilder.Entity<MPatientDischargeClearanceSetUp>(entity =>
        {
            entity.HasKey(e => e.DischargeClearanceSetUpId).HasName("PK_m_DischargeClearanceSetUp");

            entity.HasOne(d => d.ClearanceType).WithMany(p => p.MPatientDischargeClearanceSetUpClearanceTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_DischargeClearanceSetUp_m_GeneralLookup");

            entity.HasOne(d => d.Facility).WithMany(p => p.MPatientDischargeClearanceSetUps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_DischargeClearanceSetUp_m_Facility");

            entity.HasOne(d => d.PatientType).WithMany(p => p.MPatientDischargeClearanceSetUpPatientTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_PatientDischargeClearanceSetUp_m_GeneralLookup");
        });

        modelBuilder.Entity<MPatientsIdentification>(entity =>
        {
            entity.HasKey(e => e.PatientIdentityId).HasName("PK_m_patient_identification");

            entity.HasOne(d => d.Identification).WithMany(p => p.MPatientsIdentifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_patient_identification_m_GeneralLookup");

            entity.HasOne(d => d.Patient).WithMany(p => p.MPatientsIdentifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_patient_identification_m_patients_registration");
        });

        modelBuilder.Entity<MPatientsRegistration>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK_m_patients_registration");

            entity.Property(e => e.PermanentPin).IsFixedLength();

            entity.HasOne(d => d.BloodGroupNavigation).WithMany(p => p.MPatientsRegistrationBloodGroupNavigations).HasConstraintName("FK_m_patients_registration_m_GeneralLookup7");

            entity.HasOne(d => d.Ethnicity).WithMany(p => p.MPatientsRegistrationEthnicities).HasConstraintName("FK_m_patients_registration_m_GeneralLookup6");

            entity.HasOne(d => d.FhTitleNavigation).WithMany(p => p.MPatientsRegistrationFhTitleNavigations).HasConstraintName("FK_m_patients_registration_m_GeneralLookup1");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.MPatientsRegistrationGenderNavigations).HasConstraintName("FK_m_patients_registration_m_GeneralLookup2");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.MPatientsRegistrationMaritalStatusNavigations).HasConstraintName("FK_m_patients_registration_m_GeneralLookup3");

            entity.HasOne(d => d.PatientTitleNavigation).WithMany(p => p.MPatientsRegistrationPatientTitleNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_patients_registration_m_GeneralLookup");

            entity.HasOne(d => d.PermanentArea).WithMany(p => p.MPatientsRegistrationPermanentAreas).HasConstraintName("FK_m_patients_registration_m_Area1");

            entity.HasOne(d => d.PresentArea).WithMany(p => p.MPatientsRegistrationPresentAreas).HasConstraintName("FK_m_patients_registration_m_Area");

            entity.HasOne(d => d.PrimaryLanguage).WithMany(p => p.MPatientsRegistrationPrimaryLanguages).HasConstraintName("FK_m_patients_registration_m_GeneralLookup4");

            entity.HasOne(d => d.Religion).WithMany(p => p.MPatientsRegistrationReligions).HasConstraintName("FK_m_patients_registration_m_GeneralLookup5");
        });

        modelBuilder.Entity<MPayerIdentification>(entity =>
        {
            entity.HasOne(d => d.Identification).WithMany(p => p.MPayerIdentifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_PayerIdentification_m_GeneralLookup");

            entity.HasOne(d => d.Payer).WithMany(p => p.MPayerIdentifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_PayerIdentification_m_PayerRegistration");
        });

        modelBuilder.Entity<MPayerRegistration>(entity =>
        {
            entity.HasOne(d => d.Country).WithMany(p => p.MPayerRegistrationCountries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_PayerRegistration_m_GeneralLookup1");

            entity.HasOne(d => d.PayerType).WithMany(p => p.MPayerRegistrationPayerTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_PayerRegistration_m_GeneralLookup");

            entity.HasOne(d => d.State).WithMany(p => p.MPayerRegistrations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_PayerRegistration_m_States");
        });

        modelBuilder.Entity<MPlace>(entity =>
        {
            entity.HasOne(d => d.State).WithMany(p => p.MPlaces)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Places_m_States");
        });

        modelBuilder.Entity<MProductClasssifcation>(entity =>
        {
            entity.HasOne(d => d.ProductGroup).WithMany(p => p.MProductClasssifcations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductClasssifcation_m_GeneralLookup");
        });

        modelBuilder.Entity<MProductDefinition>(entity =>
        {
            entity.HasOne(d => d.Manufacturer).WithMany(p => p.MProductDefinitions).HasConstraintName("FK_m_ProductDefinition_m_Vendors");

            entity.HasOne(d => d.OrderDefaultFrequencyNavigation).WithMany(p => p.MProductDefinitionOrderDefaultFrequencyNavigations).HasConstraintName("FK_m_ProductDefinition_m_GeneralLookup");

            entity.HasOne(d => d.OrderRouteNavigation).WithMany(p => p.MProductDefinitionOrderRouteNavigations).HasConstraintName("FK_m_ProductDefinition_m_GeneralLookup1");

            entity.HasOne(d => d.OrderUomNavigation).WithMany(p => p.MProductDefinitionOrderUomNavigations).HasConstraintName("FK_m_ProductDefinition_m_UOM1");

            entity.HasOne(d => d.ProductClassification).WithMany(p => p.MProductDefinitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductDefinition_m_ProductClasssifcation");

            entity.HasOne(d => d.UomprimaryUomNavigation).WithMany(p => p.MProductDefinitionUomprimaryUomNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductDefinition_m_UOM");
        });

        modelBuilder.Entity<MProductOrdering>(entity =>
        {
            entity.HasOne(d => d.EndAgeUomNavigation).WithMany(p => p.MProductOrderingEndAgeUomNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductOrdering_m_UOM1");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.MProductOrderings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductOrdering_m_GeneralLookup");

            entity.HasOne(d => d.Product).WithMany(p => p.MProductOrderings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductOrdering_m_ProductDefinition");

            entity.HasOne(d => d.StartAgeUomNavigation).WithMany(p => p.MProductOrderingStartAgeUomNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductOrdering_m_UOM");
        });

        modelBuilder.Entity<MProductStock>(entity =>
        {
            entity.HasOne(d => d.DrugFormNavigation).WithMany(p => p.MProductStocks).HasConstraintName("FK_m_ProductStock_m_GeneralLookup");

            entity.HasOne(d => d.Product).WithMany(p => p.MProductStocks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductStock_m_ProductDefinition");
        });

        modelBuilder.Entity<MProductUom>(entity =>
        {
            entity.HasOne(d => d.AlternateUomNavigation).WithMany(p => p.MProductUomAlternateUomNavigations).HasConstraintName("FK_m_ProductUOM_m_UOM");

            entity.HasOne(d => d.EquivalentUomNavigation).WithMany(p => p.MProductUomEquivalentUomNavigations).HasConstraintName("FK_m_ProductUOM_m_UOM1");

            entity.HasOne(d => d.Product).WithMany(p => p.MProductUoms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProductUOM_m_ProductDefinition");
        });

        modelBuilder.Entity<MProvider>(entity =>
        {
            entity.HasOne(d => d.ConsultantType).WithMany(p => p.MProviderConsultantTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Providers_m_GeneralLookup3");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.MProviderGenderNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Providers_m_GeneralLookup1");

            entity.HasOne(d => d.PermanentArea).WithMany(p => p.MProviderPermanentAreas).HasConstraintName("FK_m_Providers_m_Area1");

            entity.HasOne(d => d.PresentArea).WithMany(p => p.MProviderPresentAreas).HasConstraintName("FK_m_Providers_m_Area");

            entity.HasOne(d => d.ProviderTitleNavigation).WithMany(p => p.MProviderProviderTitleNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Providers_m_GeneralLookup");

            entity.HasOne(d => d.StructuralRole).WithMany(p => p.MProviderStructuralRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Providers_m_GeneralLookup2");
        });

        modelBuilder.Entity<MProviderCredential>(entity =>
        {
            entity.HasOne(d => d.Credential).WithMany(p => p.MProviderCredentials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProviderCredential_m_GeneralLookup");

            entity.HasOne(d => d.Provider).WithMany(p => p.MProviderCredentials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProviderCredential_m_Providers");
        });

        modelBuilder.Entity<MProviderIdentification>(entity =>
        {
            entity.HasOne(d => d.Identification).WithMany(p => p.MProviderIdentifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProviderIdentification_m_GeneralLookup");

            entity.HasOne(d => d.Provider).WithMany(p => p.MProviderIdentifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ProviderIdentification_m_Providers");
        });

        modelBuilder.Entity<MReferral>(entity =>
        {
            entity.HasOne(d => d.Area).WithMany(p => p.MReferrals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Referrals_m_Area");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.MReferralGenderNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Referrals_m_GeneralLookup2");

            entity.HasOne(d => d.ReferrerTitleNavigation).WithMany(p => p.MReferralReferrerTitleNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Referrals_m_GeneralLookup1");

            entity.HasOne(d => d.ReferrerTypeNavigation).WithMany(p => p.MReferralReferrerTypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Referrals_m_GeneralLookup");
        });

        modelBuilder.Entity<MScheduleAvailabilityCalendar>(entity =>
        {
            entity.HasKey(e => e.AvailabilityCalendarId).HasName("PK_m_schedule_availability_calendar");

            entity.HasOne(d => d.Facility).WithMany(p => p.MScheduleAvailabilityCalendars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_schedule_availability_calendar_m_Facility");

            entity.HasOne(d => d.Provider).WithMany(p => p.MScheduleAvailabilityCalendars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_schedule_availability_calendar_m_Providers");

            entity.HasOne(d => d.Template).WithMany(p => p.MScheduleAvailabilityCalendars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_schedule_availability_calendar_m_ScheduleTemplate");
        });

        modelBuilder.Entity<MScheduleFacilityHoliday>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MScheduleFacilityHolidays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScheduleFacilityHoliday_m_Facility");
        });

        modelBuilder.Entity<MScheduleProvider>(entity =>
        {
            entity.HasKey(e => e.ProviderScheduleId).HasName("PK_m_schedule_provider");

            entity.HasOne(d => d.Facility).WithMany(p => p.MScheduleProviders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_schedule_provider_m_Facility");

            entity.HasOne(d => d.Provider).WithMany(p => p.MScheduleProviders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_schedule_provider_m_Providers");

            entity.HasOne(d => d.Template).WithMany(p => p.MScheduleProviders).HasConstraintName("FK_m_schedule_provider_m_ScheduleTemplate");

            entity.HasOne(d => d.WeekDayNavigation).WithMany(p => p.MScheduleProviderWeekDayNavigations).HasConstraintName("FK_m_schedule_provider_m_GeneralLookup2");

            entity.HasOne(d => d.WeekDayFrequencyNavigation).WithMany(p => p.MScheduleProviderWeekDayFrequencyNavigations).HasConstraintName("FK_m_schedule_provider_m_GeneralLookup3");

            entity.HasOne(d => d.Weekday).WithMany(p => p.MScheduleProviderWeekdays).HasConstraintName("FK_m_schedule_provider_m_GeneralLookup");
        });

        modelBuilder.Entity<MScheduleProviderAbsence>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MScheduleProviderAbsences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScheduleProviderAbsence_m_Facility");

            entity.HasOne(d => d.Provider).WithMany(p => p.MScheduleProviderAbsences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScheduleProviderAbsence_m_Providers");
        });

        modelBuilder.Entity<MScheduleSpecialEvent>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MScheduleSpecialEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScheduleSpecialEvents_m_Facility");
        });

        modelBuilder.Entity<MScheduleTemplate>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MScheduleTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScheduleTemplate_m_Facility");
        });

        modelBuilder.Entity<MScheduleTemplateSession>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.MScheduleTemplateSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScheduleTemplateSession_m_Facility");

            entity.HasOne(d => d.Template).WithMany(p => p.MScheduleTemplateSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScheduleTemplateSession_m_ScheduleTemplate");
        });

        modelBuilder.Entity<MScreenField>(entity =>
        {
            entity.HasKey(e => e.ScreenFieldId).HasName("PK__m_Screen__17AE2385559A8595");

            entity.HasOne(d => d.Facility).WithMany(p => p.MScreenFields)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScreenField_m_Facility");

            entity.HasOne(d => d.Field).WithMany(p => p.MScreenFields)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScreenField_m_Field");

            entity.HasOne(d => d.Screen).WithMany(p => p.MScreenFields)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ScreenField_m_Screen");
        });

        modelBuilder.Entity<MServiceLabAttribute>(entity =>
        {
            entity.HasKey(e => e.LabAttributeId).HasName("PK__m_Servic__C98A69D4339F558F");

            entity.HasOne(d => d.AdditionalContainer).WithMany(p => p.MServiceLabAttributeAdditionalContainers).HasConstraintName("FK_m_ServiceLabAttributes_m_GeneralLookup2");

            entity.HasOne(d => d.ContainerType).WithMany(p => p.MServiceLabAttributeContainerTypes).HasConstraintName("FK_m_ServiceLabAttributes_m_GeneralLookup1");

            entity.HasOne(d => d.Service).WithMany(p => p.MServiceLabAttributes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServiceLabAttributes_m_BillServices");

            entity.HasOne(d => d.SpecimenPrep).WithMany(p => p.MServiceLabAttributeSpecimenPreps).HasConstraintName("FK_m_ServiceLabAttributes_m_GeneralLookup");

            entity.HasOne(d => d.StorageUomNavigation).WithMany(p => p.MServiceLabAttributeStorageUomNavigations).HasConstraintName("FK_m_ServiceLabAttributes_m_UOM1");

            entity.HasOne(d => d.VolumeUomNavigation).WithMany(p => p.MServiceLabAttributeVolumeUomNavigations).HasConstraintName("FK_m_ServiceLabAttributes_m_UOM");
        });

        modelBuilder.Entity<MServiceLocation>(entity =>
        {
            entity.HasKey(e => e.ServiceLocationId).HasName("PK_m_SeviceLocations");

            entity.HasOne(d => d.ServiceLocationType).WithMany(p => p.MServiceLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_SeviceLocations_m_GeneralLookup");
        });

        modelBuilder.Entity<MServiceMedicalCode>(entity =>
        {
            entity.HasKey(e => e.MedicalCodeId).HasName("PK__m_Servic__56850A840EE39D31");

            entity.HasOne(d => d.MedicalCodeType).WithMany(p => p.MServiceMedicalCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServiceMedicalCodes_m_GeneralLookup");

            entity.HasOne(d => d.Service).WithMany(p => p.MServiceMedicalCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServiceMedicalCodes_m_BillServices");
        });

        modelBuilder.Entity<MServiceOrdering>(entity =>
        {
            entity.HasKey(e => e.ServiceOrderAttributeId).HasName("PK__m_Servic__1F3C64B15631A463");

            entity.HasOne(d => d.EndAgeUomNavigation).WithMany(p => p.MServiceOrderingEndAgeUomNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServiceOrdering_m_UOM1");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.MServiceOrderings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServiceOrdering_m_GeneralLookup");

            entity.HasOne(d => d.Service).WithMany(p => p.MServiceOrderings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServiceOrdering_m_BillServices");

            entity.HasOne(d => d.StartAgeUomNavigation).WithMany(p => p.MServiceOrderingStartAgeUomNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServiceOrdering_m_UOM");
        });

        modelBuilder.Entity<MServicePackage>(entity =>
        {
            entity.HasKey(e => e.ServicePackageId).HasName("PK__m_Servic__0747A82FF1B88A6D");

            entity.HasOne(d => d.Indicator).WithMany(p => p.MServicePackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServicePackage_m_GeneralLookup");

            entity.HasOne(d => d.Service).WithMany(p => p.MServicePackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServicePackage_m_BillServices");

            entity.HasOne(d => d.ServiceUomNavigation).WithMany(p => p.MServicePackages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServicePackage_m_UOM");
        });

        modelBuilder.Entity<MServiceTat>(entity =>
        {
            entity.HasKey(e => e.TatId).HasName("PK__m_Servic__683A536A539A3206");

            entity.HasOne(d => d.Service).WithMany(p => p.MServiceTats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_ServiceTat_m_BillServices");

            entity.HasOne(d => d.TatUomNavigation).WithMany(p => p.MServiceTats).HasConstraintName("FK_m_ServiceTat_m_UOM");
        });

        modelBuilder.Entity<MState>(entity =>
        {
            entity.HasOne(d => d.Country).WithMany(p => p.MStates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_States_m_GeneralLookup");
        });

        modelBuilder.Entity<MSubMenuActivity>(entity =>
        {
            entity.HasOne(d => d.Menu).WithMany(p => p.MSubMenuActivities).HasConstraintName("FK_m_SubMenu_Activity_m_Menu");
        });

        modelBuilder.Entity<MSubMenuChild>(entity =>
        {
            entity.HasKey(e => e.SubMenuChildId).HasName("PK_m_SubMenu_Child_1");

            entity.Property(e => e.SubMenuChildId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MTestReferance>(entity =>
        {
            entity.HasKey(e => e.TestRefId).HasName("PK_m");
        });

        modelBuilder.Entity<MUser>(entity =>
        {
            entity.Property(e => e.IsActive).IsFixedLength();
            entity.Property(e => e.LoginPassword).IsFixedLength();

            entity.HasOne(d => d.Facility).WithMany(p => p.MUsers).HasConstraintName("FK_m_User_m_Facility");
        });

        modelBuilder.Entity<MUserRegistration>(entity =>
        {
            entity.HasKey(e => e.UserRegistrationId).HasName("PK_m_UserRegistration_1");
        });

        modelBuilder.Entity<MVendor>(entity =>
        {
            entity.HasOne(d => d.AreaNavigation).WithMany(p => p.MVendors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Vendors_m_Area");

            entity.HasOne(d => d.Country).WithMany(p => p.MVendors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Vendors_m_GeneralLookup");

            entity.HasOne(d => d.PlaceNavigation).WithMany(p => p.MVendors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Vendors_m_Places");

            entity.HasOne(d => d.State).WithMany(p => p.MVendors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_Vendors_m_States");
        });

        modelBuilder.Entity<MWard>(entity =>
        {
            entity.HasKey(e => e.WardId).HasName("PK_m_ward");

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.MWardGenderNavigations).HasConstraintName("FK_m_Ward_m_GeneralLookup1");

            entity.HasOne(d => d.WardCategory).WithMany(p => p.MWardWardCategories).HasConstraintName("FK_m_Ward_m_GeneralLookup");
        });

        modelBuilder.Entity<MWorkFlowScreen>(entity =>
        {
            entity.HasOne(d => d.Screen).WithMany(p => p.MWorkFlowScreens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_WorkFlowScreen_m_Screen");

            entity.HasOne(d => d.WorkFlow).WithMany(p => p.MWorkFlowScreens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_WorkFlowScreen_m_WorkFlow");
        });

        modelBuilder.Entity<MWorkFlowScreenParameter>(entity =>
        {
            entity.HasOne(d => d.Parameter).WithMany(p => p.MWorkFlowScreenParameters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_WorkFlowScreenParameter_m_Parameter");

            entity.HasOne(d => d.WorkFlowScreen).WithMany(p => p.MWorkFlowScreenParameters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_m_WorkFlowScreenParameter_m_WorkFlowScreen");
        });

        modelBuilder.Entity<Prod>(entity =>
        {
            entity.Property(e => e.ActiveFlag).IsFixedLength();
        });

        modelBuilder.Entity<TAntenatalVitalsLine>(entity =>
        {
            entity.HasKey(e => e.AvlineId).HasName("PK__t_Antena__B5C10D5540AE456A");
        });

        modelBuilder.Entity<TAttachClinicalFile>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PK_t_AtachClinicalFiles");
        });

        modelBuilder.Entity<TClinicalRisk>(entity =>
        {
            entity.HasKey(e => e.RiskId).HasName("PK_t_ClinicalRisks_RiskId");
        });

        modelBuilder.Entity<TDischargeSummary>(entity =>
        {
            entity.HasKey(e => e.DischargeSummaryId).HasName("PK_t_Discharge Summary");
        });

        modelBuilder.Entity<TDrugChart>(entity =>
        {
            entity.HasKey(e => e.DrugChartId).HasName("PK_t_DrugChart1");
        });

        modelBuilder.Entity<TEncounter>(entity =>
        {
            entity.HasOne(d => d.Bed).WithMany(p => p.TEncounters).HasConstraintName("FK_t_Encounter_m_Bed");

            entity.HasOne(d => d.EncounterCancelReason).WithMany(p => p.TEncounterEncounterCancelReasons).HasConstraintName("FK_t_Encounter_m_GeneralLookup4");

            entity.HasOne(d => d.EncounterEditReason).WithMany(p => p.TEncounterEncounterEditReasons).HasConstraintName("FK_t_Encounter_m_GeneralLookup3");

            entity.HasOne(d => d.EncounterReason).WithMany(p => p.TEncounterEncounterReasons).HasConstraintName("FK_t_Encounter_m_GeneralLookup2");

            entity.HasOne(d => d.EncounterType).WithMany(p => p.TEncounterEncounterTypes).HasConstraintName("FK_t_Encounter_m_GeneralLookup1");

            entity.HasOne(d => d.Facility).WithMany(p => p.TEncounters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_Encounter_m_Facility");

            entity.HasOne(d => d.PatientTypeNavigation).WithMany(p => p.TEncounterPatientTypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_Encounter_m_GeneralLookup");

            entity.HasOne(d => d.SecondaryProvider).WithMany(p => p.TEncounters).HasConstraintName("FK_t_Encounter_m_Providers");

            entity.HasOne(d => d.WardCategory).WithMany(p => p.TEncounterWardCategories).HasConstraintName("FK_t_Encounter_m_GeneralLookup5");

            entity.HasOne(d => d.Ward).WithMany(p => p.TEncounters).HasConstraintName("FK_t_Encounter_m_Ward");
        });

        modelBuilder.Entity<TPatientAccountAssignedPlan>(entity =>
        {
            entity.HasOne(d => d.EligibleWardType).WithMany(p => p.TPatientAccountAssignedPlans).HasConstraintName("FK_t_PatientAccountAssignedPlan_m_GeneralLookup");

            entity.HasOne(d => d.Employer).WithMany(p => p.TPatientAccountAssignedPlanEmployers).HasConstraintName("FK_t_PatientAccountAssignedPlan_m_PayerRegistration1");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountAssignedPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAssignedPlan_t_Encounter");

            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientAccountAssignedPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAssignedPlan_m_Facility");

            entity.HasOne(d => d.Insurer).WithMany(p => p.TPatientAccountAssignedPlanInsurers).HasConstraintName("FK_t_PatientAccountAssignedPlan_m_PayerRegistration2");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientAccountAssignedPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAssignedPlan_m_PatientsRegistration");

            entity.HasOne(d => d.Payer).WithMany(p => p.TPatientAccountAssignedPlanPayers).HasConstraintName("FK_t_PatientAccountAssignedPlan_m_PayerRegistration");

            entity.HasOne(d => d.TariffPlan).WithMany(p => p.TPatientAccountAssignedPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAssignedPlan_m_BillPriceTariff");
        });

        modelBuilder.Entity<TPatientAccountAssignedPlanAuthorization>(entity =>
        {
            entity.HasOne(d => d.AssignedPlan).WithMany(p => p.TPatientAccountAssignedPlanAuthorizations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAssignedPlanAuthorization_t_PatientAccountAssignedPlan");
        });

        modelBuilder.Entity<TPatientAccountAuthorizationLine>(entity =>
        {
            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.TPatientAccountAuthorizationLineGenderNavigations).HasConstraintName("FK_t_PatientAccountAuthorizationLine_m_GeneralLookup2");

            entity.HasOne(d => d.IndicatorNavigation).WithMany(p => p.TPatientAccountAuthorizationLineIndicatorNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAuthorizationLine_m_GeneralLookup4");

            entity.HasOne(d => d.NationalityNavigation).WithMany(p => p.TPatientAccountAuthorizationLineNationalityNavigations).HasConstraintName("FK_t_PatientAccountAuthorizationLine_m_GeneralLookup3");

            entity.HasOne(d => d.PatientType).WithMany(p => p.TPatientAccountAuthorizationLinePatientTypes).HasConstraintName("FK_t_PatientAccountAuthorizationLine_m_GeneralLookup1");

            entity.HasOne(d => d.PayerNavigation).WithMany(p => p.TPatientAccountAuthorizationLines).HasConstraintName("FK_t_PatientAccountAuthorizationLine_m_PayerRegistration");

            entity.HasOne(d => d.PlanAuth).WithMany(p => p.TPatientAccountAuthorizationLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountAuthorizationLine_t_PatientAccountAssignedPlanAuthorization");

            entity.HasOne(d => d.ProviderNavigation).WithMany(p => p.TPatientAccountAuthorizationLines).HasConstraintName("FK_t_PatientAccountAuthorizationLine_m_Providers");

            entity.HasOne(d => d.WardType).WithMany(p => p.TPatientAccountAuthorizationLineWardTypes).HasConstraintName("FK_t_PatientAccountAuthorizationLine_m_GeneralLookup");
        });

        modelBuilder.Entity<TPatientAccountBill>(entity =>
        {
            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountBills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountBill_t_Encounter");

            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientAccountBills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountBill_m_Facility");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientAccountBills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountBill_m_PatientsRegistration1");

            entity.HasOne(d => d.PreparedByNavigation).WithMany(p => p.TPatientAccountBills).HasConstraintName("FK_t_PatientAccountBill_m_Providers");
        });

        modelBuilder.Entity<TPatientAccountCharge>(entity =>
        {
            entity.Property(e => e.BillType).IsFixedLength();
            entity.Property(e => e.ServiceType).IsFixedLength();

            entity.HasOne(d => d.AgreementLine).WithMany(p => p.TPatientAccountCharges).HasConstraintName("FK__t_Patient__Agree__369C13AA");

            entity.HasOne(d => d.ChargeableWardTypeNavigation).WithMany(p => p.TPatientAccountChargeChargeableWardTypeNavigations).HasConstraintName("FK_t_PatientAccountCharge_m_GeneralLookup3");

            entity.HasOne(d => d.Department).WithMany(p => p.TPatientAccountCharges).HasConstraintName("FK_t_PatientAccountCharge_m_FacilityDepartment");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountCharge_t_Encounter");

            entity.HasOne(d => d.Facillity).WithMany(p => p.TPatientAccountChargeFacillities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountCharge_m_Facility");

            entity.HasOne(d => d.PatientBill).WithMany(p => p.TPatientAccountCharges).HasConstraintName("FK__t_Patient__Patie__38845C1C");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientAccountCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountCharge_m_PatientsRegistration");

            entity.HasOne(d => d.PatientType).WithMany(p => p.TPatientAccountChargePatientTypes).HasConstraintName("FK_t_PatientAccountCharge_m_GeneralLookup1");

            entity.HasOne(d => d.PerformingFacility).WithMany(p => p.TPatientAccountChargePerformingFacilities).HasConstraintName("FK_t_PatientAccountCharge_m_Facility1");

            entity.HasOne(d => d.Provider).WithMany(p => p.TPatientAccountCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountCharge_m_Providers");

            entity.HasOne(d => d.ServiceGroup).WithMany(p => p.TPatientAccountChargeServiceGroups).HasConstraintName("FK_t_PatientAccountCharge_m_GeneralLookup");

            entity.HasOne(d => d.ServiceUomNavigation).WithMany(p => p.TPatientAccountCharges).HasConstraintName("FK_t_PatientAccountCharge_m_UOM");

            entity.HasOne(d => d.WardTypeNavigation).WithMany(p => p.TPatientAccountChargeWardTypeNavigations).HasConstraintName("FK_t_PatientAccountCharge_m_GeneralLookup2");
        });

        modelBuilder.Entity<TPatientAccountChargeAttribute>(entity =>
        {
            entity.HasKey(e => e.ChargeAttributeId).HasName("ChargeAttributeId");

            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientAccountChargeAttributes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountChargeAttribute_m_Facility");

            entity.HasOne(d => d.WardTypeNavigation).WithMany(p => p.TPatientAccountChargeAttributes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountChargeAttribute_m_GeneralLookup");
        });

        modelBuilder.Entity<TPatientAccountDefaultTariff>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientAccountDefaultTariffs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountDefaultTariff_m_Facility");

            entity.HasOne(d => d.PatientType).WithMany(p => p.TPatientAccountDefaultTariffs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountDefaultTariff_m_GeneralLookup");

            entity.HasOne(d => d.Payer).WithMany(p => p.TPatientAccountDefaultTariffs).HasConstraintName("FK_t_PatientAccountDefaultTariff_m_PayerRegistration");

            entity.HasOne(d => d.PriceTariff).WithMany(p => p.TPatientAccountDefaultTariffs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountDefaultTariff_m_BillPriceTariff");
        });

        modelBuilder.Entity<TPatientAccountDepositDefinition>(entity =>
        {
            entity.HasOne(d => d.AccommodationTypeNavigation).WithMany(p => p.TPatientAccountDepositDefinitionAccommodationTypeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountDepositDefinition_m_GeneralLookup");

            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientAccountDepositDefinitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountDepositDefinition_m_Facility");

            entity.HasOne(d => d.PatientType).WithMany(p => p.TPatientAccountDepositDefinitionPatientTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountDepositDefinition_m_GeneralLookup1");
        });

        modelBuilder.Entity<TPatientAccountLedger>(entity =>
        {
            entity.HasKey(e => e.PatientLedgerId).HasName("PK__t_Patien__CAC348D8702449CB");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountLedgers).HasConstraintName("FK__t_Patient__Encou__53385258");

            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientAccountLedgers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__t_Patient__Facil__55209ACA");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientAccountLedgers).HasConstraintName("FK__t_Patient__Patie__5708E33C");
        });

        modelBuilder.Entity<TPatientAccountOrder>(entity =>
        {
            entity.HasOne(d => d.AcknowledgedByNavigation).WithMany(p => p.TPatientAccountOrders).HasConstraintName("FK_t_PatientAccountOrders_m_Providers");

            entity.HasOne(d => d.Department).WithMany(p => p.TPatientAccountOrders).HasConstraintName("FK_t_PatientAccountOrders_m_FacilityDepartment");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountOrders_t_Encounter");

            entity.HasOne(d => d.OrderStatusNavigation).WithMany(p => p.TPatientAccountOrderOrderStatusNavigations).HasConstraintName("FK_t_PatientAccountOrders_m_GeneralLookup1");

            entity.HasOne(d => d.OrderingFacility).WithMany(p => p.TPatientAccountOrderOrderingFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountOrders_m_Facility");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientAccountOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountOrders_m_PatientsRegistration");

            entity.HasOne(d => d.PatientType).WithMany(p => p.TPatientAccountOrderPatientTypes).HasConstraintName("FK_t_PatientAccountOrders_m_GeneralLookup2");

            entity.HasOne(d => d.PerformingFacility).WithMany(p => p.TPatientAccountOrderPerformingFacilities).HasConstraintName("FK_t_PatientAccountOrders_m_Facility1");

            entity.HasOne(d => d.ServiceClassification).WithMany(p => p.TPatientAccountOrders).HasConstraintName("FK_t_PatientAccountOrders_m_BillServiceClasssifcation");

            entity.HasOne(d => d.ServiceGroup).WithMany(p => p.TPatientAccountOrderServiceGroups).HasConstraintName("FK_t_PatientAccountOrders_m_GeneralLookup");

            entity.HasOne(d => d.Service).WithMany(p => p.TPatientAccountOrders).HasConstraintName("FK_t_PatientAccountOrders_m_BillServices");
        });

        modelBuilder.Entity<TPatientAccountPackageSubscription>(entity =>
        {
            entity.HasKey(e => e.PackageSubsId).HasName("PK__t_Patien__33781715BF40CC0B");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountPackageSubscriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__t_Patient__Encou__636EBA21");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientAccountPackageSubscriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__t_Patient__Patie__65570293");

            entity.HasOne(d => d.Provider).WithMany(p => p.TPatientAccountPackageSubscriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__t_Patient__Provi__673F4B05");

            entity.HasOne(d => d.ServicePackage).WithMany(p => p.TPatientAccountPackageSubscriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__t_Patient__Servi__69279377");
        });

        modelBuilder.Entity<TPatientAccountProcedureCharge>(entity =>
        {
            entity.HasOne(d => d.AnesthesiaTypeCharge).WithMany(p => p.TPatientAccountProcedureChargeAnesthesiaTypeCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountProcedureCharges_m_GeneralLookup1");

            entity.HasOne(d => d.AnesthesiaType).WithMany(p => p.TPatientAccountProcedureChargeAnesthesiaTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountProcedureCharges_m_GeneralLookup");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountProcedureCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountProcedureCharges_t_Encounter");

            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientAccountProcedureCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountProcedureCharges_m_Facility");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientAccountProcedureCharges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountProcedureCharges_m_PatientsRegistration");

            entity.HasOne(d => d.Procedure).WithMany(p => p.TPatientAccountProcedureCharges).HasConstraintName("FK_t_PatientAccountProcedureCharges_m_BillServices");

            entity.HasOne(d => d.Provider).WithMany(p => p.TPatientAccountProcedureCharges).HasConstraintName("FK_t_PatientAccountProcedureCharges_m_Providers");
        });

        modelBuilder.Entity<TPatientAccountProcedureChargesDetail>(entity =>
        {
            entity.HasOne(d => d.AssociativeService).WithMany(p => p.TPatientAccountProcedureChargesDetails).HasConstraintName("FK_t_PatientAccountProcedureChargesDetails_m_BillServices");

            entity.HasOne(d => d.ProcedureCharge).WithMany(p => p.TPatientAccountProcedureChargesDetails).HasConstraintName("FK_t_PatientAccountProcedureChargesDetails_t_PatientAccountProcedureCharges");

            entity.HasOne(d => d.Provider).WithMany(p => p.TPatientAccountProcedureChargesDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountProcedureChargesDetails_m_Providers");
        });

        modelBuilder.Entity<TPatientAccountReFundHeader>(entity =>
        {
            entity.HasKey(e => e.ReFundId).HasName("PK_t_PatientAccountReFund");
        });

        modelBuilder.Entity<TPatientAccountReFundInstrument>(entity =>
        {
            entity.HasKey(e => e.ReFundModeId).HasName("PK_t_PatientAccountReFundInstunent");
        });

        modelBuilder.Entity<TPatientAccountReceiptAdjust>(entity =>
        {
            entity.HasKey(e => e.ReceiptAdjustId).HasName("PK__t_Patien__D4DEAAB1F66074ED");

            entity.HasOne(d => d.PatientBill).WithMany(p => p.TPatientAccountReceiptAdjusts).HasConstraintName("FK__t_Patient__Patie__74994623");

            entity.HasOne(d => d.ReceiptAllocation).WithMany(p => p.TPatientAccountReceiptAdjusts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__t_Patient__Recei__1B7E091A");
        });

        modelBuilder.Entity<TPatientAccountReceiptAllocation>(entity =>
        {
            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountReceiptAllocations).HasConstraintName("FK_t_PatientAccountReceiptAllocation_t_Encounter");

            entity.HasOne(d => d.Indicator).WithMany(p => p.TPatientAccountReceiptAllocationIndicators)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountReceiptAllocation_m_GeneralLookup");

            entity.HasOne(d => d.PatientType).WithMany(p => p.TPatientAccountReceiptAllocationPatientTypes).HasConstraintName("FK_t_PatientAccountReceiptAllocation_m_GeneralLookup1");

            entity.HasOne(d => d.Receipt).WithMany(p => p.TPatientAccountReceiptAllocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountReceiptAllocation_t_PatientAccountReceiptHeader");
        });

        modelBuilder.Entity<TPatientAccountReceiptInstrument>(entity =>
        {
            entity.HasOne(d => d.Bank).WithMany(p => p.TPatientAccountReceiptInstrumentBanks).HasConstraintName("FK_t_PatientAccountReceiptInstrument_m_GeneralLookup1");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientAccountReceiptInstruments).HasConstraintName("FK__t_Patient__Encou__7C3A67EB");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.TPatientAccountReceiptInstrumentPaymentTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountReceiptInstrument_m_GeneralLookup");

            entity.HasOne(d => d.Receipt).WithMany(p => p.TPatientAccountReceiptInstruments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientAccountReceiptInstrument_t_PatientAccountReceiptHeader");
        });

        modelBuilder.Entity<TPatientAccountRecurringCharge>(entity =>
        {
            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientAccountRecurringCharges).HasConstraintName("FK_t_PatientAccountRecurringCharge_m_Facility");

            entity.HasOne(d => d.PatientType).WithMany(p => p.TPatientAccountRecurringCharges).HasConstraintName("FK_t_PatientAccountRecurringCharge_m_GeneralLookup");

            entity.HasOne(d => d.Service).WithMany(p => p.TPatientAccountRecurringCharges).HasConstraintName("FK_t_PatientAccountRecurringCharge_m_BillServices");
        });

        modelBuilder.Entity<TPatientDischarge>(entity =>
        {
            entity.HasOne(d => d.Bed).WithMany(p => p.TPatientDischarges).HasConstraintName("FK_t_PatientDischarge_m_Bed");

            entity.HasOne(d => d.CancelApprovedByNavigation).WithMany(p => p.TPatientDischargeCancelApprovedByNavigations).HasConstraintName("FK_t_PatientDischarge_m_Providers1");

            entity.HasOne(d => d.CancelReasonNavigation).WithMany(p => p.TPatientDischargeCancelReasonNavigations).HasConstraintName("FK_t_PatientDischarge_m_GeneralLookup1");

            entity.HasOne(d => d.DischargeAdvisedByNavigation).WithMany(p => p.TPatientDischargeDischargeAdvisedByNavigations).HasConstraintName("FK_t_PatientDischarge_m_Providers");

            entity.HasOne(d => d.DispositionType).WithMany(p => p.TPatientDischargeDispositionTypes).HasConstraintName("FK_t_PatientDischarge_m_GeneralLookup");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TPatientDischarges).HasConstraintName("FK_t_PatientDischarge_t_Encounter");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientDischarges).HasConstraintName("FK_t_PatientDischarge_m_PatientsRegistration");
        });

        modelBuilder.Entity<TPatientDischargeClearance>(entity =>
        {
            entity.HasOne(d => d.ClearanceType).WithMany(p => p.TPatientDischargeClearances).HasConstraintName("FK_t_PatientDischargeClearance_m_GeneralLookup");

            entity.HasOne(d => d.Facility).WithMany(p => p.TPatientDischargeClearances).HasConstraintName("FK_m_Facility_t_PatientDischargeClearance");
        });

        modelBuilder.Entity<TPatientMovement>(entity =>
        {
            entity.HasOne(d => d.Bed).WithMany(p => p.TPatientMovements).HasConstraintName("FK_t_PatientMovement_m_Bed");

            entity.HasOne(d => d.Patient).WithMany(p => p.TPatientMovements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_PatientMovement_m_PatientsRegistration");
        });

        modelBuilder.Entity<TPatientVital>(entity =>
        {
            entity.Property(e => e.BloodPreasure).IsFixedLength();
            entity.Property(e => e.EncounterId).IsFixedLength();
            entity.Property(e => e.HeartRate).IsFixedLength();
            entity.Property(e => e.Height).IsFixedLength();
            entity.Property(e => e.Oxygensaturation).IsFixedLength();
            entity.Property(e => e.Position).IsFixedLength();
            entity.Property(e => e.RespiratoryRate).IsFixedLength();
            entity.Property(e => e.Temperature).IsFixedLength();
            entity.Property(e => e.Time).IsFixedLength();
            entity.Property(e => e.Weight).IsFixedLength();
        });

        modelBuilder.Entity<TQueue>(entity =>
        {
            entity.HasKey(e => e.Qid).HasName("PK_t_queue");

            entity.HasOne(d => d.Encounter).WithMany(p => p.TQueues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_Queue_t_Encounter");

            entity.HasOne(d => d.Facility).WithMany(p => p.TQueues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_queue_m_Facility");
        });

        modelBuilder.Entity<TSampleCollectionHeader>(entity =>
        {
            entity.Property(e => e.ChargeId).HasDefaultValueSql("('0')");
            entity.Property(e => e.IsResultEntryDone).HasDefaultValueSql("('0')");
            entity.Property(e => e.IsVerificationDone).HasDefaultValueSql("('0')");
        });

        modelBuilder.Entity<TScheduleProviderAppointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK_t_schedule_provider_appointment");

            entity.HasOne(d => d.AppointmentReason).WithMany(p => p.TScheduleProviderAppointmentAppointmentReasons).HasConstraintName("FK_t_schedule_provider_appointment_m_GeneralLookup");

            entity.HasOne(d => d.CancelAppointmentNavigation).WithMany(p => p.TScheduleProviderAppointmentCancelAppointmentNavigations).HasConstraintName("FK_t_ScheduleProviderAppointment_m_GeneralLookup1");

            entity.HasOne(d => d.Facility).WithMany(p => p.TScheduleProviderAppointments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_schedule_provider_appointment_m_Facility");

            entity.HasOne(d => d.Patient).WithMany(p => p.TScheduleProviderAppointments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_schedule_provider_appointment_m_patients_registration");

            entity.HasOne(d => d.Provider).WithMany(p => p.TScheduleProviderAppointments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_schedule_provider_appointment_m_Providers");

            entity.HasOne(d => d.TransferAppointmentNavigation).WithMany(p => p.TScheduleProviderAppointmentTransferAppointmentNavigations).HasConstraintName("FK_t_ScheduleProviderAppointment_m_GeneralLookup");
        });

        modelBuilder.Entity<TSeqTUser>(entity =>
        {
            entity.HasKey(e => e.Pkid).HasName("PK__t_Seq_t___5E028272D3773FEB");

            entity.Property(e => e.Pkid).ValueGeneratedNever();
            entity.Property(e => e.Incr).HasDefaultValueSql("((1))");
            entity.Property(e => e.Seed).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TSummaryCase>(entity =>
        {
            entity.Property(e => e.TimeinCatime).IsFixedLength();
            entity.Property(e => e.TimeoutCatime).IsFixedLength();
        });

        modelBuilder.Entity<TSummaryCatheter>(entity =>
        {
            entity.Property(e => e.CathetersDrainsSiteId).IsFixedLength();
        });

        modelBuilder.Entity<TSummaryIntraop>(entity =>
        {
            entity.Property(e => e.CaseTimeInTs).IsFixedLength();
            entity.Property(e => e.CaseTimeOutTs).IsFixedLength();
            entity.Property(e => e.ProcedureDuration).IsFixedLength();
            entity.Property(e => e.ProcedureEndTimeTs).IsFixedLength();
            entity.Property(e => e.ProcedureStartTimeTs).IsFixedLength();
        });

        modelBuilder.Entity<TSummaryPreop>(entity =>
        {
            entity.Property(e => e.PatientIh).IsFixedLength();
            entity.Property(e => e.PatientRfhtime).IsFixedLength();
            entity.Property(e => e.PatientRfptime).IsFixedLength();
            entity.Property(e => e.PreCatimeIn).IsFixedLength();
            entity.Property(e => e.PreCatimeOut).IsFixedLength();
            entity.Property(e => e.PreOittime).IsFixedLength();
            entity.Property(e => e.PreOottime).IsFixedLength();
        });

        modelBuilder.Entity<TSummaryPreopLine>(entity =>
        {
            entity.HasKey(e => e.PreopLineId).HasName("PK_t_SummaryPreopLinet");

            entity.Property(e => e.PreCatimeIn).IsFixedLength();
            entity.Property(e => e.PreCatimeOut).IsFixedLength();
        });

        modelBuilder.Entity<TTransaction>(entity =>
        {
            entity.HasKey(e => e.AdtId).HasName("PK_t_Adt_Transactions");

            entity.HasOne(d => d.FromBed).WithMany(p => p.TTransactionFromBeds).HasConstraintName("FK_t_Transactions_m_Bed");

            entity.HasOne(d => d.FromWardCategory).WithMany(p => p.TTransactionFromWardCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_Transactions_m_GeneralLookup1");

            entity.HasOne(d => d.Patient).WithMany(p => p.TTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_Transactions_m_PatientsRegistration");

            entity.HasOne(d => d.ToBed).WithMany(p => p.TTransactionToBeds).HasConstraintName("FK_t_Transactions_m_Bed1");

            entity.HasOne(d => d.ToWardCategory).WithMany(p => p.TTransactionToWardCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_t_Transactions_m_GeneralLookup2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
