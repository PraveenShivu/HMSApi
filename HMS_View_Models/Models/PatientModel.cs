using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_View_Models.Models
{
    public class PatientModel
    {
        public long PatientId { get; set; }
        public string UhId { get; set; }
        public int FacilityId { get; set; }
        public int PatientTitle { get; set; }
        public string PatientTitleName { get; set; }
        public string StateName { get; set; }
        public string PlaceName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string PatientLastName { get; set; }
        public int? FatherHusbandTitle { get; set; }
        public string FatherHusbandName { get; set; }
        public int? Gender { get; set; }
        public string PatientGender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PresentAddress1 { get; set; }
        public long? PresentAreaId { get; set; }
        public string PresentAreaName { get; set; }
        public string PresentPinCode { get; set; }
        public string MobileNumber { get; set; }
        public string MobileNumber1 { get; set; }
        public string LandlineNumber { get; set; }
        public string EmailId { get; set; }
        public string EmailId1 { get; set; }
        public string PermanentAddress1 { get; set; }
        public long? PermanentAreaId { get; set; }
        public string PermanentPinCode { get; set; }
        public string BirthPlace { get; set; }
        public string BirthIdentification1 { get; set; }
        public string BirthIdentification2 { get; set; }
        public string Occupation { get; set; }
        public string QueueStatus { get; set; }
        public int? MaritalStatus { get; set; }
        public int? PrimaryLanguageId { get; set; }
        public string CanSpeakEnglish { get; set; }
        public int? ReligionId { get; set; }
        public int? EthnicityId { get; set; }
        public int? BloodGroup { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string PhotoUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string ModifiedTime { get; set; }
        public bool ActiveFlag { get; set; }
        public int PresentCountryId { get; set; }
        public int PermanentCountryId { get; set; }
        public int PresentStateId { get; set; }
        public int PermanentStateId { get; set; }
        public long PresentPlaceId { get; set; }
        public long PermanentPlaceId { get; set; }
        public string Dob { get; set; }
        public string Age { get; set; }
        public string EncounterId { get; set; }
        public long? Encounter { get; set; }
        public string ProviderName { get; set; }
        public long ProviderID { get; set; }
    }
}
