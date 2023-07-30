using HMS_Data_Layer.DBContext;
using HMS_Data_Layer.HMS_IData;
using HMS_View_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
