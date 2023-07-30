using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_Providers")]
public partial class MProvider
{
    [Key]
    public int ProviderId { get; set; }

    public int ProviderTitle { get; set; }

    [StringLength(50)]
    public string ProviderFirstName { get; set; } = null!;

    [StringLength(50)]
    public string? ProviderMiddleName { get; set; }

    [StringLength(50)]
    public string ProviderLastName { get; set; } = null!;

    public int Gender { get; set; }

    [Column(TypeName = "date")]
    public DateTime Dob { get; set; }

    [StringLength(50)]
    public string? Qualification { get; set; }

    public int StructuralRoleId { get; set; }

    public int ConsultantTypeId { get; set; }

    [StringLength(150)]
    public string? PresentAddress1 { get; set; }

    public long? PresentAreaId { get; set; }

    [StringLength(10)]
    public string? PresentPin { get; set; }

    [StringLength(30)]
    public string? MobileNumber { get; set; }

    [StringLength(30)]
    public string? LandlineNumber { get; set; }

    [StringLength(80)]
    public string? EmailId { get; set; }

    [StringLength(150)]
    public string? PermanentAddress1 { get; set; }

    public long? PermanentAreaId { get; set; }

    [StringLength(10)]
    public string? PermanentPin { get; set; }

    [StringLength(200)]
    public string? PhotoUrl { get; set; }

    [StringLength(200)]
    public string? SignatureUrl { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [ForeignKey("ConsultantTypeId")]
    [InverseProperty("MProviderConsultantTypes")]
    public virtual MGeneralLookup ConsultantType { get; set; } = null!;

    [ForeignKey("Gender")]
    [InverseProperty("MProviderGenderNavigations")]
    public virtual MGeneralLookup GenderNavigation { get; set; } = null!;

    [InverseProperty("ProviderNavigation")]
    public virtual ICollection<MBillAgreementLine> MBillAgreementLines { get; set; } = new List<MBillAgreementLine>();

    [InverseProperty("Provider")]
    public virtual ICollection<MBillAutoCharge> MBillAutoCharges { get; set; } = new List<MBillAutoCharge>();

    [InverseProperty("Provider")]
    public virtual ICollection<MBillChargeExceptionLine> MBillChargeExceptionLines { get; set; } = new List<MBillChargeExceptionLine>();

    [InverseProperty("ProviderNavigation")]
    public virtual ICollection<MBillPriceTariffLine> MBillPriceTariffLines { get; set; } = new List<MBillPriceTariffLine>();

    [InverseProperty("Provider")]
    public virtual ICollection<MFacilityDepartmentProvider> MFacilityDepartmentProviders { get; set; } = new List<MFacilityDepartmentProvider>();

    [InverseProperty("Provider")]
    public virtual ICollection<MProviderCredential> MProviderCredentials { get; set; } = new List<MProviderCredential>();

    [InverseProperty("Provider")]
    public virtual ICollection<MProviderIdentification> MProviderIdentifications { get; set; } = new List<MProviderIdentification>();

    [InverseProperty("Provider")]
    public virtual ICollection<MScheduleAvailabilityCalendar> MScheduleAvailabilityCalendars { get; set; } = new List<MScheduleAvailabilityCalendar>();

    [InverseProperty("Provider")]
    public virtual ICollection<MScheduleProviderAbsence> MScheduleProviderAbsences { get; set; } = new List<MScheduleProviderAbsence>();

    [InverseProperty("Provider")]
    public virtual ICollection<MScheduleProvider> MScheduleProviders { get; set; } = new List<MScheduleProvider>();

    [ForeignKey("PermanentAreaId")]
    [InverseProperty("MProviderPermanentAreas")]
    public virtual MArea? PermanentArea { get; set; }

    [ForeignKey("PresentAreaId")]
    [InverseProperty("MProviderPresentAreas")]
    public virtual MArea? PresentArea { get; set; }

    [ForeignKey("ProviderTitle")]
    [InverseProperty("MProviderProviderTitleNavigations")]
    public virtual MGeneralLookup ProviderTitleNavigation { get; set; } = null!;

    [ForeignKey("StructuralRoleId")]
    [InverseProperty("MProviderStructuralRoles")]
    public virtual MGeneralLookup StructuralRole { get; set; } = null!;

    [InverseProperty("SecondaryProvider")]
    public virtual ICollection<TEncounter> TEncounters { get; set; } = new List<TEncounter>();

    [InverseProperty("ProviderNavigation")]
    public virtual ICollection<TPatientAccountAuthorizationLine> TPatientAccountAuthorizationLines { get; set; } = new List<TPatientAccountAuthorizationLine>();

    [InverseProperty("PreparedByNavigation")]
    public virtual ICollection<TPatientAccountBill> TPatientAccountBills { get; set; } = new List<TPatientAccountBill>();

    [InverseProperty("Provider")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountCharges { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("AcknowledgedByNavigation")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrders { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("Provider")]
    public virtual ICollection<TPatientAccountPackageSubscription> TPatientAccountPackageSubscriptions { get; set; } = new List<TPatientAccountPackageSubscription>();

    [InverseProperty("Provider")]
    public virtual ICollection<TPatientAccountProcedureCharge> TPatientAccountProcedureCharges { get; set; } = new List<TPatientAccountProcedureCharge>();

    [InverseProperty("Provider")]
    public virtual ICollection<TPatientAccountProcedureChargesDetail> TPatientAccountProcedureChargesDetails { get; set; } = new List<TPatientAccountProcedureChargesDetail>();

    [InverseProperty("CancelApprovedByNavigation")]
    public virtual ICollection<TPatientDischarge> TPatientDischargeCancelApprovedByNavigations { get; set; } = new List<TPatientDischarge>();

    [InverseProperty("DischargeAdvisedByNavigation")]
    public virtual ICollection<TPatientDischarge> TPatientDischargeDischargeAdvisedByNavigations { get; set; } = new List<TPatientDischarge>();

    [InverseProperty("Provider")]
    public virtual ICollection<TScheduleProviderAppointment> TScheduleProviderAppointments { get; set; } = new List<TScheduleProviderAppointment>();
}
