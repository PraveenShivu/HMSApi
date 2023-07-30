using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HMS_Data_Layer.DBContext;

[Table("m_PatientsRegistration")]
[Index("UhId", Name = "uc_UHID", IsUnique = true)]
public partial class MPatientsRegistration
{
    [Key]
    public long PatientId { get; set; }

    [StringLength(50)]
    public string UhId { get; set; } = null!;

    public int FacilityId { get; set; }

    public int PatientTitle { get; set; }

    [StringLength(50)]
    public string PatientFirstName { get; set; } = null!;

    [StringLength(50)]
    public string? PatientMiddleName { get; set; }

    [StringLength(50)]
    public string PatientLastName { get; set; } = null!;

    public int? FhTitle { get; set; }

    [StringLength(50)]
    public string? FhName { get; set; }

    public int? Gender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [StringLength(150)]
    public string? PresentAddress1 { get; set; }

    public long? PresentAreaId { get; set; }

    [StringLength(10)]
    public string? PresentPin { get; set; }

    [StringLength(30)]
    public string? MobileNo { get; set; }

    [StringLength(30)]
    public string? LandlineNo { get; set; }

    [StringLength(80)]
    public string? EmailId { get; set; }

    [StringLength(150)]
    public string? PermanentAddress1 { get; set; }

    public long? PermanentAreaId { get; set; }

    [StringLength(10)]
    public string? PermanentPin { get; set; }

    [StringLength(20)]
    public string? BirthPlace { get; set; }

    [StringLength(100)]
    public string? BirthIdentification1 { get; set; }

    [StringLength(100)]
    public string? BirthIdentification2 { get; set; }

    public int? MaritalStatus { get; set; }

    public int? PrimaryLanguageId { get; set; }

    [StringLength(1)]
    public string? CanSpeakEnglish { get; set; }

    public int? ReligionId { get; set; }

    public int? EthnicityId { get; set; }

    public int? BloodGroup { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Height { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? Weight { get; set; }

    [StringLength(200)]
    public string? PhotoUrl { get; set; }

    [StringLength(20)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDateTime { get; set; }

    [StringLength(20)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDateTime { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(100)]
    public string? Occupation { get; set; }

    [ForeignKey("BloodGroup")]
    [InverseProperty("MPatientsRegistrationBloodGroupNavigations")]
    public virtual MGeneralLookup? BloodGroupNavigation { get; set; }

    [ForeignKey("EthnicityId")]
    [InverseProperty("MPatientsRegistrationEthnicities")]
    public virtual MGeneralLookup? Ethnicity { get; set; }

    [ForeignKey("FhTitle")]
    [InverseProperty("MPatientsRegistrationFhTitleNavigations")]
    public virtual MGeneralLookup? FhTitleNavigation { get; set; }

    [ForeignKey("Gender")]
    [InverseProperty("MPatientsRegistrationGenderNavigations")]
    public virtual MGeneralLookup? GenderNavigation { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<MMrpStoreIndent> MMrpStoreIndents { get; set; } = new List<MMrpStoreIndent>();

    [InverseProperty("Patient")]
    public virtual ICollection<MPatientsIdentification> MPatientsIdentifications { get; set; } = new List<MPatientsIdentification>();

    [ForeignKey("MaritalStatus")]
    [InverseProperty("MPatientsRegistrationMaritalStatusNavigations")]
    public virtual MGeneralLookup? MaritalStatusNavigation { get; set; }

    [ForeignKey("PatientTitle")]
    [InverseProperty("MPatientsRegistrationPatientTitleNavigations")]
    public virtual MGeneralLookup PatientTitleNavigation { get; set; } = null!;

    [ForeignKey("PermanentAreaId")]
    [InverseProperty("MPatientsRegistrationPermanentAreas")]
    public virtual MArea? PermanentArea { get; set; }

    [ForeignKey("PresentAreaId")]
    [InverseProperty("MPatientsRegistrationPresentAreas")]
    public virtual MArea? PresentArea { get; set; }

    [ForeignKey("PrimaryLanguageId")]
    [InverseProperty("MPatientsRegistrationPrimaryLanguages")]
    public virtual MGeneralLookup? PrimaryLanguage { get; set; }

    [ForeignKey("ReligionId")]
    [InverseProperty("MPatientsRegistrationReligions")]
    public virtual MGeneralLookup? Religion { get; set; }

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientAccountAssignedPlan> TPatientAccountAssignedPlans { get; set; } = new List<TPatientAccountAssignedPlan>();

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientAccountBill> TPatientAccountBills { get; set; } = new List<TPatientAccountBill>();

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientAccountCharge> TPatientAccountCharges { get; set; } = new List<TPatientAccountCharge>();

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientAccountLedger> TPatientAccountLedgers { get; set; } = new List<TPatientAccountLedger>();

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientAccountOrder> TPatientAccountOrders { get; set; } = new List<TPatientAccountOrder>();

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientAccountPackageSubscription> TPatientAccountPackageSubscriptions { get; set; } = new List<TPatientAccountPackageSubscription>();

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientAccountProcedureCharge> TPatientAccountProcedureCharges { get; set; } = new List<TPatientAccountProcedureCharge>();

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientDischarge> TPatientDischarges { get; set; } = new List<TPatientDischarge>();

    [InverseProperty("Patient")]
    public virtual ICollection<TPatientMovement> TPatientMovements { get; set; } = new List<TPatientMovement>();

    [InverseProperty("Patient")]
    public virtual ICollection<TScheduleProviderAppointment> TScheduleProviderAppointments { get; set; } = new List<TScheduleProviderAppointment>();

    [InverseProperty("Patient")]
    public virtual ICollection<TTransaction> TTransactions { get; set; } = new List<TTransaction>();
}
