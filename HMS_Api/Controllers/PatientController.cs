using HMS_Data_Layer.HMS_Data;
using HMS_Data_Layer.HMS_IData;
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


    }
}
