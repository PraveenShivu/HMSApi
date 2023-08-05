using HMS_View_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Data_Layer.HMS_IData
{
    public interface IPatient : IDisposable
    {
        Task<IList<PatientModel>> GetAllPatients();
        Task<long> UpdatePatientDetailsAsync(PatientModel patient, UserContext userContext);
        Task<bool> DeletePatientById(long PatientId, UserContext userContext);
        Task<IList<PatientModel>> GetPatientDetailsBasedOnIdAsync(long PatientId, UserContext userContext);
        Task<long> AddNewPatientDetailsAsync(PatientModel patient, UserContext userContext);
        Task<string> GetDateFormatForFacilityAsync(int facilityId, UserContext userContext);
    }
}
