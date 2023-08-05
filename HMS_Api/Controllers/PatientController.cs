using HMS_Data_Layer.HMS_Data;
using HMS_Data_Layer.HMS_IData;
using HMS_View_Models.Models;
using HMS_View_Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ApplicationController
    {
        private IPatient patientManager;
        public PatientController()
        {
            patientManager = new Patient();
        }

        [HttpGet]
        public async Task<string> GetAllPatients()
        {
            PatientViewModel model = new PatientViewModel();
            model.Patients = await patientManager.GetAllPatients();
            var x = GetJsonData(model);
            return await Task.Run(()=> x);

        }

        [HttpPut]
        public async Task<string> UpdatePatientDetails([FromQuery]PatientModel Patient)
        {
           // string DateFormat = await facilityManager.GetDateFormatForFacilityAsync(1, userContext);
          //  Patient.DateOfBirth = !string.IsNullOrEmpty(Patient.Dob) ? (DateTime?)DateTime.ParseExact(Patient.Dob, DateFormat, null) : null;
           // Patient.ModifiedDateTime = Convert.ToDateTime(Patient.ModifiedTime);
          
            long PatientId = await patientManager.UpdatePatientDetailsAsync(Patient, userContext);
            if (PatientId > 0)
            {
                return "true";
            }
            else 
            { 
                return "false";
            }
           
        }

        [HttpDelete]
        public async Task<string> DeletePatientById(long PatientId)
        {
          
            
            bool DeletePatient = await patientManager.DeletePatientById(PatientId, userContext);
            if (DeletePatient == true)
            {
                return "true";
            }
            else
            {
                return "false";
            }
            // model.DrNotesList = DataMapper.ConvertToViewModel(await clinicalSetupManager.GetDrNotesList(PatientId, EncounterId, userContext));
            //return this.PartialView("_DrNoteTable", model);
        }

        [HttpGet("EditPatientById")]
        public async Task<string> EditPatientById(long PatientId) 
        {

            //PatientModel PatientDetail = DataMapper.ConvertToViewModel(await patientManager.GetPatientDetailsBasedOnIdAsync(PatientId, userContext));
            PatientViewModel model = new PatientViewModel();
            model.Patients = await patientManager.GetPatientDetailsBasedOnIdAsync(PatientId, userContext);
             var x = GetJsonData(model);
            return await Task.Run(() => x);
     
        }


        [HttpPost("AddNewPatient")]
        public async Task<string> AddNewPatient([FromQuery]PatientModel Patient)
        {
           // string DateFormat = await patientManager.GetDateFormatForFacilityAsync(1, userContext);
            //Patient.DateOfBirth = DateTime.ParseExact(Patient.Dob, DateFormat, null); 
           
            Patient.FacilityId = 1; //Get the facility Id from session
           
            //bool IsPatientAlreadyExists = await patientManager.IsPatientDetailsAlreadyExists(DataMapper.ConvertToViewModel(Patient), userContext);
            long PatientId = await patientManager.AddNewPatientDetailsAsync(Patient, userContext);

            if (PatientId > 0)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }

    }
}
