using HMS_Data_Layer.DBContext;
using HMS_Data_Layer.HMS_IData;
using HMS_View_Models.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace HMS_Data_Layer.HMS_Data
{
    public class Patient : IPatient
    {
        public HMS_Api_DbContext context;
        public Patient()
            : this(new HMS_Api_DbContext())
        {

        }
        public Patient(HMS_Api_DbContext context)
        {
            this.context = context;
        }

        public async Task<IList<PatientModel>> GetAllPatients()
        {
            return await (from Patient in context.MPatientsRegistrations.AsNoTracking().Where(p => p.ActiveFlag == true)
                          join tgender in context.MGeneralLookups.AsNoTracking() on Patient.Gender equals tgender.LookupId into genderSet
                          from gender in genderSet.DefaultIfEmpty()
                          select new PatientModel
                          {
                              PatientId = Patient.PatientId,
                              UhId = Patient.UhId,
                              FacilityId = Patient.FacilityId,
                              PatientTitle = Patient.PatientTitle,
                              PatientFirstName = Patient.PatientFirstName,
                              PatientMiddleName = Patient.PatientMiddleName,
                              PatientLastName = Patient.PatientLastName,
                              DateOfBirth = (DateTime)Patient.Dob,
                              Gender = Patient.Gender,
                              //PatientGender = Patient.Mg.LookupDescription,
                              MobileNumber = Patient.MobileNo,
                              LandlineNumber = Patient.LandlineNo,
                              EmailId = Patient.EmailId,
                              ActiveFlag = Patient.ActiveFlag,
                              ModifiedDateTime = Patient.ModifiedDateTime.Value
                          }).ToListAsync();
        }


        public async Task<long>  AddNewPatientDetailsAsync(PatientModel patient, UserContext userContext)
        {
            using (TransactionScope Trans = new TransactionScope())
            {

                long PatientId = default(long);
                string PatientUHID = "";
                
                using (HMS_Api_DbContext context = new HMS_Api_DbContext())
                {
                    try
                    {
                        //int facilityId = 1;
                        //bool isSeqs = true;
                        //string UHID = "UHID";
                        int facilityId = 1; // Set your values
                        string generatedIdFor = "UHID";
                        bool activeFlag = true;

                        var configuration = context.MConfigurations
                            .Where(c =>
                                c.FacilityId == facilityId &&
                                c.GenerateIdFor == generatedIdFor &&
                                c.ActiveFlag == activeFlag)
                            .FirstOrDefault();

                        if (configuration != null)
                        {
                            configuration.IdLastNumber += configuration.IdIncrement;
                            PatientUHID = $"{configuration.IdPrefix}{configuration.IdLastNumber}{configuration.IdSuffix}";

                            // Save changes to the database
                            context.SaveChanges();

                            // "newUhidSeq" now holds the concatenated result
                        }

                        if (string.IsNullOrEmpty(PatientUHID))
                        {
                            return -1;
                        }


                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        throw;
                    }
                    

                    MPatientsRegistration newPatientDetails = new MPatientsRegistration
                    {
                        UhId = PatientUHID,
                        FacilityId = patient.FacilityId,
                        PatientTitle = patient.PatientTitle,
                        PatientFirstName = patient.PatientFirstName.TrimStart().TrimEnd(),
                        PatientMiddleName = string.IsNullOrEmpty(patient.PatientMiddleName) ? default(string) : patient.PatientMiddleName.TrimStart().TrimEnd(),
                        PatientLastName = patient.PatientLastName.TrimStart().TrimEnd(),
                        Gender = patient.Gender,
                        FhTitle = patient.FatherHusbandTitle,
                        FhName = string.IsNullOrEmpty(patient.FatherHusbandName) ? default(string) : patient.FatherHusbandName.TrimStart().TrimEnd(),
                        Dob = patient.DateOfBirth,
                        PresentAddress1 = patient.PresentAddress1,
                        PresentAreaId = patient.PresentAreaId,
                        PresentPin = patient.PresentPinCode,
                        MobileNo = patient.MobileNumber,
                        LandlineNo = patient.LandlineNumber,
                        EmailId = patient.EmailId,
                        PermanentAddress1 = patient.PermanentAddress1,
                        PermanentAreaId = patient.PermanentAreaId,
                        PermanentPin = patient.PermanentPinCode,
                        BirthPlace = patient.BirthPlace,
                        BirthIdentification1 = patient.BirthIdentification1,
                        BirthIdentification2 = patient.BirthIdentification2,
                        Occupation = patient.Occupation,
                        MaritalStatus = patient.MaritalStatus,
                        PrimaryLanguageId = patient.PrimaryLanguageId,
                        CanSpeakEnglish = patient.CanSpeakEnglish,
                        ReligionId = patient.ReligionId,
                        EthnicityId = patient.EthnicityId,
                        BloodGroup = patient.BloodGroup,
                        Height = patient.Height,
                        Weight = patient.Weight,
                        PhotoUrl = patient.PhotoUrl,
                        CreatedDateTime = DateTime.UtcNow,
                        ModifiedDateTime = DateTime.UtcNow,
                        ActiveFlag = true,
                        CreatedBy = userContext?.AppUserId.ToString()

                    };
                    context.MPatientsRegistrations.Add(newPatientDetails);
                    context.SaveChanges();


                    PatientId = newPatientDetails.PatientId;
                }
                Trans.Complete();
                return PatientId;
            }
        }

        public async Task<long> UpdatePatientDetailsAsync(PatientModel patient, UserContext UserContext)
        {
            using (HMS_Api_DbContext context = new HMS_Api_DbContext())
            {
                MPatientsRegistration patientRegistration = await context.MPatientsRegistrations.Where(p => p.PatientId == patient.PatientId).FirstOrDefaultAsync();


                try
                {
                    if (patientRegistration != null)
                    {
                        patientRegistration.UhId = patient.ActiveFlag == false ? patient.UhId.Substring(3) : patient.UhId;
                        patientRegistration.FacilityId = patient.FacilityId;
                        patientRegistration.PatientTitle = patient.PatientTitle;
                        patientRegistration.PatientFirstName = patient.PatientFirstName.TrimStart().TrimEnd();
                        patientRegistration.PatientMiddleName = string.IsNullOrEmpty(patient.PatientMiddleName) ? default(string) : patient.PatientMiddleName.TrimStart().TrimEnd();
                        patientRegistration.PatientLastName = patient.PatientLastName.TrimStart().TrimEnd();
                        patientRegistration.Gender = patient.Gender;
                        patientRegistration.FhTitle = patient.FatherHusbandTitle;
                        patientRegistration.FhName = string.IsNullOrEmpty(patient.FatherHusbandName) ? default(string) : patient.FatherHusbandName.TrimStart().TrimEnd();
                        patientRegistration.Dob = patient.DateOfBirth;
                        patientRegistration.PresentAddress1 = patient.PresentAddress1;
                        patientRegistration.PresentAreaId = patient.PresentAreaId;
                        patientRegistration.PresentPin = patient.PresentPinCode;
                        patientRegistration.MobileNo = patient.MobileNumber;
                        patientRegistration.LandlineNo = patient.LandlineNumber;
                        patientRegistration.EmailId = patient.EmailId;
                        patientRegistration.PermanentAddress1 = patient.PermanentAddress1;
                        patientRegistration.PermanentAreaId = patient.PermanentAreaId;
                        patientRegistration.PermanentPin = patient.PermanentPinCode;
                        patientRegistration.BirthPlace = patient.BirthPlace;
                        patientRegistration.BirthIdentification1 = patient.BirthIdentification1;
                        patientRegistration.BirthIdentification2 = patient.BirthIdentification2;
                        patientRegistration.Occupation = patient.Occupation;
                        patientRegistration.MaritalStatus = patient.MaritalStatus;
                        patientRegistration.PrimaryLanguageId = patient.PrimaryLanguageId;
                        patientRegistration.CanSpeakEnglish = patient.CanSpeakEnglish;
                        patientRegistration.ReligionId = patient.ReligionId;
                        patientRegistration.EthnicityId = patient.EthnicityId;
                        patientRegistration.BloodGroup = patient.BloodGroup;
                        patientRegistration.Height = patient.Height;
                        patientRegistration.Weight = patient.Weight;
                        patientRegistration.PhotoUrl = patient.PhotoUrl;
                        patientRegistration.ActiveFlag = true;
                        //patientRegistration.ModifiedBy = UserContext?.AppUserId.ToString();
                        patientRegistration.ModifiedDateTime = DateTime.UtcNow;

                        context.Entry(patientRegistration).State = EntityState.Modified;

                        await context.SaveChangesAsync();
                        return patientRegistration.PatientId;
                    }
                }
                catch (Exception ex)
                {


                }

            }
            return -1;

        }


        public async Task<bool> DeletePatientById(long PatientId, UserContext UserContext)
        {
            using (HMS_Api_DbContext context = new HMS_Api_DbContext())
            {
                MPatientsRegistration patientRegistration = await context.MPatientsRegistrations.Where(p => p.PatientId == PatientId).FirstOrDefaultAsync();


                try
                {
                    if (patientRegistration != null)
                    {
                        patientRegistration.ActiveFlag = false;

                        context.Entry(patientRegistration).State = EntityState.Modified;

                        await context.SaveChangesAsync();
                        return true;
                    }
                }
                catch (Exception ex)
                {


                }

            }
            return false;

        }



        public async Task<IList<PatientModel>> GetPatientDetailsBasedOnIdAsync(long PatientId, UserContext UserContext)
        {
            using (HMS_Api_DbContext context = new HMS_Api_DbContext())
            {
                MPatientsRegistration patientRegistration = await context.MPatientsRegistrations.Where(p => p.PatientId == PatientId).FirstOrDefaultAsync();

                return await (from Patient in context.MPatientsRegistrations.AsNoTracking().Where(p => p.ActiveFlag == true && p.PatientId == PatientId)

                              select new PatientModel
                              {
                                  PatientId = Patient.PatientId,
                                  UhId = Patient.UhId,
                                  FacilityId = Patient.FacilityId,
                                  PatientTitle = Patient.PatientTitle,
                                  PatientFirstName = Patient.PatientFirstName,
                                  PatientMiddleName = Patient.PatientMiddleName,
                                  PatientLastName = Patient.PatientLastName,
                                  DateOfBirth = (DateTime)Patient.Dob,
                                  Gender = Patient.Gender,
                                  //PatientGender = Patient.Mg.LookupDescription,
                                  MobileNumber = Patient.MobileNo,
                                  LandlineNumber = Patient.LandlineNo,
                                  EmailId = Patient.EmailId,
                                  ActiveFlag = Patient.ActiveFlag,
                                  ModifiedDateTime = Patient.ModifiedDateTime.Value
                              }).ToListAsync();

            }
        }



        public async Task<string> GetDateFormatForFacilityAsync(int facilityId, UserContext UserContext)
        {
            using (HMS_Api_DbContext context = new HMS_Api_DbContext())
            {
                return await context.MFacilities.AsNoTracking().Where(m => m.ActiveFlag == true && m.FacilityId == facilityId).Select(e => e.DateFormat).FirstOrDefaultAsync();
            }
        }


       
        ~Patient()
        {
            Dispose(false);
        }

        private bool IsDisposed = false;

        public virtual void Dispose(bool Disposing)
        {
            if (IsDisposed)
                return;

            if (Disposing)
            {
                //free managed objects... IN this case it doesnt exist..
            }

            //if (context != null)
            //    context.Dispose();

            IsDisposed = true;

        }
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
    }
}
